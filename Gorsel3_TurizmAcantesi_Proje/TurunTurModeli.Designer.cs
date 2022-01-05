namespace Gorsel3_TurizmAcantesi_Proje
{
    partial class TurunTurModeli
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TurunTurModeli));
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tx_turAd = new System.Windows.Forms.TextBox();
            this.dgv_turTurKayitlari = new System.Windows.Forms.DataGridView();
            this.btn_turModelEkle = new System.Windows.Forms.Button();
            this.btn_turModelGüncelle = new System.Windows.Forms.Button();
            this.btn_turModelSil = new System.Windows.Forms.Button();
            this.cbx_turPaketAdi = new System.Windows.Forms.ComboBox();
            this.btn_TTMCikis = new System.Windows.Forms.Button();
            this.btn_turPaketSayfasınaGec = new System.Windows.Forms.Button();
            this.cms_TurModeliForm = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.turModeliniEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turModeliniGuncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turModeliniSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turPaketSayfasinaGecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sayfayiKapatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_yurtIciTur = new System.Windows.Forms.ComboBox();
            this.cbx_yurtDisiTur = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turTurKayitlari)).BeginInit();
            this.cms_TurModeliForm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tur Adını Giriniz : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Paket Adı Giriniz : ";
            // 
            // tx_turAd
            // 
            this.tx_turAd.Location = new System.Drawing.Point(109, 60);
            this.tx_turAd.Name = "tx_turAd";
            this.tx_turAd.Size = new System.Drawing.Size(100, 20);
            this.tx_turAd.TabIndex = 4;
            // 
            // dgv_turTurKayitlari
            // 
            this.dgv_turTurKayitlari.AllowUserToAddRows = false;
            this.dgv_turTurKayitlari.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_turTurKayitlari.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_turTurKayitlari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_turTurKayitlari.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_turTurKayitlari.Location = new System.Drawing.Point(223, 265);
            this.dgv_turTurKayitlari.Name = "dgv_turTurKayitlari";
            this.dgv_turTurKayitlari.ReadOnly = true;
            this.dgv_turTurKayitlari.Size = new System.Drawing.Size(523, 118);
            this.dgv_turTurKayitlari.TabIndex = 9;
            this.dgv_turTurKayitlari.SelectionChanged += new System.EventHandler(this.dgv_turTurKayitlari_SelectionChanged);
            // 
            // btn_turModelEkle
            // 
            this.btn_turModelEkle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_turModelEkle.BackgroundImage")));
            this.btn_turModelEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_turModelEkle.Location = new System.Drawing.Point(792, 230);
            this.btn_turModelEkle.Name = "btn_turModelEkle";
            this.btn_turModelEkle.Size = new System.Drawing.Size(98, 41);
            this.btn_turModelEkle.TabIndex = 10;
            this.btn_turModelEkle.UseVisualStyleBackColor = true;
            this.btn_turModelEkle.Click += new System.EventHandler(this.btn_turModelEkle_Click);
            // 
            // btn_turModelGüncelle
            // 
            this.btn_turModelGüncelle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_turModelGüncelle.BackgroundImage")));
            this.btn_turModelGüncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_turModelGüncelle.Location = new System.Drawing.Point(792, 281);
            this.btn_turModelGüncelle.Name = "btn_turModelGüncelle";
            this.btn_turModelGüncelle.Size = new System.Drawing.Size(101, 44);
            this.btn_turModelGüncelle.TabIndex = 11;
            this.btn_turModelGüncelle.UseVisualStyleBackColor = true;
            this.btn_turModelGüncelle.Click += new System.EventHandler(this.btn_turModelGüncelle_Click);
            // 
            // btn_turModelSil
            // 
            this.btn_turModelSil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_turModelSil.BackgroundImage")));
            this.btn_turModelSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_turModelSil.Location = new System.Drawing.Point(792, 337);
            this.btn_turModelSil.Name = "btn_turModelSil";
            this.btn_turModelSil.Size = new System.Drawing.Size(101, 36);
            this.btn_turModelSil.TabIndex = 12;
            this.btn_turModelSil.UseVisualStyleBackColor = true;
            this.btn_turModelSil.Click += new System.EventHandler(this.btn_turModelSil_Click);
            // 
            // cbx_turPaketAdi
            // 
            this.cbx_turPaketAdi.FormattingEnabled = true;
            this.cbx_turPaketAdi.Location = new System.Drawing.Point(111, 119);
            this.cbx_turPaketAdi.Name = "cbx_turPaketAdi";
            this.cbx_turPaketAdi.Size = new System.Drawing.Size(121, 21);
            this.cbx_turPaketAdi.TabIndex = 13;
            // 
            // btn_TTMCikis
            // 
            this.btn_TTMCikis.Location = new System.Drawing.Point(895, 3);
            this.btn_TTMCikis.Name = "btn_TTMCikis";
            this.btn_TTMCikis.Size = new System.Drawing.Size(26, 23);
            this.btn_TTMCikis.TabIndex = 14;
            this.btn_TTMCikis.Text = " X";
            this.btn_TTMCikis.UseVisualStyleBackColor = true;
            this.btn_TTMCikis.Click += new System.EventHandler(this.btn_TTMCikis_Click);
            // 
            // btn_turPaketSayfasınaGec
            // 
            this.btn_turPaketSayfasınaGec.Location = new System.Drawing.Point(752, 4);
            this.btn_turPaketSayfasınaGec.Name = "btn_turPaketSayfasınaGec";
            this.btn_turPaketSayfasınaGec.Size = new System.Drawing.Size(141, 23);
            this.btn_turPaketSayfasınaGec.TabIndex = 15;
            this.btn_turPaketSayfasınaGec.Text = "Tur Paket Sayfasına Geç";
            this.btn_turPaketSayfasınaGec.UseVisualStyleBackColor = true;
            this.btn_turPaketSayfasınaGec.Click += new System.EventHandler(this.btn_turPaketSayfasınaGec_Click);
            // 
            // cms_TurModeliForm
            // 
            this.cms_TurModeliForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turModeliniEkleToolStripMenuItem,
            this.turModeliniGuncelleToolStripMenuItem,
            this.turModeliniSilToolStripMenuItem,
            this.turPaketSayfasinaGecToolStripMenuItem,
            this.sayfayiKapatToolStripMenuItem});
            this.cms_TurModeliForm.Name = "cms_TurModeliForm";
            this.cms_TurModeliForm.Size = new System.Drawing.Size(199, 114);
            // 
            // turModeliniEkleToolStripMenuItem
            // 
            this.turModeliniEkleToolStripMenuItem.Name = "turModeliniEkleToolStripMenuItem";
            this.turModeliniEkleToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.turModeliniEkleToolStripMenuItem.Text = "Tur Modelini Ekle";
            this.turModeliniEkleToolStripMenuItem.Click += new System.EventHandler(this.btn_turModelEkle_Click);
            // 
            // turModeliniGuncelleToolStripMenuItem
            // 
            this.turModeliniGuncelleToolStripMenuItem.Name = "turModeliniGuncelleToolStripMenuItem";
            this.turModeliniGuncelleToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.turModeliniGuncelleToolStripMenuItem.Text = "Tur Modelini Güncelle";
            this.turModeliniGuncelleToolStripMenuItem.Click += new System.EventHandler(this.btn_turModelGüncelle_Click);
            // 
            // turModeliniSilToolStripMenuItem
            // 
            this.turModeliniSilToolStripMenuItem.Name = "turModeliniSilToolStripMenuItem";
            this.turModeliniSilToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.turModeliniSilToolStripMenuItem.Text = "Tur Modelini Sil";
            this.turModeliniSilToolStripMenuItem.Click += new System.EventHandler(this.btn_turModelSil_Click);
            // 
            // turPaketSayfasinaGecToolStripMenuItem
            // 
            this.turPaketSayfasinaGecToolStripMenuItem.Name = "turPaketSayfasinaGecToolStripMenuItem";
            this.turPaketSayfasinaGecToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.turPaketSayfasinaGecToolStripMenuItem.Text = "Tur Paket Sayfasına Geç";
            this.turPaketSayfasinaGecToolStripMenuItem.Click += new System.EventHandler(this.btn_turPaketSayfasınaGec_Click);
            // 
            // sayfayiKapatToolStripMenuItem
            // 
            this.sayfayiKapatToolStripMenuItem.Name = "sayfayiKapatToolStripMenuItem";
            this.sayfayiKapatToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.sayfayiKapatToolStripMenuItem.Text = "Sayfayı Kapat";
            this.sayfayiKapatToolStripMenuItem.Click += new System.EventHandler(this.btn_TTMCikis_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Yellow;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(9, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(255, 25);
            this.label11.TabIndex = 36;
            this.label11.Text = "Tur Tür Modeli Belirleme ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "YurtDışı Tur Oluştur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yurtİçi Tur Oluştur";
            // 
            // cbx_yurtIciTur
            // 
            this.cbx_yurtIciTur.FormattingEnabled = true;
            this.cbx_yurtIciTur.Location = new System.Drawing.Point(47, 67);
            this.cbx_yurtIciTur.Name = "cbx_yurtIciTur";
            this.cbx_yurtIciTur.Size = new System.Drawing.Size(121, 21);
            this.cbx_yurtIciTur.TabIndex = 3;
            // 
            // cbx_yurtDisiTur
            // 
            this.cbx_yurtDisiTur.FormattingEnabled = true;
            this.cbx_yurtDisiTur.Location = new System.Drawing.Point(189, 67);
            this.cbx_yurtDisiTur.Name = "cbx_yurtDisiTur";
            this.cbx_yurtDisiTur.Size = new System.Drawing.Size(121, 21);
            this.cbx_yurtDisiTur.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Yellow;
            this.groupBox1.Controls.Add(this.cbx_yurtDisiTur);
            this.groupBox1.Controls.Add(this.cbx_yurtIciTur);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(327, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 120);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tur Modelini Seçiniz : ";
            // 
            // TurunTurModeli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(924, 385);
            this.ContextMenuStrip = this.cms_TurModeliForm;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_turPaketSayfasınaGec);
            this.Controls.Add(this.btn_TTMCikis);
            this.Controls.Add(this.cbx_turPaketAdi);
            this.Controls.Add(this.btn_turModelSil);
            this.Controls.Add(this.btn_turModelGüncelle);
            this.Controls.Add(this.btn_turModelEkle);
            this.Controls.Add(this.dgv_turTurKayitlari);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tx_turAd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "TurunTurModeli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TurunTurModeli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TurunTurModeli_FormClosing);
            this.Load += new System.EventHandler(this.TurunTurModeli_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TurunTurModeli_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_turTurKayitlari)).EndInit();
            this.cms_TurModeliForm.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tx_turAd;
        private System.Windows.Forms.DataGridView dgv_turTurKayitlari;
        private System.Windows.Forms.Button btn_turModelEkle;
        private System.Windows.Forms.Button btn_turModelGüncelle;
        private System.Windows.Forms.Button btn_turModelSil;
        private System.Windows.Forms.ComboBox cbx_turPaketAdi;
        private System.Windows.Forms.Button btn_TTMCikis;
        private System.Windows.Forms.Button btn_turPaketSayfasınaGec;
        private System.Windows.Forms.ContextMenuStrip cms_TurModeliForm;
        private System.Windows.Forms.ToolStripMenuItem turModeliniEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turModeliniGuncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turModeliniSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turPaketSayfasinaGecToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sayfayiKapatToolStripMenuItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_yurtIciTur;
        private System.Windows.Forms.ComboBox cbx_yurtDisiTur;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}