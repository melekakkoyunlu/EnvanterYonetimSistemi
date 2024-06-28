using EnvanterYönetimSistemi.Calisan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvanterYönetimSistemi
{
    public partial class MenuCalisan : Form
    {
        public MenuCalisan()
        {
            InitializeComponent();
        }

        private void btn_musteri_Click(object sender, EventArgs e)
        {
            MusteriEkle musteriEkle = new MusteriEkle();
            musteriEkle.Show();
            this.Close();
        }

        private void btn_urunYonetim_Click(object sender, EventArgs e)
        {
            UrunYonetim urunYonetim = new UrunYonetim();
            urunYonetim.Show(); 
            this.Close();
        }

        private void btn_tedarikciYonetim_Click(object sender, EventArgs e)
        {
            TedarikYonetim tedarikYonetim = new TedarikYonetim();
            tedarikYonetim.Show();
            this.Close();
        }

        private void btn_siparisYonetim_Click(object sender, EventArgs e)
        {
            SiparisYonetim siparisYonetim = new SiparisYonetim();
            siparisYonetim.Show();
            this.Close();
        }

        private void MenuCalisan_Load(object sender, EventArgs e)
        {

        }

        private void btn_fatura_Click(object sender, EventArgs e)
        {
            FaturaOlustur faturaOlustur = new FaturaOlustur();
            faturaOlustur.Show();
            this.Close();
        }

        private void btn_rapor_Click(object sender, EventArgs e)
        {
            RaporOlustur raporOlustur = new RaporOlustur();
            raporOlustur.Show();
            this.Close();
        }
    }
}
