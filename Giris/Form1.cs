using Microsoft.Win32;
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

namespace EnvanterYönetimSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-G23CHID;Initial Catalog=EnvanterYonetim;Integrated Security=True");
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            String username, userPassword;
            username = txt_username.Text;
            userPassword = txt_password.Text;

            try
            {
                String querry = $"SELECT * FROM Kullanici WHERE KullaniciAd = '{username}' AND Sifre ='{userPassword}'";
                SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);

                DataTable dTable = new DataTable();
                adapter.Fill(dTable);

                if (dTable.Rows.Count > 0)
                {
                    username = txt_username.Text;
                    userPassword = txt_password.Text;
                    string rol = dTable.Rows[0]["Rol"].ToString();
                    
                    Form formToOpen;
                    switch (rol)
                    {
                        case "Çalışan":
                            formToOpen = new MenuCalisan();
                            break;
                        case "Müşteri":
                            int musteriID = Convert.ToInt32(dTable.Rows[0]["KullaniciID"]);
                            formToOpen = new MenuMusteri(musteriID);
                            break;
                        default:
                            MessageBox.Show("Bilinmeyen rol.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }

                    formToOpen.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı giriş.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_password.Clear();
                    txt_username.Clear();
                    txt_username.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }

        private void btn_olustur_Click(object sender, EventArgs e)
        {
            Registration register = new Registration();
            register.Show();
        }
    }
}
