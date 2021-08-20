using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAFEX
{
    public partial class İslemSec : Form
    {
        public İslemSec(string username)
        {
            InitializeComponent();
            this.username = username;
        }

        public İslemSec()
        {
        }

        private void satisislemleri_Click(object sender, EventArgs e)
        {
            FormSatis frmsatis = new FormSatis();
            frmsatis.ShowDialog();
        }

        private void stokislemleri_Click(object sender, EventArgs e)
        {
            UrunEkleme urunekle = new UrunEkleme();
            urunekle.ShowDialog();
        }


        private string username;
        private void İslemSec_Load(object sender, EventArgs e)
        {

            LblUser.Text = LblUser.Text + username;
        }

        private void İslemSec_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
