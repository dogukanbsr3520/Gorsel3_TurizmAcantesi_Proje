namespace Gorsel3_TurizmAcantesi_Proje
{
    partial class BiletSatisIslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BiletSatisIslemleri));
            this.dgv_biletSatisIslemleriKayitlari = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_biletTutar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_biletKes = new System.Windows.Forms.Button();
            this.btn_biletGüncelle = new System.Windows.Forms.Button();
            this.btn_biletKaydiSil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_musteriBilg = new System.Windows.Forms.ComboBox();
            this.cbx_biletTurSec = new System.Windows.Forms.ComboBox();
            this.tx_musteriKayitAra = new System.Windows.Forms.TextBox();
            this.btn_biletKaydiTemizle = new System.Windows.Forms.Button();
            this.btn_BSICikis = new System.Windows.Forms.Button();
            this.btn_biletTurSayfaDon = new System.Windows.Forms.Button();
            this.cms_biletSatisForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.biletKesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletKaydiGuncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletKaydiSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biletTurSayfasinaGecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sayfayiKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_biletSatisIslemleriKayitlari)).BeginInit();
            this.cms_biletSatisForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_biletSatisIslemleriKayitlari
            // 
            this.dgv_biletSatisIslemleriKayitlari.AllowUserToAddRows = false;
            this.dgv_biletSatisIslemleriKayitlari.AllowUserToDeleteRows = false;
            this.dgv_biletSatisIslemleriKayitlari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_biletSatisIslemleriKayitlari.Location = new System.Drawing.Point(22, 280);
            this.dgv_biletSatisIslemleriKayitlari.Name = "dgv_biletSatisIslemleriKayitlari";
            this.dgv_biletSatisIslemleriKayitlari.ReadOnly = true;
            this.dgv_biletSatisIslemleriKayitlari.Size = new System.Drawing.Size(664, 150);
            this.dgv_biletSatisIslemleriKayitlari.TabIndex = 0;
            this.dgv_biletSatisIslemleriKayitlari.SelectionChanged += new System.EventHandler(this.dgv_biletSatisIslemleriKayitlari_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(350, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Bilet Tutarı : ";
            // 
            // tx_biletTutar
            // 
            this.tx_biletTutar.Location = new System.Drawing.Point(424, 88);
            this.tx_biletTutar.Name = "tx_biletTutar";
            this.tx_biletTutar.Size = new System.Drawing.Size(121, 20);
            this.tx_biletTutar.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(306, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Bilet Türünü Seçiniz : ";
            // 
            // btn_biletKes
            // 
            this.btn_biletKes.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_biletKes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_biletKes.BackgroundImage")));
            this.btn_biletKes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_biletKes.Location = new System.Drawing.Point(597, 28);
            this.btn_biletKes.Name = "btn_biletKes";
            this.btn_biletKes.Size = new System.Drawing.Size(75, 56);
            this.btn_biletKes.TabIndex = 20;
            this.btn_biletKes.UseVisualStyleBackColor = false;
            this.btn_biletKes.Click += new System.EventHandler(this.btn_biletKes_Click);
            // 
            // btn_biletGüncelle
            // 
            this.btn_biletGüncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_biletGüncelle.BackgroundImage")));
            this.btn_biletGüncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_biletGüncelle.Location = new System.Drawing.Point(597, 87);
            this.btn_biletGüncelle.Name = "btn_biletGüncelle";
            this.btn_biletGüncelle.Size = new System.Drawing.Size(75, 57);
            this.btn_biletGüncelle.TabIndex = 21;
            this.btn_biletGüncelle.UseVisualStyleBackColor = true;
            this.btn_biletGüncelle.Click += new System.EventHandler(this.btn_biletGüncelle_Click);
            // 
            // btn_biletKaydiSil
            // 
            this.btn_biletKaydiSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_biletKaydiSil.BackgroundImage")));
            this.btn_biletKaydiSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_biletKaydiSil.Location = new System.Drawing.Point(597, 148);
            this.btn_biletKaydiSil.Name = "btn_biletKaydiSil";
            this.btn_biletKaydiSil.Size = new System.Drawing.Size(75, 60);
            this.btn_biletKaydiSil.TabIndex = 22;
            this.btn_biletKaydiSil.UseVisualStyleBackColor = true;
            this.btn_biletKaydiSil.Click += new System.EventHandler(this.btn_biletKaydiSil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(3, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Müşteri Bilgileri : ";
            // 
            // cbx_musteriBilg
            // 
            this.cbx_musteriBilg.FormattingEnabled = true;
            this.cbx_musteriBilg.Location = new System.Drawing.Point(6, 87);
            this.cbx_musteriBilg.Name = "cbx_musteriBilg";
            this.cbx_musteriBilg.Size = new System.Drawing.Size(224, 21);
            this.cbx_musteriBilg.TabIndex = 26;
            this.cbx_musteriBilg.SelectedIndexChanged += new System.EventHandler(this.cbx_musteriBilg_SelectedIndexChanged);
            // 
            // cbx_biletTurSec
            // 
            this.cbx_biletTurSec.FormattingEnabled = true;
            this.cbx_biletTurSec.Location = new System.Drawing.Point(424, 143);
            this.cbx_biletTurSec.Name = "cbx_biletTurSec";
            this.cbx_biletTurSec.Size = new System.Drawing.Size(121, 21);
            this.cbx_biletTurSec.TabIndex = 27;
            // 
            // tx_musteriKayitAra
            // 
            this.tx_musteriKayitAra.ForeColor = System.Drawing.Color.Gray;
            this.tx_musteriKayitAra.Location = new System.Drawing.Point(237, 87);
            this.tx_musteriKayitAra.Name = "tx_musteriKayitAra";
            this.tx_musteriKayitAra.Size = new System.Drawing.Size(55, 20);
            this.tx_musteriKayitAra.TabIndex = 28;
            this.tx_musteriKayitAra.Text = "Kayıt ara...";
            this.tx_musteriKayitAra.TextChanged += new System.EventHandler(this.tx_musteriKayitAra_TextChanged);
            this.tx_musteriKayitAra.Enter += new System.EventHandler(this.tx_musteriKayitAra_Enter);
            this.tx_musteriKayitAra.Leave += new System.EventHandler(this.tx_musteriKayitAra_Leave);
            // 
            // btn_biletKaydiTemizle
            // 
            this.btn_biletKaydiTemizle.Location = new System.Drawing.Point(559, 209);
            this.btn_biletKaydiTemizle.Name = "btn_biletKaydiTemizle";
            this.btn_biletKaydiTemizle.Size = new System.Drawing.Size(144, 23);
            this.btn_biletKaydiTemizle.TabIndex = 30;
            this.btn_biletKaydiTemizle.Text = "Bilet Kaydı Alanları Temizle";
            this.btn_biletKaydiTemizle.UseVisualStyleBackColor = true;
            this.btn_biletKaydiTemizle.Click += new System.EventHandler(this.btn_biletKaydiTemizle_Click);
            // 
            // btn_BSICikis
            // 
            this.btn_BSICikis.Location = new System.Drawing.Point(676, 3);
            this.btn_BSICikis.Name = "btn_BSICikis";
            this.btn_BSICikis.Size = new System.Drawing.Size(27, 23);
            this.btn_BSICikis.TabIndex = 31;
            this.btn_BSICikis.Text = " X";
            this.btn_BSICikis.UseVisualStyleBackColor = true;
            this.btn_BSICikis.Click += new System.EventHandler(this.btn_BSICikis_Click);
            // 
            // btn_biletTurSayfaDon
            // 
            this.btn_biletTurSayfaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_biletTurSayfaDon.Location = new System.Drawing.Point(548, 143);
            this.btn_biletTurSayfaDon.Name = "btn_biletTurSayfaDon";
            this.btn_biletTurSayfaDon.Size = new System.Drawing.Size(26, 21);
            this.btn_biletTurSayfaDon.TabIndex = 32;
            this.btn_biletTurSayfaDon.Text = " +";
            this.btn_biletTurSayfaDon.UseVisualStyleBackColor = true;
            this.btn_biletTurSayfaDon.Click += new System.EventHandler(this.btn_biletTurSayfaDon_Click);
            // 
            // cms_biletSatisForm
            // 
            this.cms_biletSatisForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biletKesToolStripMenuItem,
            this.biletKaydiGuncelleToolStripMenuItem,
            this.biletKaydiSilToolStripMenuItem,
            this.biletTurSayfasinaGecToolStripMenuItem,
            this.sayfayiKapatToolStripMenuItem});
            this.cms_biletSatisForm.Name = "cms_biletSatisForm";
            this.cms_biletSatisForm.Size = new System.Drawing.Size(193, 114);
            // 
            // biletKesToolStripMenuItem
            // 
            this.biletKesToolStripMenuItem.Name = "biletKesToolStripMenuItem";
            this.biletKesToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.biletKesToolStripMenuItem.Text = "Bilet Kes";
            this.biletKesToolStripMenuItem.Click += new System.EventHandler(this.btn_biletKes_Click);
            // 
            // biletKaydiGuncelleToolStripMenuItem
            // 
            this.biletKaydiGuncelleToolStripMenuItem.Name = "biletKaydiGuncelleToolStripMenuItem";
            this.biletKaydiGuncelleToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.biletKaydiGuncelleToolStripMenuItem.Text = "Bilet Kaydı Güncelle";
            this.biletKaydiGuncelleToolStripMenuItem.Click += new System.EventHandler(this.btn_biletGüncelle_Click);
            // 
            // biletKaydiSilToolStripMenuItem
            // 
            this.biletKaydiSilToolStripMenuItem.Name = "biletKaydiSilToolStripMenuItem";
            this.biletKaydiSilToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.biletKaydiSilToolStripMenuItem.Text = "Bilet Kaydı Sil";
            this.biletKaydiSilToolStripMenuItem.Click += new System.EventHandler(this.btn_biletKaydiSil_Click);
            // 
            // biletTurSayfasinaGecToolStripMenuItem
            // 
            this.biletTurSayfasinaGecToolStripMenuItem.Name = "biletTurSayfasinaGecToolStripMenuItem";
            this.biletTurSayfasinaGecToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.biletTurSayfasinaGecToolStripMenuItem.Text = "Bilet Tür Sayfasına Geç";
            this.biletTurSayfasinaGecToolStripMenuItem.Click += new System.EventHandler(this.btn_biletTurSayfaDon_Click);
            // 
            // sayfayiKapatToolStripMenuItem
            // 
            this.sayfayiKapatToolStripMenuItem.Name = "sayfayiKapatToolStripMenuItem";
            this.sayfayiKapatToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.sayfayiKapatToolStripMenuItem.Text = "Sayfayı Kapat";
            this.sayfayiKapatToolStripMenuItem.Click += new System.EventHandler(this.btn_BSICikis_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(195, 25);
            this.label11.TabIndex = 35;
            this.label11.Text = "Bilet Satış İşlemleri";
            // 
            // BiletSatisIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(708, 433);
            this.ContextMenuStrip = this.cms_biletSatisForm;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_biletTurSayfaDon);
            this.Controls.Add(this.btn_BSICikis);
            this.Controls.Add(this.btn_biletKaydiTemizle);
            this.Controls.Add(this.tx_musteriKayitAra);
            this.Controls.Add(this.cbx_biletTurSec);
            this.Controls.Add(this.cbx_musteriBilg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_biletKaydiSil);
            this.Controls.Add(this.btn_biletGüncelle);
            this.Controls.Add(this.btn_biletKes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tx_biletTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_biletSatisIslemleriKayitlari);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "BiletSatisIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BiletSatisIslemleri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BiletSatisIslemleri_FormClosing);
            this.Load += new System.EventHandler(this.BiletSatisIslemleri_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BiletSatisIslemleri_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_biletSatisIslemleriKayitlari)).EndInit();
            this.cms_biletSatisForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_biletSatisIslemleriKayitlari;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_biletTutar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_biletKes;
        private System.Windows.Forms.Button btn_biletGüncelle;
        private System.Windows.Forms.Button btn_biletKaydiSil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_musteriBilg;
        private System.Windows.Forms.ComboBox cbx_biletTurSec;
        private System.Windows.Forms.TextBox tx_musteriKayitAra;
        private System.Windows.Forms.Button btn_biletKaydiTemizle;
        private System.Windows.Forms.Button btn_BSICikis;
        private System.Windows.Forms.Button btn_biletTurSayfaDon;
        private System.Windows.Forms.ContextMenuStrip cms_biletSatisForm;
        private System.Windows.Forms.ToolStripMenuItem biletKesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biletKaydiGuncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biletKaydiSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem biletTurSayfasinaGecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sayfayiKapatToolStripMenuItem;
        private System.Windows.Forms.Label label11;
    }
}