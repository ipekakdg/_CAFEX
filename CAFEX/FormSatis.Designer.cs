
namespace CAFEX
{
    partial class FormSatis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsatisyap = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Sil = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.txtfiyati = new System.Windows.Forms.TextBox();
            this.txtbarkodno = new System.Windows.Forms.TextBox();
            this.txturuncesidi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbsiparis = new System.Windows.Forms.ComboBox();
            this.ckctamam = new System.Windows.Forms.CheckBox();
            this.siparisekle = new System.Windows.Forms.Button();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnmüsterilisteleme = new System.Windows.Forms.Button();
            this.btnmüsteriekle = new System.Windows.Forms.Button();
            this.btncalısanlistele = new System.Windows.Forms.Button();
            this.btnsatilanlarıgoster = new System.Windows.Forms.Button();
            this.btntunsiparisler = new System.Windows.Forms.Button();
            this.btnUrunler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox2.BackgroundImage = global::CAFEX.Properties.Resources.Piton_logo;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(88, 505);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 39);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CAFEX.Properties.Resources.kişii;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(645, 494);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // btnsatisyap
            // 
            this.btnsatisyap.Location = new System.Drawing.Point(599, 437);
            this.btnsatisyap.Name = "btnsatisyap";
            this.btnsatisyap.Size = new System.Drawing.Size(96, 27);
            this.btnsatisyap.TabIndex = 25;
            this.btnsatisyap.Text = "Satış Yap";
            this.btnsatisyap.UseVisualStyleBackColor = true;
            this.btnsatisyap.Click += new System.EventHandler(this.btnsatisyap_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(280, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(415, 271);
            this.dataGridView1.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox2.Controls.Add(this.Sil);
            this.groupBox2.Controls.Add(this.guncelle);
            this.groupBox2.Controls.Add(this.txtUrunAdi);
            this.groupBox2.Controls.Add(this.txtfiyati);
            this.groupBox2.Controls.Add(this.txtbarkodno);
            this.groupBox2.Controls.Add(this.txturuncesidi);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(44, 269);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 214);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Malzeme Stok";
            // 
            // Sil
            // 
            this.Sil.Location = new System.Drawing.Point(21, 178);
            this.Sil.Name = "Sil";
            this.Sil.Size = new System.Drawing.Size(75, 23);
            this.Sil.TabIndex = 12;
            this.Sil.Text = "Ürünü Sil";
            this.Sil.UseVisualStyleBackColor = true;
            this.Sil.Click += new System.EventHandler(this.Sil_Click);
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(114, 178);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(75, 23);
            this.guncelle.TabIndex = 11;
            this.guncelle.Text = "Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(87, 135);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 20);
            this.txtUrunAdi.TabIndex = 10;
            // 
            // txtfiyati
            // 
            this.txtfiyati.Location = new System.Drawing.Point(87, 96);
            this.txtfiyati.Name = "txtfiyati";
            this.txtfiyati.Size = new System.Drawing.Size(100, 20);
            this.txtfiyati.TabIndex = 9;
            // 
            // txtbarkodno
            // 
            this.txtbarkodno.Location = new System.Drawing.Point(87, 26);
            this.txtbarkodno.Name = "txtbarkodno";
            this.txtbarkodno.Size = new System.Drawing.Size(100, 20);
            this.txtbarkodno.TabIndex = 7;
            // 
            // txturuncesidi
            // 
            this.txturuncesidi.Location = new System.Drawing.Point(87, 59);
            this.txturuncesidi.Name = "txturuncesidi";
            this.txturuncesidi.Size = new System.Drawing.Size(100, 20);
            this.txturuncesidi.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Urun Adı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Fiyatı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ürün Çeşidi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Barkod No:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.cmbsiparis);
            this.groupBox1.Controls.Add(this.ckctamam);
            this.groupBox1.Controls.Add(this.siparisekle);
            this.groupBox1.Controls.Add(this.txtAdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(44, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 136);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SİPARİŞ";
            // 
            // cmbsiparis
            // 
            this.cmbsiparis.FormattingEnabled = true;
            this.cmbsiparis.Location = new System.Drawing.Point(85, 52);
            this.cmbsiparis.Name = "cmbsiparis";
            this.cmbsiparis.Size = new System.Drawing.Size(121, 21);
            this.cmbsiparis.TabIndex = 7;
            // 
            // ckctamam
            // 
            this.ckctamam.AutoSize = true;
            this.ckctamam.Location = new System.Drawing.Point(123, 83);
            this.ckctamam.Name = "ckctamam";
            this.ckctamam.Size = new System.Drawing.Size(83, 17);
            this.ckctamam.TabIndex = 6;
            this.ckctamam.Text = "Tamamlandı";
            this.ckctamam.UseVisualStyleBackColor = true;
            // 
            // siparisekle
            // 
            this.siparisekle.Location = new System.Drawing.Point(21, 106);
            this.siparisekle.Name = "siparisekle";
            this.siparisekle.Size = new System.Drawing.Size(185, 24);
            this.siparisekle.TabIndex = 5;
            this.siparisekle.Text = "Sipariş Ekle";
            this.siparisekle.UseVisualStyleBackColor = true;
            this.siparisekle.Click += new System.EventHandler(this.siparisekle_Click);
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(85, 22);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(121, 20);
            this.txtAdi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Siparişi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Müşteri Adı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(698, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Saat:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnmüsterilisteleme);
            this.panel1.Controls.Add(this.btnmüsteriekle);
            this.panel1.Controls.Add(this.btncalısanlistele);
            this.panel1.Controls.Add(this.btnsatilanlarıgoster);
            this.panel1.Controls.Add(this.btntunsiparisler);
            this.panel1.Controls.Add(this.btnUrunler);
            this.panel1.Location = new System.Drawing.Point(49, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 79);
            this.panel1.TabIndex = 26;
            // 
            // btnmüsterilisteleme
            // 
            this.btnmüsterilisteleme.Location = new System.Drawing.Point(27, 34);
            this.btnmüsterilisteleme.Name = "btnmüsterilisteleme";
            this.btnmüsterilisteleme.Size = new System.Drawing.Size(180, 33);
            this.btnmüsterilisteleme.TabIndex = 10;
            this.btnmüsterilisteleme.Text = "Müşteri Listeleme";
            this.btnmüsterilisteleme.UseVisualStyleBackColor = true;
            this.btnmüsterilisteleme.Click += new System.EventHandler(this.btnmüsterilisteleme_Click);
            // 
            // btnmüsteriekle
            // 
            this.btnmüsteriekle.Location = new System.Drawing.Point(27, 5);
            this.btnmüsteriekle.Name = "btnmüsteriekle";
            this.btnmüsteriekle.Size = new System.Drawing.Size(180, 29);
            this.btnmüsteriekle.TabIndex = 9;
            this.btnmüsteriekle.Text = "Müşteri Ekle";
            this.btnmüsteriekle.UseVisualStyleBackColor = true;
            this.btnmüsteriekle.Click += new System.EventHandler(this.btnmüsteriekle_Click);
            // 
            // btncalısanlistele
            // 
            this.btncalısanlistele.Location = new System.Drawing.Point(430, 34);
            this.btncalısanlistele.Name = "btncalısanlistele";
            this.btncalısanlistele.Size = new System.Drawing.Size(181, 32);
            this.btncalısanlistele.TabIndex = 8;
            this.btncalısanlistele.Text = "Çalışan Listeleme";
            this.btncalısanlistele.UseVisualStyleBackColor = true;
            this.btncalısanlistele.Click += new System.EventHandler(this.btncalısanlistele_Click);
            // 
            // btnsatilanlarıgoster
            // 
            this.btnsatilanlarıgoster.Location = new System.Drawing.Point(430, 5);
            this.btnsatilanlarıgoster.Name = "btnsatilanlarıgoster";
            this.btnsatilanlarıgoster.Size = new System.Drawing.Size(181, 29);
            this.btnsatilanlarıgoster.TabIndex = 7;
            this.btnsatilanlarıgoster.Text = "Ürün Ekleme";
            this.btnsatilanlarıgoster.UseVisualStyleBackColor = true;
            this.btnsatilanlarıgoster.Click += new System.EventHandler(this.btnsatilanlarıgoster_Click);
            // 
            // btntunsiparisler
            // 
            this.btntunsiparisler.Location = new System.Drawing.Point(231, 34);
            this.btntunsiparisler.Name = "btntunsiparisler";
            this.btntunsiparisler.Size = new System.Drawing.Size(177, 34);
            this.btntunsiparisler.TabIndex = 4;
            this.btntunsiparisler.Text = "Tüm Siparişler";
            this.btntunsiparisler.UseVisualStyleBackColor = true;
            this.btntunsiparisler.Click += new System.EventHandler(this.btntunsiparisler_Click);
            // 
            // btnUrunler
            // 
            this.btnUrunler.Location = new System.Drawing.Point(231, 5);
            this.btnUrunler.Name = "btnUrunler";
            this.btnUrunler.Size = new System.Drawing.Size(177, 29);
            this.btnUrunler.TabIndex = 3;
            this.btnUrunler.Text = "Ürünler";
            this.btnUrunler.UseVisualStyleBackColor = true;
            this.btnUrunler.Click += new System.EventHandler(this.btnUrunler_Click);
            // 
            // FormSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CAFEX.Properties.Resources.TURUNCU;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnsatisyap);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FormSatis";
            this.Text = "FormSatis";
            this.Load += new System.EventHandler(this.FormSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnsatisyap;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Sil;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.TextBox txtfiyati;
        private System.Windows.Forms.TextBox txtbarkodno;
        private System.Windows.Forms.TextBox txturuncesidi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbsiparis;
        private System.Windows.Forms.CheckBox ckctamam;
        private System.Windows.Forms.Button siparisekle;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnmüsterilisteleme;
        public System.Windows.Forms.Button btnmüsteriekle;
        public System.Windows.Forms.Button btncalısanlistele;
        public System.Windows.Forms.Button btnsatilanlarıgoster;
        private System.Windows.Forms.Button btntunsiparisler;
        public System.Windows.Forms.Button btnUrunler;
    }
}