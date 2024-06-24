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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EnvanterYönetimSistemi
{
    public partial class UrunYonetim : Form
    {
        public UrunYonetim()
        {
            InitializeComponent();
            dgv_urunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_urunler.MultiSelect = true;
            dgv_urunler.AutoGenerateColumns = true;
            
            txt_arama.Text = "Bir kelime giriniz...";
            this.txt_arama.Enter += new System.EventHandler(this.txt_arama_Enter);
            this.txt_arama.Leave += new System.EventHandler(this.txt_arama_Leave);
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G23CHID;Initial Catalog=EnvanterYonetim;Integrated Security=True");

        private void UrunYonetim_Load(object sender, EventArgs e)
        {
            LoadUrunData();
            LoadTedarikciData();

            this.urunTableAdapter.Fill(this.envanterYonetimDataSet.Urun);
            this.tedarikciTableAdapter.Fill(this.envanterYonetimDataSet.Tedarikci);
        }

        private void LoadUrunData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G23CHID;Initial Catalog=EnvanterYonetim;Integrated Security=True"))
                {
                    conn.Open();
                    string queryTablo = "SELECT * FROM Urun";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(queryTablo, conn))
                    {
                        DataTable urunTable = new DataTable();
                        adapter.Fill(urunTable);
                        dgv_urunler.DataSource = urunTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void LoadTedarikciData()
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G23CHID;Initial Catalog=EnvanterYonetim;Integrated Security=True"))
            {
                string queryUrunEkle = "SELECT TedarikciID, TedarikciAd FROM Tedarikci";
                using (SqlCommand cmd = new SqlCommand(queryUrunEkle, conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable tedarikciTable = new DataTable();
                        tedarikciTable.Load(reader);

                        cmb_tedarikciAd.DataSource = tedarikciTable;
                        cmb_tedarikciAd.DisplayMember = "TedarikciAd";
                        cmb_tedarikciAd.ValueMember = "TedarikciID";
                    }
                }
            }
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MenuCalisan menuCalisan = new MenuCalisan();
            menuCalisan.Show();
            this.Close();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            String urunAd, stokTxt, tedarikciAd, birimFiyatTxt;
            urunAd = txt_urunAd.Text;
            stokTxt = txt_urunStok.Text;
            birimFiyatTxt = txt_urunBirimFiyat.Text;
            tedarikciAd = cmb_tedarikciAd.Text;

            int stok;
            decimal birimFiyat;

            if (string.IsNullOrWhiteSpace(urunAd) || !int.TryParse(stokTxt, out stok) || !decimal.TryParse(birimFiyatTxt, out birimFiyat) ||
                string.IsNullOrWhiteSpace(tedarikciAd))
            {
                MessageBox.Show("Lütfen tüm alanları doğru şekilde doldurun.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int tedarikciID = GetTedarikciIDByName(tedarikciAd);
            try
            {
                conn.Open();
                string querryRegister = $"INSERT INTO Urun(UrunAd, StokMiktar, BirimFiyat, TedarikciID) VALUES ('{urunAd}', '{stok}', '{birimFiyat}', '{tedarikciID}')";
                using (SqlCommand cmd = new SqlCommand(querryRegister, conn))
                {
                    cmd.ExecuteNonQuery();
                }
                LoadUrunData();
                MessageBox.Show("Ürün başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        
        private int GetTedarikciIDByName(string tedarikciAd)
        {
            int tedarikciID = -1;

            try
            {
                conn.Open();
                string query = $"SELECT TedarikciID FROM Tedarikci WHERE TedarikciAd = '{tedarikciAd}'";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        tedarikciID = Convert.ToInt32(result);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return tedarikciID;
        }
        
        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_urunAd.Clear();
            txt_urunBirimFiyat.Clear();
            txt_urunStok.Clear();
        }
        
        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_urunler.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_urunler.SelectedRows[0];

                int urunID = Convert.ToInt32(selectedRow.Cells["UrunID"].Value);
                String urunAd = selectedRow.Cells["UrunAd"].Value.ToString();
                int stok = Convert.ToInt32(selectedRow.Cells["StokMiktar"].Value);
                decimal birimFiyat = Convert.ToDecimal(selectedRow.Cells["BirimFiyat"].Value);
                int tedarikciID = Convert.ToInt32(selectedRow.Cells["TedarikciID"].Value);

                String query = "UPDATE Urun SET UrunAd = @UrunAd, StokMiktar = @StokMiktar, BirimFiyat = @BirimFiyat, TedarikciID = @TedarikciID WHERE UrunID = @UrunID;";

                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UrunID", urunID);
                        cmd.Parameters.AddWithValue("@UrunAd", urunAd);
                        cmd.Parameters.AddWithValue("@StokMiktar", stok);
                        cmd.Parameters.AddWithValue("@BirimFiyat", birimFiyat);
                        cmd.Parameters.AddWithValue("@TedarikciID", tedarikciID);

                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Ürün başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadUrunData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ürün güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek için bir ürün seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (dgv_urunler.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_urunler.SelectedRows[0];
                int urunID = Convert.ToInt32(selectedRow.Cells["UrunID"].Value);

                try
                {
                    conn.Open();
                    String queryDelete = "DELETE FROM Urun WHERE UrunID = @UrunID";
                    using (SqlCommand cmd = new SqlCommand(queryDelete, conn))
                    {
                        cmd.Parameters.AddWithValue("@UrunID", urunID);
                        cmd.ExecuteNonQuery();
                    }
                    LoadUrunData();
                    MessageBox.Show("Ürün başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir ürün seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            String aranan = txt_arama.Text.Trim();
            try
            {
                conn.Open();
                String querryArama = $"SELECT * FROM Urun WHERE UrunAd LIKE '%{aranan}%'";

                using (SqlCommand cmd = new SqlCommand(querryArama, conn))
                {
                    using(SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTableAranan = new DataTable();
                        adapter.Fill(dataTableAranan);
                        dgv_urunler.DataSource = dataTableAranan;
                    }
                }

            }
            catch (Exception ex)
            {  
                  MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void txt_arama_Enter(object sender, EventArgs e)
        {
            if (txt_arama.Text == "Bir kelime giriniz...")
            {
                txt_arama.Text = "";
                txt_arama.ForeColor = Color.DarkCyan;
            }
        }
        
        private void txt_arama_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_arama.Text))
            {
                txt_arama.Text = "Bir kelime giriniz...";
                txt_arama.ForeColor = Color.DarkCyan;
            }
        }
    }
}
    

