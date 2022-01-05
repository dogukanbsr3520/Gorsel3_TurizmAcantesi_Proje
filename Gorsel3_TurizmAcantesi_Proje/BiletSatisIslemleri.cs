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
    public partial class BiletSatisIslemleri : Form
    {
        public BiletSatisIslemleri()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
       
        private void BiletSatisIslemleri_Load(object sender, EventArgs e)
        {
            dgv_biletSatisIslemleriKayitlari.DataSource = vt.Select(@"select bs.musteri_id,bt.biletTur_id, bs.biletSatis_id,m.ad,m.soyad,m.telefon,biletTutar,bt.turAd
                                                                    from tbl_biletSatis bs
                                                                    join tbl_musteri m on bs.musteri_id = m.musteri_id
                                                                    join tbl_biletTur bt on bs.biletTur_id = bt.biletTur_id");

            dgv_biletSatisIslemleriKayitlari.Columns[0].Visible = false;
            dgv_biletSatisIslemleriKayitlari.Columns[1].Visible = false;
            dgv_biletSatisIslemleriKayitlari.Columns[2].Visible = false;

            cbx_biletTurSec.DisplayMember = "turAd";
            cbx_biletTurSec.ValueMember = "biletTur_id";
            cbx_biletTurSec.DataSource = vt.Select("select biletTur_id,turAd from tbl_biletTur");

            cbx_musteriDoldur();
        }


        private void cbx_musteriDoldur()
        {
            string musteriKaydiAra = tx_musteriKayitAra.Text == "Kayıt ara..." ? "" : tx_musteriKayitAra.Text;
            cbx_musteriBilg.DisplayMember = "musteri";
            cbx_musteriBilg.ValueMember = "musteri_id";
            cbx_musteriBilg.DataSource = vt.Select("select musteri_id, telefon +' - '+ad+' '+soyad musteri from tbl_musteri where telefon +' - '+ad+' '+soyad like '%" + musteriKaydiAra + "%'"); 
        }


        private void btn_biletKes_Click(object sender, EventArgs e)
        {
           if(cbx_musteriBilg.SelectedIndex==-1)
            {
                MessageBox.Show("Müşteri Bilgilerini Seçiniz !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_biletTutar.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bilet Tutar alanı boş bırakılmamalıdır.!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbx_biletTurSec.SelectedIndex==-1)
            {
                MessageBox.Show("Bilet Türü Seçiniz !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          

            int kayitSay = vt.UpdateDelete("insert into tbl_biletSatis(musteri_id,biletTutar,biletTur_id)values('"+cbx_musteriBilg.SelectedValue+"', '"+tx_biletTutar.Text+"', '"+cbx_biletTurSec.SelectedValue+"')");
            if (kayitSay > 0)
            {
                BiletSatisIslemleri_Load(null, null);
                MessageBox.Show("Bilet Satış işlemi Başarıyla Gerçekleşti");
            }
        }

        private void cbx_musteriBilg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_musteriBilg.SelectedIndex == -1)
                return;

            cbx_musteriBilg.DataSource = vt.Select("select musteri_id, telefon +' - '+ad+' '+soyad musteri from tbl_musteri where musteri_id="+cbx_musteriBilg.SelectedValue);

            cbx_musteriBilg.DisplayMember = "musteri";
            cbx_musteriBilg.ValueMember = "musteri_id";
        }

        private void tx_musteriKayitAra_TextChanged(object sender, EventArgs e)
        {
            cbx_musteriDoldur();
        }

        private void tx_musteriKayitAra_Enter(object sender, EventArgs e)
        {
            if (tx_musteriKayitAra.Text == "Kayıt ara...")
            {
                tx_musteriKayitAra.Text = "";
                tx_musteriKayitAra.ForeColor = Color.Black;
            }
        }

        private void tx_musteriKayitAra_Leave(object sender, EventArgs e)
        {
            if (tx_musteriKayitAra.Text == "")
            {
                tx_musteriKayitAra.Text = "Kayıt ara...";
                tx_musteriKayitAra.ForeColor = Color.DarkGray;
            }
        }

        private void btn_biletGüncelle_Click(object sender, EventArgs e)
        {

            if (cbx_musteriBilg.SelectedIndex == -1)
            {
                MessageBox.Show("Müşteri Bilgilerini Seçiniz !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbx_biletTurSec.SelectedIndex == -1)
            {
                MessageBox.Show("Bilet Türü Seçiniz !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (dgv_biletSatisIslemleriKayitlari.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncelleme işlemini gerçekleştirebilmek için bir satır seçmelisiniz ! ", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(dgv_biletSatisIslemleriKayitlari.SelectedRows.Count>1)
            {
                MessageBox.Show("Güncelleme işleminde sadece 1 satır seçili olmalıdır ! ", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_biletSatis
                                            set musteri_id='" + cbx_musteriBilg.SelectedValue + @"',
                                            biletTutar='" + tx_biletTutar.Text + @"',
                                            biletTur_id='" + cbx_biletTurSec.SelectedValue + @"'
                                            where biletSatis_id=" + dgv_biletSatisIslemleriKayitlari.SelectedRows[0].Cells["biletSatis_id"].Value);

            if (kayitSay > 0)
            {
                BiletSatisIslemleri_Load(null, null);
                MessageBox.Show("Bilet Kaydı Başarıyla Güncellendi");
            }
        }

        private void btn_biletKaydiSil_Click(object sender, EventArgs e)
        {
            if (dgv_biletSatisIslemleriKayitlari.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek Satırı Seçiniz!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete("delete from tbl_biletSatis where biletSatis_id=" + dgv_biletSatisIslemleriKayitlari.SelectedRows[0].Cells["biletSatis_id"].Value);
            if (kayitSay > 0)
            {
                BiletSatisIslemleri_Load(null, null);
                MessageBox.Show("Seçili Bilet Kaydı Silindi ! ");
            }
        }

        private void dgv_biletSatisIslemleriKayitlari_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_biletSatisIslemleriKayitlari.SelectedRows.Count == 0)
            {
                return;
            }
            cbx_musteriBilg.SelectedValue = dgv_biletSatisIslemleriKayitlari.SelectedRows[0].Cells["musteri_id"].Value.ToString();
            tx_biletTutar.Text = dgv_biletSatisIslemleriKayitlari.SelectedRows[0].Cells["biletTutar"].Value.ToString();
            cbx_biletTurSec.SelectedValue = dgv_biletSatisIslemleriKayitlari.SelectedRows[0].Cells["biletTur_id"].Value.ToString();

        }

        private void btn_biletKaydiTemizle_Click(object sender, EventArgs e)
        {
            cbx_musteriBilg.SelectedValue = -1;
            tx_biletTutar.Text = "";
            cbx_biletTurSec.SelectedValue = -1;

            foreach (DataGridViewRow item in dgv_biletSatisIslemleriKayitlari.SelectedRows)
            {
                item.Selected = false;
            }
        }

        private void BiletSatisIslemleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
                Masaustu mfrm = (Masaustu)this.MdiParent;
                mfrm.tsbtn_biletSatis.Enabled = true;
            
        }

        private void btn_BSICikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BiletSatisIslemleri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.K)//'kind'-tür
            {
                btn_biletTurSayfaDon_Click(sender, e);
            }
        }

        private void btn_biletTurSayfaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            BiletTurSec btsfrm = new BiletTurSec();
            btsfrm.MdiParent = this.MdiParent;

            btsfrm.Show();
            return;
        }
    }
}
