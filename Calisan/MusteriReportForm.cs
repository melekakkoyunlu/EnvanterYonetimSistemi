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

namespace EnvanterYönetimSistemi.Calisan
{
    public partial class MusteriReportForm : Form
    {
        String connectionString = @"Data Source=DESKTOP-G23CHID;Initial Catalog=EnvanterYonetim;Integrated Security=True";
        public MusteriReportForm()
        {
            InitializeComponent();
        }

        private void MusteriReportForm_Load(object sender, EventArgs e)
        {
            MusteriRaporLoad();
        }
        private void MusteriRaporLoad()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            SqlDataAdapter dataAdapter = new SqlDataAdapter("sp_GetCustomerSpending", conn);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet dataSet = new DataSet();

            try
            {
                conn.Open();
                dataAdapter.Fill(dataSet, "CustomerSpendingDataSet");

                ReportDataSource rds = new ReportDataSource("CustomerSpendingDataSet", dataSet.Tables["CustomerSpendingDataSet"]);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RaporForm frm = new RaporForm();
            frm.ShowDialog();
            this.Close();
        }
    }
}
