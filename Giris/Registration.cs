using EnvanterYönetimSistemi.Giris;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvanterYönetimSistemi
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G23CHID;Initial Catalog=EnvanterYonetim;Integrated Security=True");
        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            String username, password, rol;
            username = txt_usernameRegister.Text;
            password = txt_passwordRegister.Text;
            rol = list_rol.SelectedItem.ToString();

            try
            {
                conn.Open();
                string querryRegister = $"INSERT INTO Kullanici (KullaniciAd, Sifre, Rol) OUTPUT INSERTED.KullaniciID VALUES (@username, @password, @rol)";
                int newKullaniciID;

                using (SqlCommand cmd = new SqlCommand(querryRegister, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@rol", rol);

                    object result = cmd.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        newKullaniciID = (int)result;
                    }
                    else
                    {
                        throw new Exception("KullaniciID döndürülemedi.");
                    }
                }
                if (rol == "Müşteri")
                {
                    using (MusteriBilgiForm musteriBilgileriForm = new MusteriBilgiForm())
                    {
                        if (musteriBilgileriForm.ShowDialog() == DialogResult.OK)
                        {
                            string musteriAd = musteriBilgileriForm.MusteriAd;
                            string iletisim = musteriBilgileriForm.Iletisim;
                            string adres = musteriBilgileriForm.Adres;

                            string setIdentityInsertOn = "SET IDENTITY_INSERT Musteri ON";
                            string setIdentityInsertOff = "SET IDENTITY_INSERT Musteri OFF";

                            string insertMusteri = "INSERT INTO Musteri (MusteriID, MusteriAd, Iletisim, Adres) VALUES  (@musteriID, @musteriAd, @iletisim, @adres);";
                            using (SqlCommand cmd = new SqlCommand(setIdentityInsertOn, conn))
                            {
                                cmd.ExecuteNonQuery();
                            }
                            using (SqlCommand cmd = new SqlCommand(insertMusteri, conn))
                            {
                                cmd.Parameters.AddWithValue("@musteriID", newKullaniciID);
                                cmd.Parameters.AddWithValue("@musteriAd", musteriAd);
                                cmd.Parameters.AddWithValue("@iletisim", iletisim);
                                cmd.Parameters.AddWithValue("@adres", adres);
                                cmd.ExecuteNonQuery();
                            }
                            using (SqlCommand cmd = new SqlCommand(setIdentityInsertOff, conn))
                            {
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Müşteri başarıyla kayıt edildi.");
                            this.Close();
                        }
                        else
                        {
                            string deleteKullanici = $"DELETE FROM Kullanici WHERE KullaniciID = {newKullaniciID}";
                            using (SqlCommand cmd = new SqlCommand(deleteKullanici, conn))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Kullanıcı başarıyla kayıt edildi.");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                conn.Close();

            }
        }
    }
}
