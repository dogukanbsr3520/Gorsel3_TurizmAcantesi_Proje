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
    public partial class RezervasyonIslemleri : Form
    {
        public RezervasyonIslemleri()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
       
        private void RezervasyonIslemleri_Load(object sender, EventArgs e)
        {
            dgv_rezervasyonKayitlari.DataSource = vt.Select(@"select rezervasyon_id,rezervasyonAd,baslangicTarihi,bitisTarihi,tt.turAd 
                                                            from tbl_Rezervasyon r
                                                            join tbl_turTur tt on r.turTur_id=tt.turTur_id");

            dgv_rezervasyonKayitlari.Columns[0].Visible = false;

            cbx_turAdiSec.DisplayMember = "turAd";
            cbx_turAdiSec.ValueMember = "turTur_id";
            cbx_turAdiSec.DataSource = vt.Select("select turTur_id,turAd from tbl_turTur");

        }

        private void btn_rezervasyonEkle_Click(object sender, EventArgs e)
        {
            if (tx_rezervasyonAdGirdi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Rezervasyon Adı boş bırakılmamalıdır.!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_rezervasyonAdGirdi.Text.Trim().Length < 10) 
            {
                MessageBox.Show("Rezervasyon adı en az 10 karakter boyuta sahip olabilir !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbx_turAdiSec.SelectedIndex == -1) 
            {
                MessageBox.Show("Tur adını seçmelisiniz !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            int kayitSay = vt.UpdateDelete("insert into tbl_Rezervasyon(rezervasyonAd,baslangicTarihi,bitisTarihi,turTur_id)values('"+tx_rezervasyonAdGirdi.Text+"', '"+this.dtp_rezervasyonBaslangicTarih.Text+"', '"+this.dtp_rezervasyonBitisTarih.Text+ "', '"+cbx_turAdiSec.SelectedValue+"')");
            if (kayitSay > 0)
            {
                RezervasyonIslemleri_Load(null, null);
                MessageBox.Show("Rezervasyon Kaydı Sisteme Eklendi.");
            }
        }

        private void btn_rezervasyonGüncelle_Click(object sender, EventArgs e)
        {
            if(dgv_rezervasyonKayitlari.SelectedRows.Count==0)
            {
                MessageBox.Show("Güncelleme işlemini gerçekleştirebilmek için bir satır seçmelisiniz !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgv_rezervasyonKayitlari.SelectedRows.Count > 1)
            {
                MessageBox.Show("Güncelleme işleminde sadece 1 satır seçili olmalıdır ! ", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_Rezervasyon
                                            set rezervasyonAd='" + tx_rezervasyonAdGirdi.Text + @"',
                                            baslangicTarihi='" + dtp_rezervasyonBaslangicTarih.Value.ToShortDateString() + @"',
                                            bitisTarihi='" + dtp_rezervasyonBitisTarih.Value.ToShortDateString() + @"',
                                            turTur_id='" + cbx_turAdiSec.SelectedValue + @"'
                                            where rezervasyon_id=" + dgv_rezervasyonKayitlari.SelectedRows[0].Cells["rezervasyon_id"].Value);

            if (kayitSay > 0)
            {
                RezervasyonIslemleri_Load(null,null);
                MessageBox.Show("Rezervasyon Kaydı Başarılı Bir Şekilde Güncellendi...");
            }
        }

        private void btn_rezervasyonSil_Click(object sender, EventArgs e)
        {
            if (dgv_rezervasyonKayitlari.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek Satırı Seçiniz!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete("delete from tbl_Rezervasyon where rezervasyon_id=" + dgv_rezervasyonKayitlari.SelectedRows[0].Cells["rezervasyon_id"].Value);
            if (kayitSay > 0) 
            {
                RezervasyonIslemleri_Load(null,null);
                MessageBox.Show("Rezervasyon Kaydı Silindi !");
            }
        }

        private void btn_rezervasyonKayidAlanTemizle_Click(object sender, EventArgs e)
        {
           
            tx_rezervasyonAdGirdi.Text = "";
            cbx_turAdiSec.SelectedIndex = -1;
           

            foreach (DataGridViewRow item in dgv_rezervasyonKayitlari.SelectedRows)
            {
                item.Selected = false;
            }
        }

        private void dgv_rezervasyonKayitlari_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_rezervasyonKayitlari.SelectedRows.Count == 0)
            {
                return;
            }
            tx_rezervasyonAdGirdi.Text = dgv_rezervasyonKayitlari.SelectedRows[0].Cells["rezervasyonAd"].Value.ToString();
            //cbx_turAdiSec.SelectedValue = dgv_rezervasyonKayitlari.SelectedRows[0].Cells["turAd"].Value;
        }

        private void RezervasyonIslemleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Masaustu mfrm = (Masaustu)this.MdiParent;
            mfrm.tsbtn_rezervasyon.Enabled = true;

        }

        private void btn_RCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_musteriSayfaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            MusteriIslemleri mifrm = new MusteriIslemleri();
            mifrm.MdiParent = this.MdiParent;

            mifrm.Show();
            return;
        }

        private void RezervasyonIslemleri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.M)//M - Müşteri
            {
                btn_musteriSayfaDon_Click(sender, e);
            }
        }
    }
}
