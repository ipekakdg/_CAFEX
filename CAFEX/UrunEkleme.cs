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
    public partial class UrunEkleme : Form
    {
        public UrunEkleme()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-P0ESQ02;Initial Catalog=CAFEX;Integrated Security=True");
        private void btnsicak_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut1 = new SqlCommand("insert into UrunEkle(UrunAdı,UrunAdedi) values (@p1,@p2) conn ");
            komut1.Parameters.AddWithValue("@p1", int.Parse(txtsicak.Text));
            komut1.Parameters.AddWithValue("@p2", numericsicak.Text);
            komut1.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sıcak Ürün Ekleme İşlemi Başarı ile gerçekleşti.");
        }

        private void btnsoguk_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut2 = new SqlCommand("insert into UrunEkle(UrunAdı,UrunAdedi) values (@p3,@p4) conn ");
            komut2.Parameters.AddWithValue("@p3", int.Parse(txtsoguk.Text));
            komut2.Parameters.AddWithValue("@p4", numericsoguk.Text);
            komut2.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Soğuk Ürün Ekleme İşlemi Başarı ile gerçekleşti.");
        }

        private void btntatli_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut3 = new SqlCommand("insert into UrunEkle(UrunAdı,UrunAdedi) values (@p5,@p6) conn ");
            komut3.Parameters.AddWithValue("@p5", int.Parse(txttatli.Text));
            komut3.Parameters.AddWithValue("@p6", numerictatli.Text);
            komut3.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Tatlı Ürün Ekleme İşlemi Başarı ile gerçekleşti.");
        }
    }
    
}
