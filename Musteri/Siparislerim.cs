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

namespace EnvanterYönetimSistemi.Musteri
{
    public partial class Siparislerim : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G23CHID;Initial Catalog=EnvanterYonetim;Integrated Security=True");
        private int musteriID;
        public Siparislerim(int musteriID)
        {
            InitializeComponent();
            this.musteriID = musteriID;
        }

        private void Siparislerim_Load(object sender, EventArgs e)
        {
            LoadSiparisler();

        }

        private void LoadSiparisler()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand($"SELECT UrunAd, Adet, ToplamFiyat, SiparisDurumu, SiparisTarihi FROM Siparisler WHERE MusteriID = '{musteriID}';", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dTable = new DataTable();
                adapter.Fill(dTable);

                dgv_siparisler.DataSource = dTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MenuMusteri menuMusteri = new MenuMusteri(musteriID);
            menuMusteri.Show();
            this.Close();
        }


    }
}
