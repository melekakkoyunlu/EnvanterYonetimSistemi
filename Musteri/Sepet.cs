using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnvanterYönetimSistemi.Entities;

namespace EnvanterYönetimSistemi.Musteri
{
    public partial class Sepet : Form
    {
        private int musteriID;
        private List<SepetUrun> sepet;
        public Sepet(int musteriID,List<SepetUrun> sepet)
        {
            InitializeComponent();
            this.musteriID = musteriID;
            this.sepet = sepet;
            LoadSepet();
        }

        private void Sepet_Load(object sender, EventArgs e)
        {

        }
        private void LoadSepet()
        {
            dgv_sepet.Rows.Clear();
            foreach (var item in sepet)
            {
                dgv_sepet.Rows.Add(item.UrunAd, item.Adet, item.ToplamFiyat);
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MenuMusteri menuMusteri = new MenuMusteri(musteriID);
            menuMusteri.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
