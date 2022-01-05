namespace Gorsel3_TurizmAcantesi_Proje
{
    partial class Hizmetler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hizmetler));
            this.label1 = new System.Windows.Forms.Label();
            this.tx_hizmet = new System.Windows.Forms.TextBox();
            this.dgv_hizmetKayitlari = new System.Windows.Forms.DataGridView();
            this.btn_hizmetEkle = new System.Windows.Forms.Button();
            this.btn_hizmetSil = new System.Windows.Forms.Button();
            this.btn_hizmetGuncelle = new System.Windows.Forms.Button();
            this.btn_HCikis = new System.Windows.Forms.Button();
            this.btn_konaklamaSayfaGec = new System.Windows.Forms.Button();
            this.cms_hizmetForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hizmetEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hizmetKaydiGuncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hizmetKaydiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konaklamaSayfasinaGeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sayfayiKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hizmetKayitlari)).BeginInit();
            this.cms_hizmetForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.HotPink;
            this.label1.Location = new System.Drawing.Point(0, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hizmet giriniz : ";
            // 
            // tx_hizmet
            // 
            this.tx_hizmet.Location = new System.Drawing.Point(83, 171);
            this.tx_hizmet.Name = "tx_hizmet";
            this.tx_hizmet.Size = new System.Drawing.Size(100, 20);
            this.tx_hizmet.TabIndex = 1;
            // 
            // dgv_hizmetKayitlari
            // 
            this.dgv_hizmetKayitlari.AllowUserToAddRows = false;
            this.dgv_hizmetKayitlari.AllowUserToDeleteRows = false;
            this.dgv_hizmetKayitlari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hizmetKayitlari.Location = new System.Drawing.Point(3, 194);
            this.dgv_hizmetKayitlari.Name = "dgv_hizmetKayitlari";
            this.dgv_hizmetKayitlari.ReadOnly = true;
            this.dgv_hizmetKayitlari.Size = new System.Drawing.Size(214, 150);
            this.dgv_hizmetKayitlari.TabIndex = 2;
            this.dgv_hizmetKayitlari.SelectionChanged += new System.EventHandler(this.dgv_hizmetKayitlari_SelectionChanged);
            // 
            // btn_hizmetEkle
            // 
            this.btn_hizmetEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_hizmetEkle.BackgroundImage")));
            this.btn_hizmetEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hizmetEkle.Location = new System.Drawing.Point(519, 187);
            this.btn_hizmetEkle.Name = "btn_hizmetEkle";
            this.btn_hizmetEkle.Size = new System.Drawing.Size(95, 48);
            this.btn_hizmetEkle.TabIndex = 10;
            this.btn_hizmetEkle.UseVisualStyleBackColor = true;
            this.btn_hizmetEkle.Click += new System.EventHandler(this.btn_hizmetEkle_Click);
            // 
            // btn_hizmetSil
            // 
            this.btn_hizmetSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_hizmetSil.BackgroundImage")));
            this.btn_hizmetSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hizmetSil.Location = new System.Drawing.Point(519, 298);
            this.btn_hizmetSil.Name = "btn_hizmetSil";
            this.btn_hizmetSil.Size = new System.Drawing.Size(95, 54);
            this.btn_hizmetSil.TabIndex = 9;
            this.btn_hizmetSil.UseVisualStyleBackColor = true;
            this.btn_hizmetSil.Click += new System.EventHandler(this.btn_hizmetSil_Click);
            // 
            // btn_hizmetGuncelle
            // 
            this.btn_hizmetGuncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_hizmetGuncelle.BackgroundImage")));
            this.btn_hizmetGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hizmetGuncelle.Location = new System.Drawing.Point(519, 241);
            this.btn_hizmetGuncelle.Name = "btn_hizmetGuncelle";
            this.btn_hizmetGuncelle.Size = new System.Drawing.Size(95, 51);
            this.btn_hizmetGuncelle.TabIndex = 8;
            this.btn_hizmetGuncelle.UseVisualStyleBackColor = true;
            this.btn_hizmetGuncelle.Click += new System.EventHandler(this.btn_hizmetGuncelle_Click);
            // 
            // btn_HCikis
            // 
            this.btn_HCikis.Location = new System.Drawing.Point(620, 0);
            this.btn_HCikis.Name = "btn_HCikis";
            this.btn_HCikis.Size = new System.Drawing.Size(25, 23);
            this.btn_HCikis.TabIndex = 11;
            this.btn_HCikis.Text = " X";
            this.btn_HCikis.UseVisualStyleBackColor = true;
            this.btn_HCikis.Click += new System.EventHandler(this.btn_HCikis_Click);
            // 
            // btn_konaklamaSayfaGec
            // 
            this.btn_konaklamaSayfaGec.Location = new System.Drawing.Point(472, 0);
            this.btn_konaklamaSayfaGec.Name = "btn_konaklamaSayfaGec";
            this.btn_konaklamaSayfaGec.Size = new System.Drawing.Size(142, 23);
            this.btn_konaklamaSayfaGec.TabIndex = 12;
            this.btn_konaklamaSayfaGec.Text = "Konaklama Sayfasına Geç";
            this.btn_konaklamaSayfaGec.UseVisualStyleBackColor = true;
            this.btn_konaklamaSayfaGec.Click += new System.EventHandler(this.btn_konaklamaSayfaGec_Click);
            // 
            // cms_hizmetForm
            // 
            this.cms_hizmetForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hizmetEkleToolStripMenuItem,
            this.hizmetKaydiGuncelleToolStripMenuItem,
            this.hizmetKaydiSilToolStripMenuItem,
            this.konaklamaSayfasinaGeçToolStripMenuItem,
            this.sayfayiKapatToolStripMenuItem});
            this.cms_hizmetForm.Name = "cms_hizmetForm";
            this.cms_hizmetForm.Size = new System.Drawing.Size(209, 114);
            // 
            // hizmetEkleToolStripMenuItem
            // 
            this.hizmetEkleToolStripMenuItem.Name = "hizmetEkleToolStripMenuItem";
            this.hizmetEkleToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.hizmetEkleToolStripMenuItem.Text = "Hizmet Ekle";
            this.hizmetEkleToolStripMenuItem.Click += new System.EventHandler(this.btn_hizmetEkle_Click);
            // 
            // hizmetKaydiGuncelleToolStripMenuItem
            // 
            this.hizmetKaydiGuncelleToolStripMenuItem.Name = "hizmetKaydiGuncelleToolStripMenuItem";
            this.hizmetKaydiGuncelleToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.hizmetKaydiGuncelleToolStripMenuItem.Text = "Hizmet Kaydı Güncelle";
            this.hizmetKaydiGuncelleToolStripMenuItem.Click += new System.EventHandler(this.btn_hizmetGuncelle_Click);
            // 
            // hizmetKaydiSilToolStripMenuItem
            // 
            this.hizmetKaydiSilToolStripMenuItem.Name = "hizmetKaydiSilToolStripMenuItem";
            this.hizmetKaydiSilToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.hizmetKaydiSilToolStripMenuItem.Text = "Hizmet Kaydı Sil";
            this.hizmetKaydiSilToolStripMenuItem.Click += new System.EventHandler(this.btn_hizmetSil_Click);
            // 
            // konaklamaSayfasinaGeçToolStripMenuItem
            // 
            this.konaklamaSayfasinaGeçToolStripMenuItem.Name = "konaklamaSayfasinaGeçToolStripMenuItem";
            this.konaklamaSayfasinaGeçToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.konaklamaSayfasinaGeçToolStripMenuItem.Text = "Konaklama Sayfasına Geç";
            this.konaklamaSayfasinaGeçToolStripMenuItem.Click += new System.EventHandler(this.btn_konaklamaSayfaGec_Click);
            // 
            // sayfayiKapatToolStripMenuItem
            // 
            this.sayfayiKapatToolStripMenuItem.Name = "sayfayiKapatToolStripMenuItem";
            this.sayfayiKapatToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.sayfayiKapatToolStripMenuItem.Text = "Sayfayı Kapat";
            this.sayfayiKapatToolStripMenuItem.Click += new System.EventHandler(this.btn_HCikis_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(10, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(219, 25);
            this.label11.TabIndex = 36;
            this.label11.Text = "Hizmet Kayıt İşlemleri";
            // 
            // Hizmetler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(647, 356);
            this.ContextMenuStrip = this.cms_hizmetForm;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_konaklamaSayfaGec);
            this.Controls.Add(this.btn_HCikis);
            this.Controls.Add(this.btn_hizmetEkle);
            this.Controls.Add(this.btn_hizmetSil);
            this.Controls.Add(this.btn_hizmetGuncelle);
            this.Controls.Add(this.dgv_hizmetKayitlari);
            this.Controls.Add(this.tx_hizmet);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Hizmetler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hizmetler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Hizmetler_FormClosing);
            this.Load += new System.EventHandler(this.Hizmetler_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Hizmetler_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hizmetKayitlari)).EndInit();
            this.cms_hizmetForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tx_hizmet;
        private System.Windows.Forms.DataGridView dgv_hizmetKayitlari;
        private System.Windows.Forms.Button btn_hizmetEkle;
        private System.Windows.Forms.Button btn_hizmetSil;
        private System.Windows.Forms.Button btn_hizmetGuncelle;
        private System.Windows.Forms.Button btn_HCikis;
        private System.Windows.Forms.Button btn_konaklamaSayfaGec;
        private System.Windows.Forms.ContextMenuStrip cms_hizmetForm;
        private System.Windows.Forms.ToolStripMenuItem hizmetEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hizmetKaydiGuncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hizmetKaydiSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konaklamaSayfasinaGeçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sayfayiKapatToolStripMenuItem;
        private System.Windows.Forms.Label label11;
    }
}