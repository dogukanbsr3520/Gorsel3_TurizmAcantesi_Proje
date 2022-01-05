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
    public partial class TurunTurModeli : Form
    {
        public TurunTurModeli()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        private void TurunTurModeli_Load(object sender, EventArgs e)
        {
            dgv_turTurKayitlari.DataSource = vt.Select(@"select turTur_id, tt.turAd,yit.yurticiTurAdi,ydt.yurtDisiTurAdi,tp.paketAd
                                                        from tbl_turTur tt
                                                        join tbl_turPaket tp on tp.turPaket_id = tt.turPaket_id
                                                        join tbl_yurticiTurTur yit on yit.yurticiTurTur_id = tt.yurticiTurTur_id
                                                        join tbl_yurtdisiTurTur ydt on ydt.yurtdisiTurTur_id = tt.yurtdisiTurTur_id");

            dgv_turTurKayitlari.Columns[0].Visible = false;

            cbx_yurtIciTur.DisplayMember = "yurticiTurAdi";
            cbx_yurtIciTur.ValueMember = "yurticiTurTur_id";
            cbx_yurtIciTur.DataSource = vt.Select("select yurticiTurTur_id,yurticiTurAdi from tbl_yurticiTurTur");

            cbx_yurtDisiTur.DisplayMember = "yurtDisiTurAdi";
            cbx_yurtDisiTur.ValueMember = "yurtdisiTurTur_id";
            cbx_yurtDisiTur.DataSource = vt.Select("select yurtdisiTurTur_id,yurtDisiTurAdi from tbl_yurtdisiTurTur");


            cbx_turPaketAdi.DisplayMember = "paketAd";
            cbx_turPaketAdi.ValueMember = "turpaket_id";
            cbx_turPaketAdi.DataSource = vt.Select("select turPaket_id,paketAd from tbl_turPaket");

        }

        private void btn_turModelEkle_Click(object sender, EventArgs e)
        {
            if(tx_turAd.Text.Trim().Length==0)
            {
                MessageBox.Show("Tür Ad alanı boş bırakılmamalıdır!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(tx_turAd.Text.Trim().Length<10)
            {
                MessageBox.Show("Tür Ad'ı en az 10 karakterden oluşmalıdır !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(cbx_yurtIciTur.SelectedIndex==-1)
            {
                MessageBox.Show("Yurt İçi Tur'u seçiniz", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(cbx_yurtDisiTur.SelectedIndex==-1)
            {
                MessageBox.Show("Yurt Dışı Tur'u seçiniz", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(cbx_turPaketAdi.SelectedIndex==-1)
            {
                MessageBox.Show("Tur'a ait Paket adı'nı seçiniz", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete("insert into tbl_turTur(turAd,yurticiTurTur_id,yurtdisiTurTur_id,turPaket_id)values('"+tx_turAd.Text+"', '"+cbx_yurtIciTur.SelectedValue+"', '"+cbx_yurtDisiTur.SelectedValue+"', '"+cbx_turPaketAdi.SelectedValue+"')");
            if (kayitSay > 0)
            {
                TurunTurModeli_Load(null, null);
                MessageBox.Show("Yeni TurTür modeli eklendi.");
            }
        }

        private void btn_turModelGüncelle_Click(object sender, EventArgs e)
        {
            if (dgv_turTurKayitlari.SelectedRows.Count > 1) 
            {
                MessageBox.Show("Güncelleme işleminde sadece 1 satır seçili olmalıdır !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgv_turTurKayitlari.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncellemek İstediğiniz satıra seçiniz !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_turTur
                                            set turAd='" + tx_turAd.Text + @"',
                                            yurticiTurTur_id='" + cbx_yurtIciTur.SelectedValue + @"',
                                            yurtdisiTurTur_id='" + cbx_yurtDisiTur.SelectedValue + @"',
                                            turPaket_id='" + cbx_turPaketAdi.SelectedValue + @"'
                                            where turTur_id=" + dgv_turTurKayitlari.SelectedRows[0].Cells["turTur_id"].Value);

            if (kayitSay > 0)
            {
                TurunTurModeli_Load(null, null);
                MessageBox.Show("Seçilen Turun Tür Modeli Güncellendi. ");
            }
        }

        private void btn_turModelSil_Click(object sender, EventArgs e)
        {
            if (dgv_turTurKayitlari.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek Satırı Seçiniz!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete("delete from tbl_turTur where turTur_id=" + dgv_turTurKayitlari.SelectedRows[0].Cells["turTur_id"].Value);
            if (kayitSay > 0)
            {
                TurunTurModeli_Load(null, null);
                MessageBox.Show("Seçilen Tur Modeli Silindi !");
            }
        }

        private void dgv_turTurKayitlari_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_turTurKayitlari.SelectedRows.Count == 0)
            {
                return;

            }
            tx_turAd.Text = dgv_turTurKayitlari.SelectedRows[0].Cells["turAd"].Value.ToString();
            //cbx_yurtIciTur.SelectedValue = dgv_turTurKayitlari.SelectedRows[0].Cells["yurticiTurAdi"].Value.ToString();
            //cbx_yurtDisiTur.SelectedValue = dgv_turTurKayitlari.SelectedRows[0].Cells["yurtdisiTurTur_id"].Value;
            //cbx_yurtIciTur.SelectedValue = dgv_turTurKayitlari.SelectedRows[0].Cells["yurticiTurTur_id"].Value;
        }

        private void btn_masaustuGeriDonus_Click(object sender, EventArgs e)
        {
            this.Hide();
            Masaustu Mfrm = new Masaustu();

            Mfrm.Show();
            return;
        }

        private void TurunTurModeli_FormClosing(object sender, FormClosingEventArgs e)
        {
            Masaustu mfrm = (Masaustu)this.MdiParent;
            mfrm.tsbtn_turTur.Enabled = true;
        }

        private void btn_TTMCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_turPaketSayfasınaGec_Click(object sender, EventArgs e)
        {
            this.Hide();
            TurPaketleri tpfrm = new TurPaketleri();
            tpfrm.MdiParent = this.MdiParent;

            tpfrm.Show();
            return;
        }

        private void TurunTurModeli_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.P)//P - tur (P)aket
            {
                btn_turPaketSayfasınaGec_Click(sender, e);
            }
        }
    }
}
