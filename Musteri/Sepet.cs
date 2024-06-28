using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            if (dgv_sepet.Rows.Count > 0 && dgv_sepet.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_sepet.SelectedRows[0];
                dgv_sepet.Rows.RemoveAt(selectedRow.Index);
                MessageBox.Show("Seçilen satır başarıyla silindi.");
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
            }
        }

        private void btn_onayla_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                foreach (SepetUrun urun in sepet)
                {
                    MessageBox.Show($"MusteriID : {musteriID}" );
                    String siparisTarih = DateTime.Now.ToString("yyyy-MM-dd");
                    String durum = "Onay Bekliyor";

                    String queryToSiparis = $"INSERT INTO Siparis (MusteriID, SiparisTarih, ToplamTutar, SiparisDurum) VALUES (@MusteriID, @SiparisTarih, @ToplamTutar, @SiparisDurum); SELECT SCOPE_IDENTITY();";
                    SqlCommand siparisCmd = new SqlCommand(queryToSiparis, conn);
                    siparisCmd.Parameters.AddWithValue("@MusteriID", musteriID);
                    siparisCmd.Parameters.AddWithValue("@SiparisTarih", siparisTarih);
                    siparisCmd.Parameters.AddWithValue("@ToplamTutar", urun.ToplamFiyat);
                    siparisCmd.Parameters.AddWithValue("@SiparisDurum", durum);

                    int siparisID = Convert.ToInt32(siparisCmd.ExecuteScalar());

                    String queryToSiparisDetay = $"INSERT INTO SiparisDetay (SiparisID, UrunID, BirimFiyat, Adet) VALUES (@SiparisID, @UrunID, @BirimFiyat, @Adet)";
                    SqlCommand siparisDetayCmd = new SqlCommand(queryToSiparisDetay, conn);
                    siparisDetayCmd.Parameters.AddWithValue("@SiparisID", siparisID);
                    siparisDetayCmd.Parameters.AddWithValue("@UrunID", urun.UrunID);
                    siparisDetayCmd.Parameters.AddWithValue("@BirimFiyat", urun.BirimFiyat);
                    siparisDetayCmd.Parameters.AddWithValue("@Adet", urun.Adet);
                    siparisDetayCmd.ExecuteNonQuery();
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
