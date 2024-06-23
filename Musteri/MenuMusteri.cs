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

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        private void btn_sepetEkle_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_adet.Clear();
            lbl_toplam.Text = String.Empty;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Sepet sepetForm = new Sepet(musteriID, sepet);
            sepetForm.Show();
            this.Close();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Siparislerim siparislerim = new Siparislerim(musteriID);
            siparislerim.Show();
            this.Close();
        }

    }
}
