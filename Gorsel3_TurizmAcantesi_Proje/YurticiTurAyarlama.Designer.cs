namespace Gorsel3_TurizmAcantesi_Proje
{
    partial class YurticiTurAyarlama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YurticiTurAyarlama));
            this.label1 = new System.Windows.Forms.Label();
            this.tx_yurtIciTurAyarla = new System.Windows.Forms.TextBox();
            this.dgv_YurtIciTurKayitlari = new System.Windows.Forms.DataGridView();
            this.btn_yurticiTurGuncelle = new System.Windows.Forms.Button();
            this.btn_yurticiTurSil = new System.Windows.Forms.Button();
            this.btn_yurticiTurEkle = new System.Windows.Forms.Button();
            this.btn_YDTACikis = new System.Windows.Forms.Button();
            this.btn_yurtDisiSayfaGec = new System.Windows.Forms.Button();
            this.cms_YurticiTurForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yurticiTurKaydiEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yurticiTurKaydiGuncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yurticiTurKaydiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yurtDisiTurSayfasinaGecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sayfayiKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_YurtIciTurKayitlari)).BeginInit();
            this.cms_YurticiTurForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yurt İçi Tur Ayarla : ";
            // 
            // tx_yurtIciTurAyarla
            // 
            this.tx_yurtIciTurAyarla.Location = new System.Drawing.Point(364, 201);
            this.tx_yurtIciTurAyarla.Name = "tx_yurtIciTurAyarla";
            this.tx_yurtIciTurAyarla.Size = new System.Drawing.Size(100, 20);
            this.tx_yurtIciTurAyarla.TabIndex = 1;
            // 
            // dgv_YurtIciTurKayitlari
            // 
            this.dgv_YurtIciTurKayitlari.AllowUserToAddRows = false;
            this.dgv_YurtIciTurKayitlari.AllowUserToDeleteRows = false;
            this.dgv_YurtIciTurKayitlari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_YurtIciTurKayitlari.Location = new System.Drawing.Point(475, 213);
            this.dgv_YurtIciTurKayitlari.Name = "dgv_YurtIciTurKayitlari";
            this.dgv_YurtIciTurKayitlari.ReadOnly = true;
            this.dgv_YurtIciTurKayitlari.Size = new System.Drawing.Size(206, 150);
            this.dgv_YurtIciTurKayitlari.TabIndex = 2;
            this.dgv_YurtIciTurKayitlari.SelectionChanged += new System.EventHandler(this.dgv_YurtIciTurKayitlari_SelectionChanged);
            // 
            // btn_yurticiTurGuncelle
            // 
            this.btn_yurticiTurGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_yurticiTurGuncelle.BackgroundImage")));
            this.btn_yurticiTurGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_yurticiTurGuncelle.Location = new System.Drawing.Point(592, 120);
            this.btn_yurticiTurGuncelle.Name = "btn_yurticiTurGuncelle";
            this.btn_yurticiTurGuncelle.Size = new System.Drawing.Size(89, 42);
            this.btn_yurticiTurGuncelle.TabIndex = 4;
            this.btn_yurticiTurGuncelle.UseVisualStyleBackColor = true;
            this.btn_yurticiTurGuncelle.Click += new System.EventHandler(this.btn_yurticiTurGuncelle_Click);
            // 
            // btn_yurticiTurSil
            // 
            this.btn_yurticiTurSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_yurticiTurSil.BackgroundImage")));
            this.btn_yurticiTurSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_yurticiTurSil.Location = new System.Drawing.Point(592, 168);
            this.btn_yurticiTurSil.Name = "btn_yurticiTurSil";
            this.btn_yurticiTurSil.Size = new System.Drawing.Size(89, 42);
            this.btn_yurticiTurSil.TabIndex = 5;
            this.btn_yurticiTurSil.UseVisualStyleBackColor = true;
            this.btn_yurticiTurSil.Click += new System.EventHandler(this.btn_yurticiTurSil_Click);
            // 
            // btn_yurticiTurEkle
            // 
            this.btn_yurticiTurEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_yurticiTurEkle.BackgroundImage")));
            this.btn_yurticiTurEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_yurticiTurEkle.Location = new System.Drawing.Point(592, 58);
            this.btn_yurticiTurEkle.Name = "btn_yurticiTurEkle";
            this.btn_yurticiTurEkle.Size = new System.Drawing.Size(89, 47);
            this.btn_yurticiTurEkle.TabIndex = 7;
            this.btn_yurticiTurEkle.UseVisualStyleBackColor = true;
            this.btn_yurticiTurEkle.Click += new System.EventHandler(this.btn_yurticiTurEkle_Click);
            // 
            // btn_YDTACikis
            // 
            this.btn_YDTACikis.Location = new System.Drawing.Point(655, 2);
            this.btn_YDTACikis.Name = "btn_YDTACikis";
            this.btn_YDTACikis.Size = new System.Drawing.Size(26, 23);
            this.btn_YDTACikis.TabIndex = 8;
            this.btn_YDTACikis.Text = " X";
            this.btn_YDTACikis.UseVisualStyleBackColor = true;
            this.btn_YDTACikis.Click += new System.EventHandler(this.btn_YDTACikis_Click);
            // 
            // btn_yurtDisiSayfaGec
            // 
            this.btn_yurtDisiSayfaGec.Location = new System.Drawing.Point(523, 2);
            this.btn_yurtDisiSayfaGec.Name = "btn_yurtDisiSayfaGec";
            this.btn_yurtDisiSayfaGec.Size = new System.Drawing.Size(129, 23);
            this.btn_yurtDisiSayfaGec.TabIndex = 9;
            this.btn_yurtDisiSayfaGec.Text = "YurtDışı Sayfasına Dön";
            this.btn_yurtDisiSayfaGec.UseVisualStyleBackColor = true;
            this.btn_yurtDisiSayfaGec.Click += new System.EventHandler(this.btn_yurtDisiSayfaGec_Click);
            // 
            // cms_YurticiTurForm
            // 
            this.cms_YurticiTurForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yurticiTurKaydiEkleToolStripMenuItem,
            this.yurticiTurKaydiGuncelleToolStripMenuItem,
            this.yurticiTurKaydiSilToolStripMenuItem,
            this.yurtDisiTurSayfasinaGecToolStripMenuItem,
            this.sayfayiKapatToolStripMenuItem});
            this.cms_YurticiTurForm.Name = "cms_YurticiTurForm";
            this.cms_YurticiTurForm.Size = new System.Drawing.Size(211, 114);
            // 
            // yurticiTurKaydiEkleToolStripMenuItem
            // 
            this.yurticiTurKaydiEkleToolStripMenuItem.Name = "yurticiTurKaydiEkleToolStripMenuItem";
            this.yurticiTurKaydiEkleToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.yurticiTurKaydiEkleToolStripMenuItem.Text = "Yurtiçi Tur Kaydı Ekle";
            this.yurticiTurKaydiEkleToolStripMenuItem.Click += new System.EventHandler(this.btn_yurticiTurEkle_Click);
            // 
            // yurticiTurKaydiGuncelleToolStripMenuItem
            // 
            this.yurticiTurKaydiGuncelleToolStripMenuItem.Name = "yurticiTurKaydiGuncelleToolStripMenuItem";
            this.yurticiTurKaydiGuncelleToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.yurticiTurKaydiGuncelleToolStripMenuItem.Text = "Yurtiçi Tur Kaydı Güncelle";
            this.yurticiTurKaydiGuncelleToolStripMenuItem.Click += new System.EventHandler(this.btn_yurticiTurGuncelle_Click);
            // 
            // yurticiTurKaydiSilToolStripMenuItem
            // 
            this.yurticiTurKaydiSilToolStripMenuItem.Name = "yurticiTurKaydiSilToolStripMenuItem";
            this.yurticiTurKaydiSilToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.yurticiTurKaydiSilToolStripMenuItem.Text = "Yurtiçi Tur Kaydı Sil";
            this.yurticiTurKaydiSilToolStripMenuItem.Click += new System.EventHandler(this.btn_yurticiTurSil_Click);
            // 
            // yurtDisiTurSayfasinaGecToolStripMenuItem
            // 
            this.yurtDisiTurSayfasinaGecToolStripMenuItem.Name = "yurtDisiTurSayfasinaGecToolStripMenuItem";
            this.yurtDisiTurSayfasinaGecToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.yurtDisiTurSayfasinaGecToolStripMenuItem.Text = "YurtDışı Tur Sayfasına Geç";
            this.yurtDisiTurSayfasinaGecToolStripMenuItem.Click += new System.EventHandler(this.btn_yurtDisiSayfaGec_Click);
            // 
            // sayfayiKapatToolStripMenuItem
            // 
            this.sayfayiKapatToolStripMenuItem.Name = "sayfayiKapatToolStripMenuItem";
            this.sayfayiKapatToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.sayfayiKapatToolStripMenuItem.Text = "Sayfayı Kapat";
            this.sayfayiKapatToolStripMenuItem.Click += new System.EventHandler(this.btn_YDTACikis_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(4, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(195, 18);
            this.label11.TabIndex = 37;
            this.label11.Text = "Yurtİçi Tur Kayıt İşlemleri";
            // 
            // YurticiTurAyarlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(684, 365);
            this.ContextMenuStrip = this.cms_YurticiTurForm;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_yurtDisiSayfaGec);
            this.Controls.Add(this.btn_YDTACikis);
            this.Controls.Add(this.btn_yurticiTurEkle);
            this.Controls.Add(this.btn_yurticiTurSil);
            this.Controls.Add(this.btn_yurticiTurGuncelle);
            this.Controls.Add(this.dgv_YurtIciTurKayitlari);
            this.Controls.Add(this.tx_yurtIciTurAyarla);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "YurticiTurAyarlama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YurticiTurAyarlama";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YurticiTurAyarlama_FormClosing);
            this.Load += new System.EventHandler(this.YurticiTurAyarlama_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.YurticiTurAyarlama_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_YurtIciTurKayitlari)).EndInit();
            this.cms_YurticiTurForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_yurtIciTurAyarla;
        private System.Windows.Forms.DataGridView dgv_YurtIciTurKayitlari;
        private System.Windows.Forms.Button btn_yurticiTurGuncelle;
        private System.Windows.Forms.Button btn_yurticiTurSil;
        private System.Windows.Forms.Button btn_yurticiTurEkle;
        private System.Windows.Forms.Button btn_YDTACikis;
        private System.Windows.Forms.Button btn_yurtDisiSayfaGec;
        private System.Windows.Forms.ContextMenuStrip cms_YurticiTurForm;
        private System.Windows.Forms.ToolStripMenuItem yurticiTurKaydiEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yurticiTurKaydiGuncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yurticiTurKaydiSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yurtDisiTurSayfasinaGecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sayfayiKapatToolStripMenuItem;
        private System.Windows.Forms.Label label11;
    }
}