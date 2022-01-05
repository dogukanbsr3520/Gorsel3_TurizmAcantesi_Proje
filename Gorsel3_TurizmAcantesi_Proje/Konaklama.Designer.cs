namespace Gorsel3_TurizmAcantesi_Proje
{
    partial class Konaklama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Konaklama));
            this.btn_konaklamaEkle = new System.Windows.Forms.Button();
            this.btn_konaklamaSil = new System.Windows.Forms.Button();
            this.btn_konaklamaGuncelle = new System.Windows.Forms.Button();
            this.dgv_konaklamaKayitlari = new System.Windows.Forms.DataGridView();
            this.tx_konaklama = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_KCikis = new System.Windows.Forms.Button();
            this.btn_hizmetSayfaGec = new System.Windows.Forms.Button();
            this.cms_konaklamaForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.konaklamaTuruEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konaklamaKaydiGuncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konaklamaKaydiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hizmetSayfasinaGecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sayfayiKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_konaklamaKayitlari)).BeginInit();
            this.cms_konaklamaForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_konaklamaEkle
            // 
            this.btn_konaklamaEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_konaklamaEkle.BackgroundImage")));
            this.btn_konaklamaEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_konaklamaEkle.Location = new System.Drawing.Point(590, 165);
            this.btn_konaklamaEkle.Name = "btn_konaklamaEkle";
            this.btn_konaklamaEkle.Size = new System.Drawing.Size(79, 59);
            this.btn_konaklamaEkle.TabIndex = 17;
            this.btn_konaklamaEkle.UseVisualStyleBackColor = true;
            this.btn_konaklamaEkle.Click += new System.EventHandler(this.btn_konaklamaEkle_Click);
            // 
            // btn_konaklamaSil
            // 
            this.btn_konaklamaSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_konaklamaSil.BackgroundImage")));
            this.btn_konaklamaSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_konaklamaSil.Location = new System.Drawing.Point(591, 289);
            this.btn_konaklamaSil.Name = "btn_konaklamaSil";
            this.btn_konaklamaSil.Size = new System.Drawing.Size(76, 39);
            this.btn_konaklamaSil.TabIndex = 16;
            this.btn_konaklamaSil.UseVisualStyleBackColor = true;
            this.btn_konaklamaSil.Click += new System.EventHandler(this.btn_konaklamaSil_Click);
            // 
            // btn_konaklamaGuncelle
            // 
            this.btn_konaklamaGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_konaklamaGuncelle.BackgroundImage")));
            this.btn_konaklamaGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_konaklamaGuncelle.Location = new System.Drawing.Point(590, 230);
            this.btn_konaklamaGuncelle.Name = "btn_konaklamaGuncelle";
            this.btn_konaklamaGuncelle.Size = new System.Drawing.Size(79, 51);
            this.btn_konaklamaGuncelle.TabIndex = 15;
            this.btn_konaklamaGuncelle.UseVisualStyleBackColor = true;
            this.btn_konaklamaGuncelle.Click += new System.EventHandler(this.btn_konaklamaGuncelle_Click);
            // 
            // dgv_konaklamaKayitlari
            // 
            this.dgv_konaklamaKayitlari.AllowUserToAddRows = false;
            this.dgv_konaklamaKayitlari.AllowUserToDeleteRows = false;
            this.dgv_konaklamaKayitlari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_konaklamaKayitlari.Location = new System.Drawing.Point(8, 158);
            this.dgv_konaklamaKayitlari.Name = "dgv_konaklamaKayitlari";
            this.dgv_konaklamaKayitlari.ReadOnly = true;
            this.dgv_konaklamaKayitlari.Size = new System.Drawing.Size(318, 98);
            this.dgv_konaklamaKayitlari.TabIndex = 14;
            this.dgv_konaklamaKayitlari.SelectionChanged += new System.EventHandler(this.dgv_konaklamaKayitlari_SelectionChanged);
            // 
            // tx_konaklama
            // 
            this.tx_konaklama.Location = new System.Drawing.Point(141, 65);
            this.tx_konaklama.Name = "tx_konaklama";
            this.tx_konaklama.Size = new System.Drawing.Size(100, 20);
            this.tx_konaklama.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Konaklama Türü giriniz : ";
            // 
            // btn_KCikis
            // 
            this.btn_KCikis.Location = new System.Drawing.Point(632, 2);
            this.btn_KCikis.Name = "btn_KCikis";
            this.btn_KCikis.Size = new System.Drawing.Size(34, 23);
            this.btn_KCikis.TabIndex = 18;
            this.btn_KCikis.Text = " X";
            this.btn_KCikis.UseVisualStyleBackColor = true;
            this.btn_KCikis.Click += new System.EventHandler(this.btn_KCikis_Click);
            // 
            // btn_hizmetSayfaGec
            // 
            this.btn_hizmetSayfaGec.Location = new System.Drawing.Point(502, 2);
            this.btn_hizmetSayfaGec.Name = "btn_hizmetSayfaGec";
            this.btn_hizmetSayfaGec.Size = new System.Drawing.Size(124, 23);
            this.btn_hizmetSayfaGec.TabIndex = 19;
            this.btn_hizmetSayfaGec.Text = "Hzimet Sayfasına Geç";
            this.btn_hizmetSayfaGec.UseVisualStyleBackColor = true;
            this.btn_hizmetSayfaGec.Click += new System.EventHandler(this.btn_hizmetSayfaGec_Click);
            // 
            // cms_konaklamaForm
            // 
            this.cms_konaklamaForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konaklamaTuruEkleToolStripMenuItem,
            this.konaklamaKaydiGuncelleToolStripMenuItem,
            this.konaklamaKaydiSilToolStripMenuItem,
            this.hizmetSayfasinaGecToolStripMenuItem,
            this.sayfayiKapatToolStripMenuItem});
            this.cms_konaklamaForm.Name = "cms_konaklamaForm";
            this.cms_konaklamaForm.Size = new System.Drawing.Size(215, 114);
            // 
            // konaklamaTuruEkleToolStripMenuItem
            // 
            this.konaklamaTuruEkleToolStripMenuItem.Name = "konaklamaTuruEkleToolStripMenuItem";
            this.konaklamaTuruEkleToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.konaklamaTuruEkleToolStripMenuItem.Text = "Konaklama Türü Ekle";
            this.konaklamaTuruEkleToolStripMenuItem.Click += new System.EventHandler(this.btn_konaklamaEkle_Click);
            // 
            // konaklamaKaydiGuncelleToolStripMenuItem
            // 
            this.konaklamaKaydiGuncelleToolStripMenuItem.Name = "konaklamaKaydiGuncelleToolStripMenuItem";
            this.konaklamaKaydiGuncelleToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.konaklamaKaydiGuncelleToolStripMenuItem.Text = "Konaklama Kaydı Güncelle";
            this.konaklamaKaydiGuncelleToolStripMenuItem.Click += new System.EventHandler(this.btn_konaklamaGuncelle_Click);
            // 
            // konaklamaKaydiSilToolStripMenuItem
            // 
            this.konaklamaKaydiSilToolStripMenuItem.Name = "konaklamaKaydiSilToolStripMenuItem";
            this.konaklamaKaydiSilToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.konaklamaKaydiSilToolStripMenuItem.Text = "Konaklama kaydı Sil";
            this.konaklamaKaydiSilToolStripMenuItem.Click += new System.EventHandler(this.btn_konaklamaSil_Click);
            // 
            // hizmetSayfasinaGecToolStripMenuItem
            // 
            this.hizmetSayfasinaGecToolStripMenuItem.Name = "hizmetSayfasinaGecToolStripMenuItem";
            this.hizmetSayfasinaGecToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.hizmetSayfasinaGecToolStripMenuItem.Text = "Hizmet Sayfasına Geç";
            this.hizmetSayfasinaGecToolStripMenuItem.Click += new System.EventHandler(this.btn_hizmetSayfaGec_Click);
            // 
            // sayfayiKapatToolStripMenuItem
            // 
            this.sayfayiKapatToolStripMenuItem.Name = "sayfayiKapatToolStripMenuItem";
            this.sayfayiKapatToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.sayfayiKapatToolStripMenuItem.Text = "Sayfayı kapat";
            this.sayfayiKapatToolStripMenuItem.Click += new System.EventHandler(this.btn_KCikis_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(4, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(213, 20);
            this.label11.TabIndex = 36;
            this.label11.Text = "Konaklama Kayıt İşlemleri";
            // 
            // Konaklama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(672, 334);
            this.ContextMenuStrip = this.cms_konaklamaForm;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_hizmetSayfaGec);
            this.Controls.Add(this.btn_KCikis);
            this.Controls.Add(this.btn_konaklamaEkle);
            this.Controls.Add(this.btn_konaklamaSil);
            this.Controls.Add(this.btn_konaklamaGuncelle);
            this.Controls.Add(this.dgv_konaklamaKayitlari);
            this.Controls.Add(this.tx_konaklama);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Konaklama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Konaklama";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Konaklama_FormClosing);
            this.Load += new System.EventHandler(this.Konaklama_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Konaklama_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_konaklamaKayitlari)).EndInit();
            this.cms_konaklamaForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_konaklamaEkle;
        private System.Windows.Forms.Button btn_konaklamaSil;
        private System.Windows.Forms.Button btn_konaklamaGuncelle;
        private System.Windows.Forms.DataGridView dgv_konaklamaKayitlari;
        private System.Windows.Forms.TextBox tx_konaklama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_KCikis;
        private System.Windows.Forms.Button btn_hizmetSayfaGec;
        private System.Windows.Forms.ContextMenuStrip cms_konaklamaForm;
        private System.Windows.Forms.ToolStripMenuItem konaklamaTuruEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konaklamaKaydiGuncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konaklamaKaydiSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hizmetSayfasinaGecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sayfayiKapatToolStripMenuItem;
        private System.Windows.Forms.Label label11;
    }
}