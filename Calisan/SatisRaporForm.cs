using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EnvanterYönetimSistemi.Calisan
{
    public partial class SatisRaporForm : Form
    {
        private String connectionString = @"Data Source=DESKTOP-G23CHID;Initial Catalog=EnvanterYonetim;Integrated Security=True";
        public SatisRaporForm()
        {
            InitializeComponent();
        }

        private void SatisRaporForm_Load(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("sp_GetYearlySalesComparison", conn);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet dataSet = new DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "YearlySalesDataSet");

                DataTable dataTable = dataSet.Tables["YearlySalesDataSet"];

                ReportDataSource rds = new ReportDataSource("YearlySalesDataSet", dataTable);
                rv_satis.LocalReport.DataSources.Clear();
                rv_satis.LocalReport.DataSources.Add(rds);
                rv_satis.LocalReport.ReportPath = @"C:\Users\pikac\source\repos\EnvanterYönetimSistemi\Calisan\Reports\SatisReport.rdlc";
                rv_satis.LocalReport.Refresh();
                rv_satis.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RaporForm frm = new RaporForm();
            frm.ShowDialog();
            this.Close();
        }
    }
}
