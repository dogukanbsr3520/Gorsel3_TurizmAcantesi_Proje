namespace Gorsel3_TurizmAcantesi_Proje
{
    partial class TurPaketleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TurPaketleri));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_paketAdOlustur = new System.Windows.Forms.TextBox();
            this.dtp_gecerlilikSuresi = new System.Windows.Forms.DateTimePicker();
            this.cbx_hizmetTurSecimi = new System.Windows.Forms.ComboBox();
            this.cbx_konaklamaTurSecimi = new System.Windows.Forms.ComboBox();
            this.dgv_turPaketKayitlari = new System.Windows.Forms.DataGridView();
            this.btn_turPaketEkle = new System.Windows.Forms.Button();
            this.btn_turPaketGuncelle = new System.Windows.Forms.Button();
            this.btn_turPaketSil = new System.Windows.Forms.Button();
            this.btn_TPCikis = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_turTurSayfasinaGec = new System.Windows.Forms.Button();
            this.cms_TurPaketForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.turPaketKaydiOlusturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paketKaydiGuncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paketKaydiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turTurSayfasinaGecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sayfayiKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turPaketKayitlari)).BeginInit();
            this.cms_TurPaketForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tur\'a Ait Paket Adını Oluşturunuz : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paket Geçerlilik Süresi : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hizmet Türünü Seçiniz : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Konaklama Türünü Seçiniz : ";
            // 
            // tx_paketAdOlustur
            // 
            this.tx_paketAdOlustur.Location = new System.Drawing.Point(175, 187);
            this.tx_paketAdOlustur.Name = "tx_paketAdOlustur";
            this.tx_paketAdOlustur.Size = new System.Drawing.Size(100, 20);
            this.tx_paketAdOlustur.TabIndex = 4;
            // 
            // dtp_gecerlilikSuresi
            // 
            this.dtp_gecerlilikSuresi.CustomFormat = "yyyy-MM-dd";
            this.dtp_gecerlilikSuresi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_gecerlilikSuresi.Location = new System.Drawing.Point(175, 220);
            this.dtp_gecerlilikSuresi.Name = "dtp_gecerlilikSuresi";
            this.dtp_gecerlilikSuresi.Size = new System.Drawing.Size(100, 20);
            this.dtp_gecerlilikSuresi.TabIndex = 5;
            // 
            // cbx_hizmetTurSecimi
            // 
            this.cbx_hizmetTurSecimi.FormattingEnabled = true;
            this.cbx_hizmetTurSecimi.Location = new System.Drawing.Point(397, 186);
            this.cbx_hizmetTurSecimi.Name = "cbx_hizmetTurSecimi";
            this.cbx_hizmetTurSecimi.Size = new System.Drawing.Size(121, 21);
            this.cbx_hizmetTurSecimi.TabIndex = 6;
            // 
            // cbx_konaklamaTurSecimi
            // 
            this.cbx_konaklamaTurSecimi.FormattingEnabled = true;
            this.cbx_konaklamaTurSecimi.Location = new System.Drawing.Point(662, 186);
            this.cbx_konaklamaTurSecimi.Name = "cbx_konaklamaTurSecimi";
            this.cbx_konaklamaTurSecimi.Size = new System.Drawing.Size(121, 21);
            this.cbx_konaklamaTurSecimi.TabIndex = 7;
            // 
            // dgv_turPaketKayitlari
            // 
            this.dgv_turPaketKayitlari.AllowUserToAddRows = false;
            this.dgv_turPaketKayitlari.AllowUserToDeleteRows = false;
            this.dgv_turPaketKayitlari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_turPaketKayitlari.Location = new System.Drawing.Point(466, 33);
            this.dgv_turPaketKayitlari.Name = "dgv_turPaketKayitlari";
            this.dgv_turPaketKayitlari.ReadOnly = true;
            this.dgv_turPaketKayitlari.Size = new System.Drawing.Size(435, 150);
            this.dgv_turPaketKayitlari.TabIndex = 8;
            // 
            // btn_turPaketEkle
            // 
            this.btn_turPaketEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_turPaketEkle.BackgroundImage")));
            this.btn_turPaketEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_turPaketEkle.Location = new System.Drawing.Point(788, 189);
            this.btn_turPaketEkle.Name = "btn_turPaketEkle";
            this.btn_turPaketEkle.Size = new System.Drawing.Size(113, 50);
            this.btn_turPaketEkle.TabIndex = 9;
            this.btn_turPaketEkle.UseVisualStyleBackColor = true;
            this.btn_turPaketEkle.Click += new System.EventHandler(this.btn_turPaketEkle_Click);
            // 
            // btn_turPaketGuncelle
            // 
            this.btn_turPaketGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_turPaketGuncelle.BackgroundImage")));
            this.btn_turPaketGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_turPaketGuncelle.Location = new System.Drawing.Point(792, 249);
            this.btn_turPaketGuncelle.Name = "btn_turPaketGuncelle";
            this.btn_turPaketGuncelle.Size = new System.Drawing.Size(109, 51);
            this.btn_turPaketGuncelle.TabIndex = 10;
            this.btn_turPaketGuncelle.UseVisualStyleBackColor = true;
            this.btn_turPaketGuncelle.Click += new System.EventHandler(this.btn_turPaketGuncelle_Click);
            // 
            // btn_turPaketSil
            // 
            this.btn_turPaketSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_turPaketSil.BackgroundImage")));
            this.btn_turPaketSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_turPaketSil.Location = new System.Drawing.Point(792, 320);
            this.btn_turPaketSil.Name = "btn_turPaketSil";
            this.btn_turPaketSil.Size = new System.Drawing.Size(106, 47);
            this.btn_turPaketSil.TabIndex = 11;
            this.btn_turPaketSil.UseVisualStyleBackColor = true;
            this.btn_turPaketSil.Click += new System.EventHandler(this.btn_turPaketSil_Click);
            // 
            // btn_TPCikis
            // 
            this.btn_TPCikis.Location = new System.Drawing.Point(878, 1);
            this.btn_TPCikis.Name = "btn_TPCikis";
            this.btn_TPCikis.Size = new System.Drawing.Size(27, 23);
            this.btn_TPCikis.TabIndex = 12;
            this.btn_TPCikis.Text = " X";
            this.btn_TPCikis.UseVisualStyleBackColor = true;
            this.btn_TPCikis.Click += new System.EventHandler(this.btn_TPCikis_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(10, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(244, 25);
            this.label11.TabIndex = 35;
            this.label11.Text = "Tur Paketi Kayıt Sayfası";
            // 
            // btn_turTurSayfasinaGec
            // 
            this.btn_turTurSayfasinaGec.Location = new System.Drawing.Point(748, 1);
            this.btn_turTurSayfasinaGec.Name = "btn_turTurSayfasinaGec";
            this.btn_turTurSayfasinaGec.Size = new System.Drawing.Size(124, 23);
            this.btn_turTurSayfasinaGec.TabIndex = 36;
            this.btn_turTurSayfasinaGec.Text = "Tur Tur Sayfasına Geç";
            this.btn_turTurSayfasinaGec.UseVisualStyleBackColor = true;
            this.btn_turTurSayfasinaGec.Click += new System.EventHandler(this.btn_turTurSayfasinaGec_Click);
            // 
            // cms_TurPaketForm
            // 
            this.cms_TurPaketForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turPaketKaydiOlusturToolStripMenuItem,
            this.paketKaydiGuncelleToolStripMenuItem,
            this.paketKaydiSilToolStripMenuItem,
            this.turTurSayfasinaGecToolStripMenuItem,
            this.sayfayiKapatToolStripMenuItem});
            this.cms_TurPaketForm.Name = "cms_TurPaketForm";
            this.cms_TurPaketForm.Size = new System.Drawing.Size(195, 114);
            // 
            // turPaketKaydiOlusturToolStripMenuItem
            // 
            this.turPaketKaydiOlusturToolStripMenuItem.Name = "turPaketKaydiOlusturToolStripMenuItem";
            this.turPaketKaydiOlusturToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.turPaketKaydiOlusturToolStripMenuItem.Text = "Tur Paket Kaydı Ouştur";
            this.turPaketKaydiOlusturToolStripMenuItem.Click += new System.EventHandler(this.btn_turPaketEkle_Click);
            // 
            // paketKaydiGuncelleToolStripMenuItem
            // 
            this.paketKaydiGuncelleToolStripMenuItem.Name = "paketKaydiGuncelleToolStripMenuItem";
            this.paketKaydiGuncelleToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.paketKaydiGuncelleToolStripMenuItem.Text = "Paket Kaydı Güncelle";
            this.paketKaydiGuncelleToolStripMenuItem.Click += new System.EventHandler(this.btn_turPaketGuncelle_Click);
            // 
            // paketKaydiSilToolStripMenuItem
            // 
            this.paketKaydiSilToolStripMenuItem.Name = "paketKaydiSilToolStripMenuItem";
            this.paketKaydiSilToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.paketKaydiSilToolStripMenuItem.Text = "Paket Kaydı Sil";
            this.paketKaydiSilToolStripMenuItem.Click += new System.EventHandler(this.btn_turPaketSil_Click);
            // 
            // turTurSayfasinaGecToolStripMenuItem
            // 
            this.turTurSayfasinaGecToolStripMenuItem.Name = "turTurSayfasinaGecToolStripMenuItem";
            this.turTurSayfasinaGecToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.turTurSayfasinaGecToolStripMenuItem.Text = "Tur Tür Sayfasına Geç";
            this.turTurSayfasinaGecToolStripMenuItem.Click += new System.EventHandler(this.btn_turTurSayfasinaGec_Click);
            // 
            // sayfayiKapatToolStripMenuItem
            // 
            this.sayfayiKapatToolStripMenuItem.Name = "sayfayiKapatToolStripMenuItem";
            this.sayfayiKapatToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.sayfayiKapatToolStripMenuItem.Text = "Sayfayı Kapat";
            this.sayfayiKapatToolStripMenuItem.Click += new System.EventHandler(this.btn_TPCikis_Click);
            // 
            // TurPaketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(907, 388);
            this.ContextMenuStrip = this.cms_TurPaketForm;
            this.Controls.Add(this.btn_turTurSayfasinaGec);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_TPCikis);
            this.Controls.Add(this.btn_turPaketSil);
            this.Controls.Add(this.btn_turPaketGuncelle);
            this.Controls.Add(this.btn_turPaketEkle);
            this.Controls.Add(this.dgv_turPaketKayitlari);
            this.Controls.Add(this.cbx_konaklamaTurSecimi);
            this.Controls.Add(this.cbx_hizmetTurSecimi);
            this.Controls.Add(this.dtp_gecerlilikSuresi);
            this.Controls.Add(this.tx_paketAdOlustur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "TurPaketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TurPaketleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TurPaketleri_FormClosing);
            this.Load += new System.EventHandler(this.TurPaketleri_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TurPaketleri_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turPaketKayitlari)).EndInit();
            this.cms_TurPaketForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_paketAdOlustur;
        private System.Windows.Forms.DateTimePicker dtp_gecerlilikSuresi;
        private System.Windows.Forms.ComboBox cbx_hizmetTurSecimi;
        private System.Windows.Forms.ComboBox cbx_konaklamaTurSecimi;
        private System.Windows.Forms.DataGridView dgv_turPaketKayitlari;
        private System.Windows.Forms.Button btn_turPaketEkle;
        private System.Windows.Forms.Button btn_turPaketGuncelle;
        private System.Windows.Forms.Button btn_turPaketSil;
        private System.Windows.Forms.Button btn_TPCikis;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_turTurSayfasinaGec;
        private System.Windows.Forms.ContextMenuStrip cms_TurPaketForm;
        private System.Windows.Forms.ToolStripMenuItem turPaketKaydiOlusturToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paketKaydiGuncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paketKaydiSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turTurSayfasinaGecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sayfayiKapatToolStripMenuItem;
    }
}