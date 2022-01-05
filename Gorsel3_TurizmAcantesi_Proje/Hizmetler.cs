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
    public partial class Hizmetler : Form
    {
        public Hizmetler()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
     

        private void Hizmetler_Load(object sender, EventArgs e)
        {
            dgv_hizmetKayitlari.DataSource = vt.Select("select hizmet_id,hizmetAd from tbl_hizmetler");

            dgv_hizmetKayitlari.Columns[0].Visible = false;

        }

        private void btn_hizmetEkle_Click(object sender, EventArgs e)
        {
            if (tx_hizmet.Text.Trim().Length ==0)
            {
                MessageBox.Show("Hizmet adı boş bırakılmamalıdır.!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_hizmet.Text.Trim().Length < 6)
            {
                MessageBox.Show("Hizmet adı en az 6 karakterden oluşmalıdır.!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int kayitSay = vt.UpdateDelete("insert into tbl_hizmetler(hizmetAd)values('" + tx_hizmet.Text + "')");
            if (kayitSay > 0)
            {
                Hizmetler_Load(null, null);
                MessageBox.Show("Yeni Hizmet Kaydı Eklendi.");
                    
            }
        }

        private void btn_hizmetGuncelle_Click(object sender, EventArgs e)
        {
            if (dgv_hizmetKayitlari.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncelleme işlemini gerçekleştirebilmek için bir satır seçmelisiniz !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgv_hizmetKayitlari.SelectedRows.Count > 1) 
            {
                MessageBox.Show("Güncelleme işleminde sadece 1 satır seçili olmalıdır !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int kayitSay = vt.UpdateDelete(@"update tbl_hizmetler
                                            set hizmetAd='" + tx_hizmet.Text + @"'
                                            where hizmet_id=" + dgv_hizmetKayitlari.SelectedRows[0].Cells["hizmet_id"].Value);

            if (kayitSay > 0)
            {
                Hizmetler_Load(null, null);
                MessageBox.Show("Seçili Hizmet Kaydı Güncellendi");
            }
        }

        private void btn_hizmetSil_Click(object sender, EventArgs e)
        {
            if (dgv_hizmetKayitlari.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek Satırı Seçiniz!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete("delete from tbl_hizmetler where hizmet_id=" + dgv_hizmetKayitlari.SelectedRows[0].Cells["hizmet_id"].Value);
            if (kayitSay > 0)
            {
                Hizmetler_Load(null, null);
                MessageBox.Show("Seçili Hizmet Kaydı Silindi !");
            }
        }

        private void dgv_hizmetKayitlari_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_hizmetKayitlari.SelectedRows.Count == 0)
            {
                return;
            }
            tx_hizmet.Text = dgv_hizmetKayitlari.SelectedRows[0].Cells["hizmetAd"].Value.ToString();
        }

        private void Hizmetler_FormClosing(object sender, FormClosingEventArgs e)
        {
            Masaustu mfrm = (Masaustu)this.MdiParent;
            mfrm.tsbtn_hizmetler.Enabled = true;
        }

        private void btn_HCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_konaklamaSayfaGec_Click(object sender, EventArgs e)
        {
            this.Hide();
            Konaklama kfrm = new Konaklama();
            kfrm.MdiParent = this.MdiParent;

            kfrm.Show();
            return;
        }

        private void Hizmetler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.K)//K - Konaklama
            {
                btn_konaklamaSayfaGec_Click(sender, e);
            }
        }
    }
}
