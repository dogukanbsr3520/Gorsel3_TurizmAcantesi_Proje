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
    public partial class TurPaketleri : Form
    {
        public TurPaketleri()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void TurPaketleri_Load(object sender, EventArgs e)
        {
            dgv_turPaketKayitlari.DataSource = vt.Select(@"select turPaket_id,paketAd,gecerlilikSure,h.hizmetAd,k.konaklamaAd 
                                                            from tbl_turPaket tp
                                                            join tbl_hizmetler h on tp.hizmet_id=h.hizmet_id
                                                            join tbl_konaklama k on tp.konaklama_id=k.konaklama_id");

            dgv_turPaketKayitlari.Columns[0].Visible = false;

            cbx_hizmetTurSecimi.DisplayMember = "hizmetAd";
            cbx_hizmetTurSecimi.ValueMember = "hizmet_id";
            cbx_hizmetTurSecimi.DataSource = vt.Select("select hizmet_id,hizmetAd from tbl_hizmetler");

            cbx_konaklamaTurSecimi.DisplayMember = "konaklamaAd";
            cbx_konaklamaTurSecimi.ValueMember = "konaklama_id";
            cbx_konaklamaTurSecimi.DataSource = vt.Select("select konaklama_id,konaklamaAd from tbl_konaklama");

        }

        private void btn_turPaketEkle_Click(object sender, EventArgs e)
        {
            if (tx_paketAdOlustur.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tur paket Adı boş bırakılmamalıdır.!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_paketAdOlustur.Text.Trim().Length < 10)
            {
                MessageBox.Show("Girilen paket adı en az 10 karakter boyuta sahip olabilir !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbx_hizmetTurSecimi.SelectedIndex == -1) 
            {
                MessageBox.Show("Hizmet Tür'ünü Seçmelisiniz !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbx_konaklamaTurSecimi.SelectedIndex == -1)
            {
                MessageBox.Show("Konaklama Tür'ünü Seçmelisiniz !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int kayitSay = vt.UpdateDelete("insert into tbl_turPaket(paketAd,gecerlilikSure,hizmet_id,konaklama_id)values('" + tx_paketAdOlustur.Text + "', '" + this.dtp_gecerlilikSuresi.Text + "', '" + cbx_hizmetTurSecimi.SelectedValue + "', '" + cbx_konaklamaTurSecimi.SelectedValue + "')");
            if (kayitSay > 0)
            {
                TurPaketleri_Load(null, null);
                MessageBox.Show("Yeni Tur Paketi Sisteme Eklendi.");
            }
        }

        private void btn_turPaketGuncelle_Click(object sender, EventArgs e)
        {
            if (dgv_turPaketKayitlari.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncelleme işlemini gerçekleştirebilmek için bir satır seçmelisiniz !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgv_turPaketKayitlari.SelectedRows.Count > 1)
            {
                MessageBox.Show("Güncelleme işleminde sadece 1 satır seçili olmalıdır !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_turPaket
                                            set paketAd='" + tx_paketAdOlustur.Text + @"',
                                            gecerlilikSure='" + dtp_gecerlilikSuresi.Value.ToShortDateString() + @"',
                                            hizmet_id='" + cbx_hizmetTurSecimi.SelectedValue + @"',
                                            konaklama_id='" + cbx_konaklamaTurSecimi.SelectedValue + @"'
                                            where turPaket_id=" + dgv_turPaketKayitlari.SelectedRows[0].Cells["turPaket_id"].Value);

            if (kayitSay > 0)
            {
                TurPaketleri_Load(null,null);
                MessageBox.Show("Tur Paket Bilgiler Başarılı Bir Şekilde Güncellendi...");
            }
        }

        private void btn_turPaketSil_Click(object sender, EventArgs e)
        {
            if (dgv_turPaketKayitlari.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silme İşlemi İçin Öncellikle Satır Seçilmelidir.", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete("delete from tbl_turPaket where turPaket_id=" + dgv_turPaketKayitlari.SelectedRows[0].Cells["turPaket_id"].Value);
            if (kayitSay > 0)
            {
                TurPaketleri_Load(null,null);
                MessageBox.Show("Tur Paket Kaydı Silindi!");
            }

        }

        private void btn_masaustuGeriDonus_Click(object sender, EventArgs e)
        {
            this.Hide();
            Masaustu Mfrm = new Masaustu();

            Mfrm.Show();
            return;
        }

        private void TurPaketleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Masaustu mfrm = (Masaustu)this.MdiParent;
            mfrm.tsbtn_turPaket.Enabled = true;
        }

        private void btn_TPCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_turTurSayfasinaGec_Click(object sender, EventArgs e)
        {
            this.Hide();
            TurunTurModeli ttmfrm = new TurunTurModeli();
            ttmfrm.MdiParent = this.MdiParent;

            ttmfrm.Show();
            return;
        }

        private void TurPaketleri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.T)//T - Tur (T)ürü
            {
                btn_turTurSayfasinaGec_Click(sender, e);
            }
        }
    }
}
