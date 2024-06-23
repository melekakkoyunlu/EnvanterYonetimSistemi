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
using EnvanterYönetimSistemi.Entities;

namespace EnvanterYönetimSistemi.Musteri
{
    public partial class Sepet : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G23CHID;Initial Catalog=EnvanterYonetim;Integrated Security=True");
        private int musteriID;
        private List<SepetUrun> sepet;
        private MenuMusteri menuMusteri;

        public Sepet(int musteriID, List<SepetUrun> sepet, MenuMusteri menuMusteri)
        {
            InitializeComponent();
            this.musteriID = musteriID;
            this.sepet = sepet;
            this.menuMusteri = menuMusteri ?? throw new ArgumentNullException(nameof(menuMusteri));
            LoadSepet();
        }

        private void Sepet_Load(object sender, EventArgs e)
        {

        }
        private void LoadSepet()
        {
            foreach (var item in sepet)
            {
                dgv_sepet.Rows.Add(item.UrunAd, item.Adet, item.ToplamFiyat);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (menuMusteri != null)
            {
                menuMusteri.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("MenuMusteri instance is null.");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            if (dgv_sepet.Rows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_sepet.SelectedRows[0];
                DataRowView dataRowView = (DataRowView)selectedRow.DataBoundItem;

                if (dataRowView != null)
                {
                    DataRow dataRow = dataRowView.Row;
                    dataRow.Delete();
                    dataRow.Table.AcceptChanges();
                    MessageBox.Show("Seçilen satır başarıyla silindi.");
                }
                else
                {
                    dgv_sepet.Rows.RemoveAt(selectedRow.Index);
                    MessageBox.Show("Seçilen satır başarıyla silindi.");
                }

            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
            }
        }

        private void btn_onayla_Click(object sender, EventArgs e)
        {

            foreach (SepetUrun urun in sepet)
            {
                try
                {
                    conn.Open();
                    String durum = "Onay Bekliyor";
                    String queryToSiparis = $"INSERT INTO Siparis(MusteriID,ToplamTutar,SiparisDurum) VALUES ({musteriID},{urun.ToplamFiyat},'{durum}')";
                    int siparisID;

                    using (SqlCommand cmd = new SqlCommand(queryToSiparis, conn))
                    {
                        siparisID = (int)cmd.ExecuteScalar();
                    }
                    String queryToSiparisDetay = $"INSERT INTO SiparisDetay(SiparisID,UrunID,BirimFiyat,Adet) VALUES ({siparisID},{urun.UrunID},{urun.BirimFiyat},{urun.Adet}";
                    using (SqlCommand cmd = new SqlCommand(queryToSiparisDetay, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    conn.Close();

                }
            }


        }
    }
}