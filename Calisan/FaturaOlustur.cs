using EnvanterYönetimSistemi.EnvanterYonetimDataSetTableAdapters;
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
    public partial class FaturaOlustur : Form
    {
        public FaturaOlustur()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-G23CHID;Initial Catalog=EnvanterYonetim;Integrated Security=True"))
            {
                string query = @"
                    SELECT 
                        s.SiparisID,
                        s.MusteriID,
                        m.MusteriAd,
                        m.Adres,
                        m.Iletisim,
                        s.ToplamTutar,
                        s.SiparisDurum,
                        u.UrunAd,
                        sd.Adet
                    FROM 
                        Siparis s
                    JOIN 
                        Musteri m ON s.MusteriID = m.MusteriID
                    JOIN 
                        SiparisDetay sd ON s.SiparisID = sd.SiparisID
                    JOIN 
                        Urun u ON sd.UrunID = u.UrunID
                    ORDER BY 
                        s.SiparisID;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dgv_fatura.DataSource = dataTable;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MenuCalisan menuCalisan = new MenuCalisan();
            menuCalisan.Show();
            this.Close();
        }

        private void btn_olustur_Click(object sender, EventArgs e)
        {
            Fatura fatura = new Fatura();
            if (dgv_fatura.SelectedRows.Count > 0)
            {   
                try
                {
                    DataGridViewRow selectedRow = dgv_fatura.SelectedRows[0];

                    fatura.SiparisID = selectedRow.Cells["SiparisID"].Value.ToString();
                    fatura.MusteriID = selectedRow.Cells["MusteriID"].Value.ToString();
                    fatura.MusteriAd = selectedRow.Cells["MusteriAd"].Value.ToString();
                    fatura.Adres = selectedRow.Cells["Adres"].Value.ToString();
                    fatura.Iletisim = selectedRow.Cells["Iletisim"].Value.ToString();
                    fatura.ToplamTutar = selectedRow.Cells["ToplamTutar"].Value.ToString();
                    fatura.SiparisDurum = selectedRow.Cells["SiparisDurum"].Value.ToString();
                    fatura.UrunAd = selectedRow.Cells["UrunAd"].Value.ToString();
                    fatura.Adet = selectedRow.Cells["Adet"].Value.ToString();
                    string siparisID = selectedRow.Cells["SiparisID"].Value.ToString();
                    string query = @"
                        SELECT 
                            u.UrunAd, 
                            sd.Adet, 
                            sd.BirimFiyat 
                        FROM 
                            SiparisDetay sd
                        JOIN 
                            Urun u ON sd.UrunID = u.UrunID
                        WHERE 
                             sd.SiparisID = @SiparisID";

                    using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-G23CHID;Initial Catalog=EnvanterYonetim;Integrated Security=True"))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                        adapter.SelectCommand.Parameters.AddWithValue("@SiparisID", siparisID);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        fatura.SiparisDetaylar = dataTable;
                    }

                }
                catch (Exception ex) { MessageBox.Show("Hata:" + ex); }
            }
            fatura.ShowDialog();
        }
    }
}
