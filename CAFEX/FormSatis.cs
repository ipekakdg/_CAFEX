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
    public partial class FormSatis : Form
    {
        public FormSatis()
        {
            InitializeComponent();
        }

        private void FormSatis_Load(object sender, EventArgs e)
        {

        }

        private void btnmüsteriekle_Click(object sender, EventArgs e)
        {
            FrmMusteriEkleme frmMusteri = new FrmMusteriEkleme();
            frmMusteri.ShowDialog();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-P0ESQ02;Initial Catalog=CAFEX;Integrated Security=True");
        private void btnUrunler_Click(object sender, EventArgs e)
        {
            String sorgu = "Select * From  Urun";
            SqlDataAdapter da = new SqlDataAdapter(sorgu, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnsatilanlarıgoster_Click(object sender, EventArgs e)
        {
            UrunEkleme urunekle = new UrunEkleme();
            urunekle.ShowDialog();
        }

        private void btnmüsterilisteleme_Click(object sender, EventArgs e)
        {
            FrmMusteriListeleme MusteriListele = new FrmMusteriListeleme();
            MusteriListele.ShowDialog();
        }

        private void btntunsiparisler_Click(object sender, EventArgs e)
        {
            String sorgu2 = "select * from  Siparis";
            SqlDataAdapter da = new SqlDataAdapter(sorgu2, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btncalısanlistele_Click(object sender, EventArgs e)
        {
            String sorgu3 = "select * from  Personel";
            SqlDataAdapter da = new SqlDataAdapter(sorgu3, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void siparisekle_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut2 = new SqlCommand("Insert into Siparis (MüŞteriAdı, Siparişi,Tamamlandı) values (@p7,@p8,@p9)", conn);
            komut2.Parameters.AddWithValue("@p7", txtAdi.Text);
            komut2.Parameters.AddWithValue("@p8", cmbsiparis.Text);
            komut2.Parameters.AddWithValue("@p9", ckctamam.Text);
            komut2.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Sipariş Eklendi!");
        }

        private void Sil_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut3 = new SqlCommand("Delete From Urun where Adı=@p1, BarkodNo=@p2, Cesidi=@p3, Boyutu=@p4, Fiyatı=@p5", conn);
            komut3.Parameters.AddWithValue("@p1,@p2,@p3,@p4,@5", int.Parse(txtAdi.Text));
            komut3.ExecuteNonQuery();

            conn.Close();
            MessageBox.Show("Ürün Başarı ile Silindi!");
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut4 = new SqlCommand("update From Urun set Adi=@Adi, Cesidi=@Cesidi, BarkodNo=@BarkodNo where Fiyatı=@pFiyatı");
            komut4.Parameters.AddWithValue("@Adi", txtUrunAdi.Text);
            komut4.Parameters.AddWithValue("@BarkodNo", txtbarkodno.Text);
            komut4.Parameters.AddWithValue("@Cesidi", txturuncesidi.Text);
            komut4.Parameters.AddWithValue("@Fiyatı", txtfiyati.Text);
            komut4.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Müşteri Güncelleme İşlemi Başarı ile Gerçekleşti.");
           
        }

        private void btnsatisyap_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand komut5 = new SqlCommand("Insert into Siparis (MüŞteriAdı, Siparişi,Tamamlandı) values (@p7,@p8,@p9)", conn);
            komut5.Parameters.AddWithValue("@p7", txtAdi.Text);
            komut5.Parameters.AddWithValue("@p8", cmbsiparis.Text);
            komut5.Parameters.AddWithValue("@p9", ckctamam.Text);
            komut5.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Satış Tamamlandı.!");
        }
    }
}
