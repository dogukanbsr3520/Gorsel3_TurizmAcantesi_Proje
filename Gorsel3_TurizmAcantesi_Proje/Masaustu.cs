using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gorsel3_TurizmAcantesi_Proje
{
    public partial class Masaustu : Form
    {
        public Masaustu()
        {
            InitializeComponent();
        }

        private void Masaustu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
       

        private void tslbl_uygulamaKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Masaustu_Load(object sender, EventArgs e)
        {
            timerSure_saatTarih.Start();
            label11.Text = DateTime.Now.ToLongTimeString();
            label13.Text = DateTime.Now.ToShortDateString();

            toolStripMenu.Text= DateTime.Now.ToLongTimeString();


        }

        private void timerSure_saatTarih_Tick(object sender, EventArgs e)
        {
            label11.Text = DateTime.Now.ToLongTimeString();
            timerSure_saatTarih.Start();

            toolStripMenu.Text = DateTime.Now.ToLongTimeString();
            timerSure_saatTarih.Start();
        }

        private void tsbtn_musteriIslemleri_Click(object sender, EventArgs e)
        {

      
            if (tsbtn_musteriIslemleri.Enabled == false)
                return;
            MusteriIslemleri mifrm = new MusteriIslemleri();
            mifrm.MdiParent = this;
            tsbtn_musteriIslemleri.Enabled = false;
            mifrm.Show();
        }


        private void tsbtn_biletSatis_Click(object sender, EventArgs e)
        {
            if (tsbtn_biletSatis.Enabled == false)
                return;
            BiletSatisIslemleri bsifrm = new BiletSatisIslemleri();
            bsifrm.MdiParent = this;
            tsbtn_biletSatis.Enabled = false;
            bsifrm.Show();
        }

        private void tsbtn_rezervasyon_Click(object sender, EventArgs e)
        {
            if (tsbtn_rezervasyon.Enabled == false)
                return;
            RezervasyonIslemleri rnifrm = new RezervasyonIslemleri();
            rnifrm.MdiParent = this;
            tsbtn_rezervasyon.Enabled = false;
            rnifrm.Show();
        }

        private void tsbtn_turPaket_Click(object sender, EventArgs e)
        {
            if (tsbtn_turPaket.Enabled == false)
                return;
            TurPaketleri tpfrm = new TurPaketleri();
            tpfrm.MdiParent = this;
            tsbtn_turPaket.Enabled = false;
            tpfrm.Show();
        }

        private void tsbtn_hizmetler_Click(object sender, EventArgs e)
        {
            if (tsbtn_hizmetler.Enabled == false)
                return;
            Hizmetler hrfrm = new Hizmetler();
            hrfrm.MdiParent = this;
            tsbtn_hizmetler.Enabled = false;
            hrfrm.Show();
        }

        private void tsbtn_konaklama_Click(object sender, EventArgs e)
        {
            if (tsbtn_konaklama.Enabled == false)
                return;
            Konaklama kfrm = new Konaklama();
            kfrm.MdiParent = this;
            tsbtn_konaklama.Enabled = false;
            kfrm.Show();
        }

        private void tsbtn_biletTur_Click(object sender, EventArgs e)
        {
            if (tsbtn_biletTur.Enabled == false)
                return;
            BiletTurSec btfrm = new BiletTurSec();
            btfrm.MdiParent = this;
            tsbtn_biletTur.Enabled = false;
            btfrm.Show();
        }

        private void tsbtn_turTur_Click(object sender, EventArgs e)
        {
            if (tsbtn_turTur.Enabled == false)
                return;
            TurunTurModeli ttmfrm = new TurunTurModeli();
            ttmfrm.MdiParent = this;
            tsbtn_turTur.Enabled = false;
            ttmfrm.Show();
        }

        private void tsbtn_yurticiTur_Click(object sender, EventArgs e)
        {
            if (tsbtn_yurticiTur.Enabled == false)
                return;
            YurticiTurAyarlama yitfrm = new YurticiTurAyarlama();
            yitfrm.MdiParent = this;
            tsbtn_yurticiTur.Enabled = false;
            yitfrm.Show();
        }

        private void tsbtn_yurtDısıTur_Click(object sender, EventArgs e)
        {
            if (tsbtn_yurtDısıTur.Enabled == false)
                return;
            YurtDisiTurAyarlama ydtfrm = new YurtDisiTurAyarlama();
            ydtfrm.MdiParent = this;
            tsbtn_yurtDısıTur.Enabled = false;
            ydtfrm.Show();
        }

        private void tsbtn_adresBilg_Click(object sender, EventArgs e)
        {
            if (tsbtn_adresBilg.Enabled == false)
                return;
            AdresBilgileri abfrm = new AdresBilgileri();
            abfrm.MdiParent = this;
            tsbtn_adresBilg.Enabled = false;
            abfrm.Show();
        }

        private void btn_MasaustuKucult_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void tsbtn_yoneticiKontrolPanel_Click(object sender, EventArgs e)
        {
            if (tsbtn_yoneticiKontrolPanel.Enabled == false)
                return;
            YoneticiKontrolPanel ykpfrm = new YoneticiKontrolPanel();
            ykpfrm.MdiParent = this;
            tsbtn_yoneticiKontrolPanel.Enabled = false;
            ykpfrm.Show();
        }

        private void notifyIconTaskBar_DoubleClick(object sender, EventArgs e)
        {
            if (this.Visible == false)
                this.Show();
            else
                this.Hide();
        }

        private void turizmAcentasıUygulamaGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void turizmAcentasıUygulamaGizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void turizmAcentasıUygulamaKapatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
