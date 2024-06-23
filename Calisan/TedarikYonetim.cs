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
    public partial class TedarikYonetim : Form
    {
        public TedarikYonetim()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G23CHID;Initial Catalog=EnvanterYonetim;Integrated Security=True");
        private string defaultText = "Aramak için yazın...";

        private void TedarikYonetim_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'envanterYonetimDataSet.Tedarikci' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tedarikciTableAdapter.Fill(this.envanterYonetimDataSet.Tedarikci);

        }
        private void LoadTedarikData()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G23CHID;Initial Catalog=EnvanterYonetim;Integrated Security=True"))
                {
                    conn.Open();
                    string queryTablo = "SELECT * FROM Tedarikci";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(queryTablo, conn))
                    {
                        DataTable tedarikTable = new DataTable();
                        adapter.Fill(tedarikTable);
                        dgv_tedarik.DataSource = tedarikTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            String tedarikAd, tedarikInfo;
            tedarikAd = txt_tedarikciAd.Text;
            tedarikInfo = txt_iletisim.Text;
          
            try
            {
                conn.Open();
                String querry = $"INSERT INTO Tedarikci(TedarikciAd,Iletisim) VALUES ('{tedarikAd}','{tedarikInfo}');";
                using (SqlCommand cmd = new SqlCommand(querry, conn))
                {
                    cmd.ExecuteNonQuery();
                }
                LoadTedarikData();
                MessageBox.Show("Tedarikçi başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex) 
            {
                Console.WriteLine("Bir hata oluştu: " + ex.Message);
            }
            finally { conn.Close(); }
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_iletisim.Clear();
            txt_tedarikciAd.Clear();
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            String aranan = txt_arama.Text.Trim();
            try
            {
                conn.Open();
                String querryArama = $"SELECT * FROM Tedarikci WHERE TedarikciAd LIKE '%{aranan}%'";

                using (SqlCommand cmd = new SqlCommand(querryArama, conn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTableAranan = new DataTable();
                        adapter.Fill(dataTableAranan);
                        dgv_tedarik.DataSource = dataTableAranan;
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
            if (txt_arama.Text == defaultText)
            {
                txt_arama.Text = "";
                txt_arama.ForeColor = Color.DarkCyan;
            }
        }

        private void txt_arama_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_arama.Text))
            {
                txt_arama.Text = defaultText;
                txt_arama.ForeColor = Color.DarkCyan;
            }
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            if (dgv_tedarik.SelectedRows.Count > 0) 
            { 
                DataGridViewRow selectedRow = dgv_tedarik.SelectedRows[0];
                String tedarikAd = selectedRow.Cells["TedarikciAd"].Value.ToString();
                String tedarikInfo = selectedRow.Cells["Iletisim"].Value.ToString();
                int tedarikID = Convert.ToInt32(selectedRow.Cells["TedarikciID"].Value);

                String query = $"UPDATE Tedarikci SET TedarikciAd = '{tedarikAd}', Iletisim = '{tedarikInfo}' WHERE TedarikciID = '{tedarikID}';";
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex) { MessageBox.Show("Ürün güncellenirken bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                finally {conn.Close();}
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            if (dgv_tedarik.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_tedarik.SelectedRows[0];
                int tedarikID = Convert.ToInt32(selectedRow.Cells["TedarikciID"].Value);

                try
                {
                    conn.Open();
                    String queryDelete = $"DELETE FROM Tedarikci WHERE TedarikciID = '{tedarikID}'";
                    using (SqlCommand cmd = new SqlCommand(queryDelete, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                    LoadTedarikData();
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
    }
}
