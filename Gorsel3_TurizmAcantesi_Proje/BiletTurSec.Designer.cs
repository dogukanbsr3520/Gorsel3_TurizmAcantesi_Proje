namespace Gorsel3_TurizmAcantesi_Proje
{
    partial class BiletTurSec
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiletTurSec));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tx_biletTurNo = new System.Windows.Forms.TextBox();
            this.tx_biletTurAd = new System.Windows.Forms.TextBox();
            this.dgv_biletTurKayitlari = new System.Windows.Forms.DataGridView();
            this.btn_biletTurEkle = new System.Windows.Forms.Button();
            this.btn_türSil = new System.Windows.Forms.Button();
            this.btn_biletTurGuncelle = new System.Windows.Forms.Button();
            this.btn_BTSCikis = new System.Windows.Forms.Button();
            this.btn_biletSatisSayfaDon = new System.Windows.Forms.Button();
            this.cms_biletTurForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.biletTurEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydiGuncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletSatişSayfasinaGecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sayfayiKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_biletTurKayitlari)).BeginInit();
            this.cms_biletTurForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bilet Tür No : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tur Ad : ";
            // 
            // tx_biletTurNo
            // 
            this.tx_biletTurNo.Location = new System.Drawing.Point(276, 231);
            this.tx_biletTurNo.Name = "tx_biletTurNo";
            this.tx_biletTurNo.Size = new System.Drawing.Size(100, 20);
            this.tx_biletTurNo.TabIndex = 2;
            // 
            // tx_biletTurAd
            // 
            this.tx_biletTurAd.Location = new System.Drawing.Point(276, 273);
            this.tx_biletTurAd.Name = "tx_biletTurAd";
            this.tx_biletTurAd.Size = new System.Drawing.Size(100, 20);
            this.tx_biletTurAd.TabIndex = 3;
            // 
            // dgv_biletTurKayitlari
            // 
            this.dgv_biletTurKayitlari.AllowUserToAddRows = false;
            this.dgv_biletTurKayitlari.AllowUserToDeleteRows = false;
            this.dgv_biletTurKayitlari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_biletTurKayitlari.Location = new System.Drawing.Point(12, 72);
            this.dgv_biletTurKayitlari.Name = "dgv_biletTurKayitlari";
            this.dgv_biletTurKayitlari.ReadOnly = true;
            this.dgv_biletTurKayitlari.Size = new System.Drawing.Size(342, 150);
            this.dgv_biletTurKayitlari.TabIndex = 4;
            this.dgv_biletTurKayitlari.SelectionChanged += new System.EventHandler(this.dgv_biletTurKayitlari_SelectionChanged);
            // 
            // btn_biletTurEkle
            // 
            this.btn_biletTurEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_biletTurEkle.BackgroundImage")));
            this.btn_biletTurEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_biletTurEkle.Location = new System.Drawing.Point(464, 163);
            this.btn_biletTurEkle.Name = "btn_biletTurEkle";
            this.btn_biletTurEkle.Size = new System.Drawing.Size(106, 59);
            this.btn_biletTurEkle.TabIndex = 15;
            this.btn_biletTurEkle.UseVisualStyleBackColor = true;
            this.btn_biletTurEkle.Click += new System.EventHandler(this.btn_biletTurEkle_Click);
            // 
            // btn_türSil
            // 
            this.btn_türSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_türSil.BackgroundImage")));
            this.btn_türSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_türSil.Location = new System.Drawing.Point(464, 293);
            this.btn_türSil.Name = "btn_türSil";
            this.btn_türSil.Size = new System.Drawing.Size(106, 61);
            this.btn_türSil.TabIndex = 14;
            this.btn_türSil.UseVisualStyleBackColor = true;
            this.btn_türSil.Click += new System.EventHandler(this.btn_türSil_Click);
            // 
            // btn_biletTurGuncelle
            // 
            this.btn_biletTurGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_biletTurGuncelle.BackgroundImage")));
            this.btn_biletTurGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_biletTurGuncelle.Location = new System.Drawing.Point(464, 231);
            this.btn_biletTurGuncelle.Name = "btn_biletTurGuncelle";
            this.btn_biletTurGuncelle.Size = new System.Drawing.Size(106, 56);
            this.btn_biletTurGuncelle.TabIndex = 13;
            this.btn_biletTurGuncelle.UseVisualStyleBackColor = true;
            this.btn_biletTurGuncelle.Click += new System.EventHandler(this.btn_biletTurGuncelle_Click);
            // 
            // btn_BTSCikis
            // 
            this.btn_BTSCikis.Location = new System.Drawing.Point(593, 2);
            this.btn_BTSCikis.Name = "btn_BTSCikis";
            this.btn_BTSCikis.Size = new System.Drawing.Size(27, 23);
            this.btn_BTSCikis.TabIndex = 16;
            this.btn_BTSCikis.Text = " X";
            this.btn_BTSCikis.UseVisualStyleBackColor = true;
            this.btn_BTSCikis.Click += new System.EventHandler(this.btn_BTSCikis_Click);
            // 
            // btn_biletSatisSayfaDon
            // 
            this.btn_biletSatisSayfaDon.Location = new System.Drawing.Point(455, 2);
            this.btn_biletSatisSayfaDon.Name = "btn_biletSatisSayfaDon";
            this.btn_biletSatisSayfaDon.Size = new System.Drawing.Size(138, 23);
            this.btn_biletSatisSayfaDon.TabIndex = 18;
            this.btn_biletSatisSayfaDon.Text = "Bilet Satış Sayfasına Dön";
            this.btn_biletSatisSayfaDon.UseVisualStyleBackColor = true;
            this.btn_biletSatisSayfaDon.Click += new System.EventHandler(this.btn_biletSatisSayfaDon_Click);
            // 
            // cms_biletTurForm
            // 
            this.cms_biletTurForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biletTurEkleToolStripMenuItem,
            this.kaydiGuncelleToolStripMenuItem,
            this.kaydiSilToolStripMenuItem,
            this.biletSatişSayfasinaGecToolStripMenuItem,
            this.sayfayiKapatToolStripMenuItem});
            this.cms_biletTurForm.Name = "cms_biletTurForm";
            this.cms_biletTurForm.Size = new System.Drawing.Size(200, 114);
            // 
            // biletTurEkleToolStripMenuItem
            // 
            this.biletTurEkleToolStripMenuItem.Name = "biletTurEkleToolStripMenuItem";
            this.biletTurEkleToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.biletTurEkleToolStripMenuItem.Text = "Bilet Tür Ekle";
            this.biletTurEkleToolStripMenuItem.Click += new System.EventHandler(this.btn_biletTurEkle_Click);
            // 
            // kaydiGuncelleToolStripMenuItem
            // 
            this.kaydiGuncelleToolStripMenuItem.Name = "kaydiGuncelleToolStripMenuItem";
            this.kaydiGuncelleToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.kaydiGuncelleToolStripMenuItem.Text = "Kaydı Güncelle";
            this.kaydiGuncelleToolStripMenuItem.Click += new System.EventHandler(this.btn_biletTurGuncelle_Click);
            // 
            // kaydiSilToolStripMenuItem
            // 
            this.kaydiSilToolStripMenuItem.Name = "kaydiSilToolStripMenuItem";
            this.kaydiSilToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.kaydiSilToolStripMenuItem.Text = "Kaydı Sil";
            this.kaydiSilToolStripMenuItem.Click += new System.EventHandler(this.btn_türSil_Click);
            // 
            // biletSatişSayfasinaGecToolStripMenuItem
            // 
            this.biletSatişSayfasinaGecToolStripMenuItem.Name = "biletSatişSayfasinaGecToolStripMenuItem";
            this.biletSatişSayfasinaGecToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.biletSatişSayfasinaGecToolStripMenuItem.Text = "Bilet Satış Sayfasına Geç";
            this.biletSatişSayfasinaGecToolStripMenuItem.Click += new System.EventHandler(this.btn_biletSatisSayfaDon_Click);
            // 
            // sayfayiKapatToolStripMenuItem
            // 
            this.sayfayiKapatToolStripMenuItem.Name = "sayfayiKapatToolStripMenuItem";
            this.sayfayiKapatToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.sayfayiKapatToolStripMenuItem.Text = "Sayfayı Kapat";
            this.sayfayiKapatToolStripMenuItem.Click += new System.EventHandler(this.btn_BTSCikis_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(12, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(234, 25);
            this.label11.TabIndex = 36;
            this.label11.Text = "Bilet Tür Kayıt İşlemleri";
            // 
            // BiletTurSec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(622, 365);
            this.ContextMenuStrip = this.cms_biletTurForm;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_biletSatisSayfaDon);
            this.Controls.Add(this.btn_BTSCikis);
            this.Controls.Add(this.btn_biletTurEkle);
            this.Controls.Add(this.btn_türSil);
            this.Controls.Add(this.btn_biletTurGuncelle);
            this.Controls.Add(this.dgv_biletTurKayitlari);
            this.Controls.Add(this.tx_biletTurAd);
            this.Controls.Add(this.tx_biletTurNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "BiletTurSec";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BiletTurSec";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BiletTurSec_FormClosing);
            this.Load += new System.EventHandler(this.BiletTurSec_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BiletTurSec_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_biletTurKayitlari)).EndInit();
            this.cms_biletTurForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tx_biletTurNo;
        private System.Windows.Forms.TextBox tx_biletTurAd;
        private System.Windows.Forms.DataGridView dgv_biletTurKayitlari;
        private System.Windows.Forms.Button btn_biletTurEkle;
        private System.Windows.Forms.Button btn_türSil;
        private System.Windows.Forms.Button btn_biletTurGuncelle;
        private System.Windows.Forms.Button btn_BTSCikis;
        private System.Windows.Forms.Button btn_biletSatisSayfaDon;
        private System.Windows.Forms.ContextMenuStrip cms_biletTurForm;
        private System.Windows.Forms.ToolStripMenuItem biletTurEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydiGuncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydiSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biletSatişSayfasinaGecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sayfayiKapatToolStripMenuItem;
        private System.Windows.Forms.Label label11;
    }
}