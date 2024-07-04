using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvanterYönetimSistemi.Calisan
{
    public partial class SiparisYonetim : Form
    {
        public SiparisYonetim()
        {
            InitializeComponent();
            StokUyari();
        }

        private void SiparisYonetim_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'envanterYonetimDataSet.Siparis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.siparisTableAdapter.Fill(this.envanterYonetimDataSet.Siparis);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MenuCalisan menuCalisan = new MenuCalisan();
            menuCalisan.Show();
            this.Close();
        }
        private void LoadSiparisler()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G23CHID;Initial Catalog=EnvanterYonetim;Integrated Security=True"))
                {
                    conn.Open();
                    string query = @" SELECT * FROM Siparis";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dTable = new DataTable();
                    adapter.Fill(dTable);

                    dgv_gelenSiparis.AutoGenerateColumns = true; 

                    dgv_gelenSiparis.DataSource = dTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }
        private void StokUyari()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G23CHID;Initial Catalog=EnvanterYonetim;Integrated Security=True"))
                {
                    conn.Open();
                    string query = "SELECT UrunID, UrunAd, StokMiktar FROM Urun WHERE StokMiktar < 10";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        int urunID = reader.GetInt32(0);
                        string urunAd = reader.GetString(1);
                        int stokMiktar = reader.GetInt32(2);

                        MessageBox.Show($"'{urunAd}' adlı ürünün stok miktarı {stokMiktar} adete düştü! Stok miktarını yeniden değerlendirin.");

                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }


        private void UpdateSiparisDurum(string durum)
        {
            if (dgv_gelenSiparis.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dgv_gelenSiparis.SelectedRows[0];
                    int siparisID = Convert.ToInt32(selectedRow.Cells["SiparisID"].Value);

                    using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G23CHID;Initial Catalog=EnvanterYonetim;Integrated Security=True"))
                    {
                        conn.Open();

                        string updateQuery = $"UPDATE Siparis SET SiparisDurum = '{durum}' WHERE SiparisID = {siparisID}";
                        SqlCommand cmd = new SqlCommand(updateQuery, conn);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("İşlem başarılı.");

                            if (durum == "Onaylandı")
                            {
                                string selectDetayQuery = $"SELECT UrunID, Adet FROM SiparisDetay WHERE SiparisID = {siparisID}";
                                SqlCommand selectDetayCmd = new SqlCommand(selectDetayQuery, conn);
                                SqlDataReader reader = selectDetayCmd.ExecuteReader();

                                List<Tuple<int, int>> urunDetaylari = new List<Tuple<int, int>>();

                                while (reader.Read())
                                {
                                    int urunID = reader.GetInt32(0);
                                    int adet = reader.GetInt32(1);
                                    urunDetaylari.Add(new Tuple<int, int>(urunID, adet));
                                }

                                reader.Close();

                                foreach (var urunDetay in urunDetaylari)
                                {
                                    int urunID = urunDetay.Item1;
                                    int adet = urunDetay.Item2;

                                    string updateStokQuery = $"UPDATE Urun SET StokMiktar = StokMiktar - {adet} WHERE UrunID = {urunID}";
                                    SqlCommand updateStokCmd = new SqlCommand(updateStokQuery, conn);
                                    updateStokCmd.ExecuteNonQuery();
                                }
                            }

                            LoadSiparisler();
                        }
                        else
                        {
                            MessageBox.Show("Sipariş işlemi sırasında bir hata oluştu.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen işlem yapmak istediğiniz bir sipariş seçin.");
            }
        }


        private void btn_onayla_Click(object sender, EventArgs e)
        {
            UpdateSiparisDurum("Onaylandı");


        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            UpdateSiparisDurum("İptal Edildi");
        }
    }
 }
 

