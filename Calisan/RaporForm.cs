using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace EnvanterYönetimSistemi.Calisan
{
    public partial class RaporForm : Form
    {
        private string connectionString = @"Data Source=DESKTOP-G23CHID;Initial Catalog=EnvanterYonetim;Integrated Security=True";

        public RaporForm()
        {
            InitializeComponent();
        }

        private void RaporForm_Load(object sender, EventArgs e)
        {
            LoadStokRapor();
            LoadSatisRapor();
            LoadMusteriRapor();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void LoadStokRapor()
        {
            string query = "SELECT UrunAd, StokMiktar, BirimFiyat FROM Urun";

            DataTable dataTable = GetData(query);

            ReportDataSource rds = new ReportDataSource("StokDataSet", dataTable);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportPath = "PathToYourStokReport.rdlc";
        }

        private void LoadSatisRapor()
        {
            string query = "SELECT s.SiparisID, m.MusteriAd, s.SiparisTarih, s.ToplamTutar FROM Siparis s JOIN Musteri m ON s.MusteriID = m.MusteriID";

            DataTable dataTable = GetData(query);

            ReportDataSource rds = new ReportDataSource("SatisDataSet", dataTable);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportPath = "PathToYourSatisReport.rdlc"; 
        }

        private void LoadMusteriRapor()
        {
            string query = "SELECT MusteriID, MusteriAd, Iletisim, Adres FROM Musteri";

            DataTable dataTable = GetData(query);

            ReportDataSource rds = new ReportDataSource("MusteriDataSet", dataTable);
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportPath = "PathToYourMusteriReport.rdlc"; 
        }

        private DataTable GetData(string query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }
    }
}
