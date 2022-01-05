namespace Gorsel3_TurizmAcantesi_Proje
{
    partial class RezervasyonIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RezervasyonIslemleri));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_rezervasyonAdGirdi = new System.Windows.Forms.TextBox();
            this.dtp_rezervasyonBaslangicTarih = new System.Windows.Forms.DateTimePicker();
            this.dtp_rezervasyonBitisTarih = new System.Windows.Forms.DateTimePicker();
            this.cbx_turAdiSec = new System.Windows.Forms.ComboBox();
            this.dgv_rezervasyonKayitlari = new System.Windows.Forms.DataGridView();
            this.btn_rezervasyonEkle = new System.Windows.Forms.Button();
            this.btn_rezervasyonGüncelle = new System.Windows.Forms.Button();
            this.btn_rezervasyonSil = new System.Windows.Forms.Button();
            this.btn_rezervasyonKayidAlanTemizle = new System.Windows.Forms.Button();
            this.btn_RCikis = new System.Windows.Forms.Button();
            this.btn_musteriSayfaDon = new System.Windows.Forms.Button();
            this.cms_RezervasyonForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.rezervasyonKaydiOlusturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervasyonKaydiGuncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervasyonKaydiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriSayfasinaGecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sayfayiKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rezervasyonKayitlari)).BeginInit();
            this.cms_RezervasyonForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rezervasyon Adı\'nı Giriniz : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Başlangıç Tarihi : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bitiş Tarihi : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tur Adını Seçiniz : ";
            // 
            // tx_rezervasyonAdGirdi
            // 
            this.tx_rezervasyonAdGirdi.Location = new System.Drawing.Point(178, 117);
            this.tx_rezervasyonAdGirdi.Name = "tx_rezervasyonAdGirdi";
            this.tx_rezervasyonAdGirdi.Size = new System.Drawing.Size(100, 20);
            this.tx_rezervasyonAdGirdi.TabIndex = 4;
            // 
            // dtp_rezervasyonBaslangicTarih
            // 
            this.dtp_rezervasyonBaslangicTarih.CustomFormat = "yyyy-MM-dd";
            this.dtp_rezervasyonBaslangicTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_rezervasyonBaslangicTarih.Location = new System.Drawing.Point(176, 180);
            this.dtp_rezervasyonBaslangicTarih.Name = "dtp_rezervasyonBaslangicTarih";
            this.dtp_rezervasyonBaslangicTarih.Size = new System.Drawing.Size(102, 20);
            this.dtp_rezervasyonBaslangicTarih.TabIndex = 5;
            // 
            // dtp_rezervasyonBitisTarih
            // 
            this.dtp_rezervasyonBitisTarih.CustomFormat = "yyyy-MM-dd";
            this.dtp_rezervasyonBitisTarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_rezervasyonBitisTarih.Location = new System.Drawing.Point(176, 243);
            this.dtp_rezervasyonBitisTarih.Name = "dtp_rezervasyonBitisTarih";
            this.dtp_rezervasyonBitisTarih.Size = new System.Drawing.Size(102, 20);
            this.dtp_rezervasyonBitisTarih.TabIndex = 6;
            // 
            // cbx_turAdiSec
            // 
            this.cbx_turAdiSec.FormattingEnabled = true;
            this.cbx_turAdiSec.Location = new System.Drawing.Point(157, 300);
            this.cbx_turAdiSec.Name = "cbx_turAdiSec";
            this.cbx_turAdiSec.Size = new System.Drawing.Size(121, 21);
            this.cbx_turAdiSec.TabIndex = 7;
            // 
            // dgv_rezervasyonKayitlari
            // 
            this.dgv_rezervasyonKayitlari.AllowUserToAddRows = false;
            this.dgv_rezervasyonKayitlari.AllowUserToDeleteRows = false;
            this.dgv_rezervasyonKayitlari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rezervasyonKayitlari.Location = new System.Drawing.Point(296, 123);
            this.dgv_rezervasyonKayitlari.Name = "dgv_rezervasyonKayitlari";
            this.dgv_rezervasyonKayitlari.ReadOnly = true;
            this.dgv_rezervasyonKayitlari.Size = new System.Drawing.Size(443, 173);
            this.dgv_rezervasyonKayitlari.TabIndex = 8;
            this.dgv_rezervasyonKayitlari.SelectionChanged += new System.EventHandler(this.dgv_rezervasyonKayitlari_SelectionChanged);
            // 
            // btn_rezervasyonEkle
            // 
            this.btn_rezervasyonEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_rezervasyonEkle.BackgroundImage")));
            this.btn_rezervasyonEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rezervasyonEkle.Location = new System.Drawing.Point(764, 209);
            this.btn_rezervasyonEkle.Name = "btn_rezervasyonEkle";
            this.btn_rezervasyonEkle.Size = new System.Drawing.Size(83, 43);
            this.btn_rezervasyonEkle.TabIndex = 9;
            this.btn_rezervasyonEkle.UseVisualStyleBackColor = true;
            this.btn_rezervasyonEkle.Click += new System.EventHandler(this.btn_rezervasyonEkle_Click);
            // 
            // btn_rezervasyonGüncelle
            // 
            this.btn_rezervasyonGüncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_rezervasyonGüncelle.BackgroundImage")));
            this.btn_rezervasyonGüncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rezervasyonGüncelle.Location = new System.Drawing.Point(764, 263);
            this.btn_rezervasyonGüncelle.Name = "btn_rezervasyonGüncelle";
            this.btn_rezervasyonGüncelle.Size = new System.Drawing.Size(82, 43);
            this.btn_rezervasyonGüncelle.TabIndex = 10;
            this.btn_rezervasyonGüncelle.UseVisualStyleBackColor = true;
            this.btn_rezervasyonGüncelle.Click += new System.EventHandler(this.btn_rezervasyonGüncelle_Click);
            // 
            // btn_rezervasyonSil
            // 
            this.btn_rezervasyonSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_rezervasyonSil.BackgroundImage")));
            this.btn_rezervasyonSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rezervasyonSil.Location = new System.Drawing.Point(764, 311);
            this.btn_rezervasyonSil.Name = "btn_rezervasyonSil";
            this.btn_rezervasyonSil.Size = new System.Drawing.Size(85, 43);
            this.btn_rezervasyonSil.TabIndex = 11;
            this.btn_rezervasyonSil.UseVisualStyleBackColor = true;
            this.btn_rezervasyonSil.Click += new System.EventHandler(this.btn_rezervasyonSil_Click);
            // 
            // btn_rezervasyonKayidAlanTemizle
            // 
            this.btn_rezervasyonKayidAlanTemizle.Location = new System.Drawing.Point(284, 298);
            this.btn_rezervasyonKayidAlanTemizle.Name = "btn_rezervasyonKayidAlanTemizle";
            this.btn_rezervasyonKayidAlanTemizle.Size = new System.Drawing.Size(128, 25);
            this.btn_rezervasyonKayidAlanTemizle.TabIndex = 33;
            this.btn_rezervasyonKayidAlanTemizle.Text = "Kayıd Alanlarını Temizle";
            this.btn_rezervasyonKayidAlanTemizle.UseVisualStyleBackColor = true;
            this.btn_rezervasyonKayidAlanTemizle.Click += new System.EventHandler(this.btn_rezervasyonKayidAlanTemizle_Click);
            // 
            // btn_RCikis
            // 
            this.btn_RCikis.Location = new System.Drawing.Point(845, 2);
            this.btn_RCikis.Name = "btn_RCikis";
            this.btn_RCikis.Size = new System.Drawing.Size(27, 23);
            this.btn_RCikis.TabIndex = 34;
            this.btn_RCikis.Text = " X";
            this.btn_RCikis.UseVisualStyleBackColor = true;
            this.btn_RCikis.Click += new System.EventHandler(this.btn_RCikis_Click);
            // 
            // btn_musteriSayfaDon
            // 
            this.btn_musteriSayfaDon.Location = new System.Drawing.Point(719, 2);
            this.btn_musteriSayfaDon.Name = "btn_musteriSayfaDon";
            this.btn_musteriSayfaDon.Size = new System.Drawing.Size(124, 23);
            this.btn_musteriSayfaDon.TabIndex = 35;
            this.btn_musteriSayfaDon.Text = "Müşteri Sayfasına Dön";
            this.btn_musteriSayfaDon.UseVisualStyleBackColor = true;
            this.btn_musteriSayfaDon.Click += new System.EventHandler(this.btn_musteriSayfaDon_Click);
            // 
            // cms_RezervasyonForm
            // 
            this.cms_RezervasyonForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezervasyonKaydiOlusturToolStripMenuItem,
            this.rezervasyonKaydiGuncelleToolStripMenuItem,
            this.rezervasyonKaydiSilToolStripMenuItem,
            this.musteriSayfasinaGecToolStripMenuItem,
            this.sayfayiKapatToolStripMenuItem});
            this.cms_RezervasyonForm.Name = "cms_RezervasyonForm";
            this.cms_RezervasyonForm.Size = new System.Drawing.Size(221, 114);
            // 
            // rezervasyonKaydiOlusturToolStripMenuItem
            // 
            this.rezervasyonKaydiOlusturToolStripMenuItem.Name = "rezervasyonKaydiOlusturToolStripMenuItem";
            this.rezervasyonKaydiOlusturToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.rezervasyonKaydiOlusturToolStripMenuItem.Text = "Rezervasyon Kaydı Oluştur";
            this.rezervasyonKaydiOlusturToolStripMenuItem.Click += new System.EventHandler(this.btn_rezervasyonEkle_Click);
            // 
            // rezervasyonKaydiGuncelleToolStripMenuItem
            // 
            this.rezervasyonKaydiGuncelleToolStripMenuItem.Name = "rezervasyonKaydiGuncelleToolStripMenuItem";
            this.rezervasyonKaydiGuncelleToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.rezervasyonKaydiGuncelleToolStripMenuItem.Text = "Rezervasyon Kaydı Güncelle";
            this.rezervasyonKaydiGuncelleToolStripMenuItem.Click += new System.EventHandler(this.btn_rezervasyonGüncelle_Click);
            // 
            // rezervasyonKaydiSilToolStripMenuItem
            // 
            this.rezervasyonKaydiSilToolStripMenuItem.Name = "rezervasyonKaydiSilToolStripMenuItem";
            this.rezervasyonKaydiSilToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.rezervasyonKaydiSilToolStripMenuItem.Text = "Rezervasyon Kaydı Sil";
            this.rezervasyonKaydiSilToolStripMenuItem.Click += new System.EventHandler(this.btn_rezervasyonSil_Click);
            // 
            // musteriSayfasinaGecToolStripMenuItem
            // 
            this.musteriSayfasinaGecToolStripMenuItem.Name = "musteriSayfasinaGecToolStripMenuItem";
            this.musteriSayfasinaGecToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.musteriSayfasinaGecToolStripMenuItem.Text = "Müşteri Sayfasına Geç";
            this.musteriSayfasinaGecToolStripMenuItem.Click += new System.EventHandler(this.btn_musteriSayfaDon_Click);
            // 
            // sayfayiKapatToolStripMenuItem
            // 
            this.sayfayiKapatToolStripMenuItem.Name = "sayfayiKapatToolStripMenuItem";
            this.sayfayiKapatToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.sayfayiKapatToolStripMenuItem.Text = "Sayfayı Kapat";
            this.sayfayiKapatToolStripMenuItem.Click += new System.EventHandler(this.btn_RCikis_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(12, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(223, 25);
            this.label11.TabIndex = 37;
            this.label11.Text = "Rezervasyon İşlemleri";
            // 
            // RezervasyonIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 425);
            this.ContextMenuStrip = this.cms_RezervasyonForm;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_musteriSayfaDon);
            this.Controls.Add(this.btn_RCikis);
            this.Controls.Add(this.btn_rezervasyonKayidAlanTemizle);
            this.Controls.Add(this.btn_rezervasyonSil);
            this.Controls.Add(this.btn_rezervasyonGüncelle);
            this.Controls.Add(this.btn_rezervasyonEkle);
            this.Controls.Add(this.dgv_rezervasyonKayitlari);
            this.Controls.Add(this.cbx_turAdiSec);
            this.Controls.Add(this.dtp_rezervasyonBitisTarih);
            this.Controls.Add(this.dtp_rezervasyonBaslangicTarih);
            this.Controls.Add(this.tx_rezervasyonAdGirdi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "RezervasyonIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RezervasyonIslemleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RezervasyonIslemleri_FormClosing);
            this.Load += new System.EventHandler(this.RezervasyonIslemleri_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RezervasyonIslemleri_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rezervasyonKayitlari)).EndInit();
            this.cms_RezervasyonForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_rezervasyonAdGirdi;
        private System.Windows.Forms.DateTimePicker dtp_rezervasyonBaslangicTarih;
        private System.Windows.Forms.DateTimePicker dtp_rezervasyonBitisTarih;
        private System.Windows.Forms.ComboBox cbx_turAdiSec;
        private System.Windows.Forms.DataGridView dgv_rezervasyonKayitlari;
        private System.Windows.Forms.Button btn_rezervasyonEkle;
        private System.Windows.Forms.Button btn_rezervasyonGüncelle;
        private System.Windows.Forms.Button btn_rezervasyonSil;
        private System.Windows.Forms.Button btn_rezervasyonKayidAlanTemizle;
        private System.Windows.Forms.Button btn_RCikis;
        private System.Windows.Forms.Button btn_musteriSayfaDon;
        private System.Windows.Forms.ContextMenuStrip cms_RezervasyonForm;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonKaydiOlusturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonKaydiGuncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonKaydiSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musteriSayfasinaGecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sayfayiKapatToolStripMenuItem;
        private System.Windows.Forms.Label label11;
    }
}