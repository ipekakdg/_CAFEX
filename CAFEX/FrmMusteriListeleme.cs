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
    public partial class FrmMusteriListeleme : Form
    {
        public FrmMusteriListeleme()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-P0ESQ02;Initial Catalog=CAFEX;Integrated Security=True");

        public void bilgilerigoster(string bilgiler)
        {

            SqlDataAdapter da = new SqlDataAdapter(bilgiler, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void Listele_Click(object sender, EventArgs e)
        {
            bilgilerigoster("SELECT * from CAFEX ");
        }

        private void FrmMusteriListeleme_Load(object sender, EventArgs e)
        {

        }
    }
}
