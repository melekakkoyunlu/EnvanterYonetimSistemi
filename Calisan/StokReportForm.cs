using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EnvanterYönetimSistemi.Calisan.Reports
{
    public partial class StokReportForm : Form
    {
        private String connectionString = @"Data Source=DESKTOP-G23CHID;Initial Catalog=EnvanterYonetim;Integrated Security=True";

        public StokReportForm()
        {
            InitializeComponent();
        }

        private void StokReportForm_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            string query = "SELECT * FROM Urun";
            DataTable dataTable = GetData(query);

            rv_stok.LocalReport.DataSources.Clear();
            rv_stok.LocalReport.DataSources.Add(new ReportDataSource("StokReportDataSet", dataTable));
            rv_stok.LocalReport.ReportPath = @"C:\Users\pikac\source\repos\EnvanterYönetimSistemi\Calisan\Reports\StokReport.rdlc";

            rv_stok.RefreshReport();
        }

        private DataTable GetData(string query)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    dataTable.Load(reader); 
                }
            }

            return dataTable;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RaporForm frm = new RaporForm();
            frm.ShowDialog();
            this.Close();
        }
    }
}
