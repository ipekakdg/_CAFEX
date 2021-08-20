
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




namespace CAFEX
{
    public partial class FormLogin : Form
    {
        SqlConnection conn;
        SqlDataReader dr;
        SqlCommand com;
        public FormLogin()
        {
            InitializeComponent();
        }

        

        private void Btngiris_Click(object sender, EventArgs e)
        {
            string KullaniciAdi = txtAd.Text;
            string Parola = txtSifre.Text;

            conn = new SqlConnection("Data Source=DESKTOP-P0ESQ02;Initial Catalog=CAFEX;Integrated Security=True");
            com = new SqlCommand();
            conn.Open();
            com.Connection = conn;
            com.CommandText = "Select * From  Personel Where KullaniciAdi = '" + txtAd.Text + "' AND Parola = '" + txtSifre.Text + '"';
            dr = com.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı!");
                İslemSec İslemSecc = new İslemSec();
                İslemSecc.Show();
                this.Hide();
                

            }
            else {


                MessageBox.Show("Lütfen Kullanıcı Adı veye Şifrenizi kontrol ediniz!!");

                
            }
            conn.Close();

        }

        private void Btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
