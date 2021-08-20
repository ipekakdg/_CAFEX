
namespace CAFEX
{
    partial class İslemSec
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
            this.stokislemleri = new System.Windows.Forms.Button();
            this.satisislemleri = new System.Windows.Forms.Button();
            this.LblUser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // stokislemleri
            // 
            this.stokislemleri.BackColor = System.Drawing.Color.Honeydew;
            this.stokislemleri.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stokislemleri.ForeColor = System.Drawing.Color.MediumBlue;
            this.stokislemleri.Location = new System.Drawing.Point(37, 305);
            this.stokislemleri.Name = "stokislemleri";
            this.stokislemleri.Size = new System.Drawing.Size(141, 58);
            this.stokislemleri.TabIndex = 0;
            this.stokislemleri.Text = "STOK PANELİ";
            this.stokislemleri.UseVisualStyleBackColor = false;
            this.stokislemleri.Click += new System.EventHandler(this.stokislemleri_Click);
            // 
            // satisislemleri
            // 
            this.satisislemleri.BackColor = System.Drawing.Color.Honeydew;
            this.satisislemleri.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satisislemleri.ForeColor = System.Drawing.Color.OrangeRed;
            this.satisislemleri.Location = new System.Drawing.Point(572, 305);
            this.satisislemleri.Name = "satisislemleri";
            this.satisislemleri.Size = new System.Drawing.Size(141, 58);
            this.satisislemleri.TabIndex = 1;
            this.satisislemleri.Text = "SATIŞ PANELİ";
            this.satisislemleri.UseVisualStyleBackColor = false;
            this.satisislemleri.Click += new System.EventHandler(this.satisislemleri_Click);
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.LblUser.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblUser.Image = global::CAFEX.Properties.Resources.islemsec1;
            this.LblUser.Location = new System.Drawing.Point(267, 216);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(234, 24);
            this.LblUser.TabIndex = 2;
            this.LblUser.Text = "Lütfen bir seçim yapınız!";
            // 
            // İslemSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::CAFEX.Properties.Resources.islemsec1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(747, 406);
            this.Controls.Add(this.LblUser);
            this.Controls.Add(this.satisislemleri);
            this.Controls.Add(this.stokislemleri);
            this.Name = "İslemSec";
            this.Text = "Ne yapmak istersiniz?";
            this.Load += new System.EventHandler(this.İslemSec_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button stokislemleri;
        private System.Windows.Forms.Button satisislemleri;
        private System.Windows.Forms.Label LblUser;
    }
}