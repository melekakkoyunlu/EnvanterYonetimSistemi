using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvanterYönetimSistemi.Calisan.Reports
{
    public partial class StokReportForm : Form
    {
        String connectionString = @"Data Source=DESKTOP-G23CHID;Initial Catalog=EnvanterYonetim;Integrated Security=True";
        public StokReportForm()
        {
            InitializeComponent();
        }

        private void StokReportForm_Load(object sender, EventArgs e)
        {

            this.rv_stok.LocalReport.ReportPath = @"C:\Users\pikac\source\repos\EnvanterYönetimSistemi\Calisan\Reports\StokReport.rdlc"; 
            this.rv_stok.RefreshReport();
            SatisRaporLoad();
        }
        private void SatisRaporLoad()
        {
            rv_stok.LocalReport.DataSources.Clear();
            rv_stok.LocalReport.DataSources.Add(new ReportDataSource("StokRaporDataSet"));
            rv_stok.RefreshReport();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RaporForm frm = new RaporForm();
            frm.Show();
            this.Close();
        }
    }
}
