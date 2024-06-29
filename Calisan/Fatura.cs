using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvanterYönetimSistemi.Calisan
{
    public partial class Fatura : Form
    {
        public string SiparisID { get; set; }
        public string MusteriID { get; set; }
        public string MusteriAd { get; set; }
        public string Adres { get; set; }
        public string Iletisim { get; set; }
        public string ToplamTutar { get; set; }
        public string SiparisDurum { get; set; }
        public string UrunAd { get; set; }
        public string Adet { get; set; }
        public string Date { get; set; }
        private Bitmap memoryimg;
        public DataTable SiparisDetaylar { get; set; }

        public Fatura()
        {
            InitializeComponent();
            Date = DateTime.Now.ToString("M/d/yyyy");
        }

        private void Fatura_Load(object sender, EventArgs e)
        {
            lbl_date.Text = Date;
            lbl_id.Text = SiparisID;
            lbl_name.Text = MusteriAd;
            lbl_info.Text = Iletisim;
            lbl_adres.Text = Adres;
            lbl_toplam.Text = ToplamTutar;
            lbl_siparis.Text = SiparisID;

            dgv_urunler.DataSource = SiparisDetaylar;
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pageArea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pageArea.Width / 2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);
        }

        private void pic_print_Click(object sender, EventArgs e)
        {
            Print(this.panelPrint);
        }

        private void Print(Panel panel)
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrint = panel;
            getPrintArea(panel);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        private void getPrintArea(Panel panel)
        {
            memoryimg = new Bitmap(panel.Width, panel.Height);
            panel.DrawToBitmap(memoryimg, new Rectangle(0, 0, panel.Width, panel.Height));
        }

        private void pic_print_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pic_print, "Print");
        }
    }
}
