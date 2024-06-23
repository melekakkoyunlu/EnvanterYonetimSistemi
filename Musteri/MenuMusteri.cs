using EnvanterYönetimSistemi.Musteri;
using System;
using System.CodeDom;
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
using System.Globalization;

namespace EnvanterYönetimSistemi
{
    public partial class MenuMusteri : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G23CHID;Initial Catalog=EnvanterYonetim;Integrated Security=True");
        private int musteriID;
        public List<SepetUrun> sepet = new List<SepetUrun>();
        decimal toplamFiyat = 0;

        public MenuMusteri(int musteriID)
        {
            InitializeComponent();
            this.musteriID = musteriID;
        }

        private void MenuMusteri_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'envanterYonetimDataSet.Urun' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.urunTableAdapter.Fill(this.envanterYonetimDataSet.Urun);
        }
        private void btn_hesapla_Click_1(object sender, EventArgs e)
        {
            if (cb_urun.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir ürün seçin.");
                return;
            }

            DataRowView selectedRow = (DataRowView)cb_urun.SelectedItem;
            string urunAd = selectedRow["UrunAd"].ToString();
            decimal birimFiyat = (decimal)selectedRow["BirimFiyat"];
            int stok = (int)selectedRow["StokMiktar"];
            String adetTxt = txt_adet.Text;
            int adet = Convert.ToInt32(adetTxt);

            if (adet > stok)
            {
                MessageBox.Show("Yeterli stok yok.");
            }
            else
            {
                toplamFiyat = (adet * birimFiyat);
                lbl_toplam.Text = toplamFiyat.ToString("C", new CultureInfo("tr-TR"));
            }

        }
        private void btn_sepetEkle_Click(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)cb_urun.SelectedItem;
            string urunAd = selectedRow["UrunAd"].ToString();
            decimal birimFiyat = (decimal)selectedRow["BirimFiyat"];
            int stok = (int)selectedRow["StokMiktar"];
            int urunID = (int)selectedRow["UrunID"];
            String adetTxt = txt_adet.Text;
            int adet = Convert.ToInt32(adetTxt);

            sepet.Add(new SepetUrun { UrunAd = urunAd, Adet = adet, ToplamFiyat = toplamFiyat, MusteriID = musteriID, UrunID = urunID, BirimFiyat = birimFiyat });

            MessageBox.Show("Ürün sepete eklendi.");
            txt_adet.Clear();
            lbl_toplam.Text = String.Empty;

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_adet.Clear();
            lbl_toplam.Text = String.Empty;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Sepet sepetForm = new Sepet(musteriID, sepet, this);
            this.Hide();
            sepetForm.Show();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Siparislerim siparislerim = new Siparislerim(musteriID);
            siparislerim.Show();
            this.Close();
        }

        
    }
}