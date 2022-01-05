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
    public partial class BiletTurSec : Form
    {
        public BiletTurSec()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
     

        private void BiletTurSec_Load(object sender, EventArgs e)
        {
            dgv_biletTurKayitlari.DataSource = vt.Select("select biletTur_id,turNo,turAd from tbl_biletTur");

            dgv_biletTurKayitlari.Columns[0].Visible = false;
           

        }

        private void btn_biletTurEkle_Click(object sender, EventArgs e)
        {
            if(tx_biletTurNo.Text.Trim().Length==0)
            {
                MessageBox.Show("Bilet Tür No alanı boş bırakılmamalıdır !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_biletTurAd.Text.Trim().Length==0)
            {
                MessageBox.Show("Bilet Tür Ad alanı boş bırakılmamalıdır !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(tx_biletTurAd.Text.Trim().Length<4)
            {
                MessageBox.Show("Bilet Tür adı en az 4 karakterden oluşmalıdır !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
         
            int kayitSay = vt.UpdateDelete("insert into tbl_biletTur(turNo,turAd)values('" + tx_biletTurNo.Text + "', '" + tx_biletTurAd.Text + "')");
            if (kayitSay > 0)
            {
                BiletTurSec_Load(null, null);
                MessageBox.Show("Yeni Bilet Tür Kaydı Eklendi.");
            }
        }

        private void btn_biletTurGuncelle_Click(object sender, EventArgs e)
        {
            if(dgv_biletTurKayitlari.SelectedRows.Count>1)
            {
                MessageBox.Show("Güncelleme işleminde sadece 1 satır seçili olmalıdır ! ", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgv_biletTurKayitlari.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncelleme işlemini gerçekleştirebilmek için bir satır seçmelisiniz !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_biletTur
                                            set turNo='" + tx_biletTurNo.Text + @"',
                                            turAd='" + tx_biletTurAd.Text + @"'
                                            where biletTur_id=" + dgv_biletTurKayitlari.SelectedRows[0].Cells["biletTur_id"].Value);

            if (kayitSay > 0)
            {
                BiletTurSec_Load(null, null);
                MessageBox.Show("Seçili Bilet Tür Kaydı Güncellendi");
            }
            else
            {
                MessageBox.Show(" Güncelleme işlemi gerçekleşemedi...");
            }
        }

        private void btn_türSil_Click(object sender, EventArgs e)
        {
            if (dgv_biletTurKayitlari.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek Satırı Seçiniz!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete("delete from tbl_biletTur where biletTur_id=" + dgv_biletTurKayitlari.SelectedRows[0].Cells["biletTur_id"].Value);
            if (kayitSay > 0)
            {
                BiletTurSec_Load(null, null);
                MessageBox.Show("Seçili Bilet Tür Kaydı Silindi !");
            }
            else
            {
                MessageBox.Show("Silme işlemi gerçekleşemedi...", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_biletTurKayitlari_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_biletTurKayitlari.SelectedRows.Count == 0)
            {
                return;
            }
            tx_biletTurNo.Text = dgv_biletTurKayitlari.SelectedRows[0].Cells["turNo"].Value.ToString();
            tx_biletTurAd.Text = dgv_biletTurKayitlari.SelectedRows[0].Cells["turAd"].Value.ToString();
        }

        private void BiletTurSec_FormClosing(object sender, FormClosingEventArgs e)
        {
            Masaustu mfrm = (Masaustu)this.MdiParent;
            mfrm.tsbtn_biletTur.Enabled = true;
        }

        private void btn_BTSCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_biletSatisSayfaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            BiletSatisIslemleri bsifrm = new BiletSatisIslemleri();
            bsifrm.MdiParent = this.MdiParent;

            bsifrm.Show();
            return;
        }

        private void BiletTurSec_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.S)//'Sell'-tür
            {
                btn_biletSatisSayfaDon_Click(sender, e);
            }
        }
    }
}
