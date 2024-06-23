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
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G23CHID;Initial Catalog=EnvanterYonetim;Integrated Security=True");
        private void txt_musteriAd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            String ad, iletisim, adres;
            ad = txt_musteriAd.Text;
            iletisim = txt_musteriInfo.Text;
            adres = txt_musteriAdres.Text;
            try
            {
                conn.Open();
                string querryRegister = $"INSERT INTO Musteri(MusteriAd, Iletisim, Adres) VALUES ('{ad}', '{iletisim}', '{adres}');";
                using (SqlCommand cmd = new SqlCommand(querryRegister, conn))
                {
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Müşteri başarıyla kayıt edildi.");

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

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_musteriAd.Clear();
            txt_musteriInfo.Clear();
            txt_musteriAdres.Clear();
            txt_musteriAd.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MenuCalisan menuCalisan = new MenuCalisan();
            menuCalisan.Show();
            this.Close();
        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
