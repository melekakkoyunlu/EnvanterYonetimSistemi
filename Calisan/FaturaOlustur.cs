using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvanterYönetimSistemi.Calisan
{
    public partial class FaturaOlustur : Form
    {
        public FaturaOlustur()
        {
            InitializeComponent();
        }

        private void FaturaOlustur_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'envanterYonetimDataSet1.Siparis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.siparisTableAdapter.Fill(this.envanterYonetimDataSet1.Siparis);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MenuCalisan menuCalisan = new MenuCalisan();
            menuCalisan.Show();
            this.Close();
        }

        private void btn_olustur_Click(object sender, EventArgs e)
        {
            if (dgv_fatura.SelectedRows.Count > 0)
            {
                try {
                    DataGridViewRow selectedRow = dgv_fatura.SelectedRows[0];
                    int siparisID = Convert.ToInt32(selectedRow.Cells["SiparisID"].Value);
                    int musteriID = Convert.ToInt32(selectedRow.Cells["MusteriID"].Value);

                    Fatura fatura = new Fatura(siparisID);
                    fatura.Show();
                }
                catch(Exception ex) { MessageBox.Show("Hata:" + ex); }
            }
                
        }
    }
}
