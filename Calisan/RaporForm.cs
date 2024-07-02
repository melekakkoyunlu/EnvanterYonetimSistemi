using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace EnvanterYönetimSistemi.Calisan
{
    public partial class RaporForm : Form
    {
        private string connectionString =@"Data Source=DESKTOP-G23CHID;Initial Catalog=EnvanterYonetim;Integrated Security=True";

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
            DataSet dataSet = new DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "TopMusteri");

                ReportDataSource rds = new ReportDataSource("TopMusteriDataSet", dataSet.Tables["TopMusteri"]);
                rv_Musteri.LocalReport.DataSources.Clear();
                rv_Musteri.LocalReport.DataSources.Add(rds);
                rv_Musteri.LocalReport.ReportPath = @"Calisan\Reports\TopMusteriReport.rdlc"; 
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
