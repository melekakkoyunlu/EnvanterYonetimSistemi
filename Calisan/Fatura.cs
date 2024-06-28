using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvanterYönetimSistemi.Calisan
{
    public partial class Fatura : Form
    {
        int musteriID, siparisID;
        public Fatura(int siparisID)
        {
            InitializeComponent();
            this.siparisID = siparisID;
        }

        private void Fatura_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'envanterYonetimDataSet.Siparis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.siparisTableAdapter.Fill(this.envanterYonetimDataSet.Siparis);
            LoadSiparisDetay();
        }
        private void LoadSiparisDetay()
        {
            try
            {
                string connectionString = @"Data Source=DESKTOP-G23CHID;Initial Catalog=EnvanterYonetim;Integrated Security=True";
                string query = @"
                    SELECT U.UrunAd, SD.Adet, SD.BirimFiyat
                    FROM SiparisDetay SD
                    INNER JOIN Urun U ON SD.UrunID = U.UrunID
                    WHERE SD.SiparisID = @SiparisID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@SiparisID", siparisID);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dgv_fatura.DataSource = dataTable;
                    dgv_fatura.Columns["SiparisID"].Visible = false;

                    decimal totalPrice = 0;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        int adet = Convert.ToInt32(row["Adet"]);
                        decimal birimFiyat = Convert.ToDecimal(row["BirimFiyat"]);
                        totalPrice += adet * birimFiyat;
                    }

                    lbl_toplam.Text = totalPrice.ToString("C", new CultureInfo("tr-TR"));
                }
            }
            catch (Exception ex)
            {
              MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }
    }
}
