using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using EnvanterYönetimSistemi.Calisan.Reports;
using Microsoft.Reporting.WinForms;

namespace EnvanterYönetimSistemi.Calisan
{
    public partial class RaporForm : Form
    {

        public RaporForm()
        {
            InitializeComponent();
        }

        private void RaporForm_Load(object sender, EventArgs e)
        {
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MenuCalisan menuCalisan = new MenuCalisan();
            menuCalisan.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MusteriReportForm frm = new MusteriReportForm();
            frm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StokReportForm frm = new StokReportForm();
            frm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SatisRaporForm frm = new SatisRaporForm();
            frm.Show();
            this.Close();
        }
    }
}
