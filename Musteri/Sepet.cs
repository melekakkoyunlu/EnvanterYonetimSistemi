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
                    String durum = "Onay Bekliyor";
                    String siparisTarih = DateTime.Now.ToString("yyyy-MM-dd");
                    int musteriID = this.musteriID;

                    String queryToSiparis = "INSERT INTO Siparis (MusteriID, SiparisTarih, ToplamTutar, SiparisDurum) " +
                                            "OUTPUT INSERTED.SiparisID " +
                                            "VALUES (@musteriID, @siparisTarih, @toplamTutar, @durum);";

                    int siparisID;

                    using (SqlCommand cmd = new SqlCommand(queryToSiparis, conn))
                    {
                        cmd.Parameters.AddWithValue("@musteriID", musteriID);
                        cmd.Parameters.AddWithValue("@siparisTarih", siparisTarih);
                        cmd.Parameters.AddWithValue("@toplamTutar", urun.ToplamFiyat);
                        cmd.Parameters.AddWithValue("@durum", durum);

                        siparisID = (int)cmd.ExecuteScalar(); 
                    }

                    String queryToSiparisDetay = "INSERT INTO SiparisDetay (SiparisID, UrunID, BirimFiyat, Adet) " +
                                                 "VALUES (@siparisID, @urunID, @birimFiyat, @adet);";

                    using (SqlCommand cmd = new SqlCommand(queryToSiparisDetay, conn))
                    {
                        cmd.Parameters.AddWithValue("@siparisID", siparisID);
                        cmd.Parameters.AddWithValue("@urunID", urun.UrunID);
                        cmd.Parameters.AddWithValue("@birimFiyat", urun.BirimFiyat);
                        cmd.Parameters.AddWithValue("@adet", urun.Adet);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Sipariş başarıyla oluşturuldu.");
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"SQL Hatası: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

    }
}
