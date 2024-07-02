using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace EnvanterYönetimSistemi.Calisan
{
    public partial class RaporForm : Form
    {
        String connectionString = @"Data Source=DESKTOP-G23CHID;Initial Catalog=EnvanterYonetim;Integrated Security=True";

        public RaporForm()
        {
            InitializeComponent();
        }

        private void RaporForm_Load(object sender, EventArgs e)
        {
            MusteriRaporLoad();
        }

        private void MusteriRaporLoad()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("sp_GetTopCustomer", conn);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            System.Data.DataSet dataSet = new System.Data.DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "TopMusteriDataSet");

                ReportDataSource rds = new ReportDataSource("TopMusteriDataSet1", dataSet.Tables["TopMusteriDataSet"]);
                rv_Musteri.LocalReport.DataSources.Clear();
                rv_Musteri.LocalReport.DataSources.Add(rds);
                rv_Musteri.LocalReport.ReportPath = @"C:\Users\pikac\source\repos\EnvanterYönetimSistemi\Calisan\Reports\MusteriReport.rdlc"; 
                rv_Musteri.LocalReport.Refresh();
                rv_Musteri.RefreshReport();
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
    }
}
