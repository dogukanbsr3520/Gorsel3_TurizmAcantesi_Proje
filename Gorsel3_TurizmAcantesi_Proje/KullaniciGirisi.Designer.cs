namespace Gorsel3_TurizmAcantesi_Proje
{
    partial class KullaniciGirisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciGirisi));
            this.tx_kullaniciAd = new System.Windows.Forms.TextBox();
            this.tx_kullaniciSifre = new System.Windows.Forms.TextBox();
            this.btn_giris = new System.Windows.Forms.Button();
            this.chbx_beniHatırla = new System.Windows.Forms.CheckBox();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tx_kullaniciAd
            // 
            this.tx_kullaniciAd.ForeColor = System.Drawing.Color.Gray;
            this.tx_kullaniciAd.Location = new System.Drawing.Point(79, 114);
            this.tx_kullaniciAd.Name = "tx_kullaniciAd";
            this.tx_kullaniciAd.Size = new System.Drawing.Size(100, 20);
            this.tx_kullaniciAd.TabIndex = 0;
            this.tx_kullaniciAd.Text = "kullanıcı Ad giriniz...";
            this.tx_kullaniciAd.Enter += new System.EventHandler(this.tx_kullaniciAd_Enter);
            this.tx_kullaniciAd.Leave += new System.EventHandler(this.tx_kullaniciAd_Leave);
            // 
            // tx_kullaniciSifre
            // 
            this.tx_kullaniciSifre.BackColor = System.Drawing.SystemColors.Window;
            this.tx_kullaniciSifre.ForeColor = System.Drawing.Color.Gray;
            this.tx_kullaniciSifre.Location = new System.Drawing.Point(316, 114);
            this.tx_kullaniciSifre.Name = "tx_kullaniciSifre";
            this.tx_kullaniciSifre.Size = new System.Drawing.Size(100, 20);
            this.tx_kullaniciSifre.TabIndex = 1;
            this.tx_kullaniciSifre.Text = "Şifre giriniz...";
            this.tx_kullaniciSifre.Enter += new System.EventHandler(this.tx_kullaniciSifre_Enter);
            this.tx_kullaniciSifre.Leave += new System.EventHandler(this.tx_kullaniciSifre_Leave);
            // 
            // btn_giris
            // 
            this.btn_giris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_giris.BackgroundImage")));
            this.btn_giris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_giris.Location = new System.Drawing.Point(341, 195);
            this.btn_giris.Name = "btn_giris";
            this.btn_giris.Size = new System.Drawing.Size(75, 45);
            this.btn_giris.TabIndex = 2;
            this.btn_giris.UseVisualStyleBackColor = true;
            this.btn_giris.Click += new System.EventHandler(this.btn_giris_Click);
            // 
            // chbx_beniHatırla
            // 
            this.chbx_beniHatırla.AutoSize = true;
            this.chbx_beniHatırla.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chbx_beniHatırla.Location = new System.Drawing.Point(321, 140);
            this.chbx_beniHatırla.Name = "chbx_beniHatırla";
            this.chbx_beniHatırla.Size = new System.Drawing.Size(80, 17);
            this.chbx_beniHatırla.TabIndex = 3;
            this.chbx_beniHatırla.Text = "Beni Hatırla";
            this.chbx_beniHatırla.UseVisualStyleBackColor = false;
            this.chbx_beniHatırla.CheckedChanged += new System.EventHandler(this.chbx_beniHatırla_CheckedChanged);
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cikis.BackgroundImage")));
            this.btn_cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cikis.Location = new System.Drawing.Point(79, 195);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(75, 45);
            this.btn_cikis.TabIndex = 4;
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "D.O.B.A TRUZİM A.Ş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kullanıcı Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Şifre";
            // 
            // KullaniciGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(498, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.chbx_beniHatırla);
            this.Controls.Add(this.btn_giris);
            this.Controls.Add(this.tx_kullaniciSifre);
            this.Controls.Add(this.tx_kullaniciAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "_ Kullanıcı Girişi _";
            this.Load += new System.EventHandler(this.KullaniciGirisi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_kullaniciAd;
        private System.Windows.Forms.TextBox tx_kullaniciSifre;
        private System.Windows.Forms.Button btn_giris;
        private System.Windows.Forms.CheckBox chbx_beniHatırla;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

