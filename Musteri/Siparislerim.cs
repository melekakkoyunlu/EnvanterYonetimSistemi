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
                string query = @"
                    SELECT 
                        S.SiparisID,
                        S.MusteriID,
                        U.UrunAd,
                        SD.Adet,
                        S.ToplamTutar,
                        S.SiparisDurum,
                        S.SiparisTarih
                    FROM 
                        Siparis S
                    INNER JOIN 
                        SiparisDetay SD ON S.SiparisID = SD.SiparisID
                    INNER JOIN 
                        Urun U ON SD.UrunID = U.UrunID
                    WHERE 
                        S.MusteriID = @MusteriID";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MusteriID", musteriID);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dTable = new DataTable();
                adapter.Fill(dTable);

                dgv_siparisler.AutoGenerateColumns = true;

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
