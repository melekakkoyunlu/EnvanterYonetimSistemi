using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvanterYönetimSistemi.Giris
{
    public partial class MusteriBilgiForm : Form
    {
        public string MusteriAd { get; private set; }
        public string Iletisim { get; private set; }
        public string Adres { get; private set; }
        public MusteriBilgiForm()
        {
            InitializeComponent();
        }

        private void MusteriBilgiForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            MusteriAd = txt_musteriAd.Text.ToString();
            Iletisim = txt_iletisim.Text.ToString();
            Adres = txt_adres.Text.ToString();

            if (string.IsNullOrEmpty(MusteriAd) || string.IsNullOrEmpty(Iletisim) || string.IsNullOrEmpty(Adres))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
