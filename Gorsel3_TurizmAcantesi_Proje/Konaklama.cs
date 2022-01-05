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
    public partial class Konaklama : Form
    {
        public Konaklama()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
    

        private void Konaklama_Load(object sender, EventArgs e)
        {
            dgv_konaklamaKayitlari.DataSource = vt.Select("select konaklama_id,konaklamaAd from tbl_konaklama");

            dgv_konaklamaKayitlari.Columns[0].Visible = false;

        }

        private void btn_konaklamaEkle_Click(object sender, EventArgs e)
        {

            if (tx_konaklama.Text.Trim().Length == 0)
            {
                MessageBox.Show("Konaklama adı boş bırakılmamalıdır.!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_konaklama.Text.Trim().Length < 5)
            {
                MessageBox.Show("Konaklama adı en az 5 karakterden oluşmalıdır.!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int kayitSay = vt.UpdateDelete("insert into tbl_konaklama(konaklamaAd)values('"+tx_konaklama.Text+"')");
            if (kayitSay > 0)
            {
                Konaklama_Load(null, null);
                MessageBox.Show("Yeni Konaklama Kaydı Eklendi.");
            }
        }

        private void btn_konaklamaGuncelle_Click(object sender, EventArgs e)
        {

            if(dgv_konaklamaKayitlari.SelectedRows.Count>1)
            {
                MessageBox.Show("Güncelleme işleminde sadece 1 satır seçili olmalıdır ! ", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgv_konaklamaKayitlari.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncelleme işlemini gerçekleştirebilmek için bir satır seçmelisiniz !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_konaklama
                                            set konaklamaAd='" + tx_konaklama.Text + @"'
                                            where konaklama_id=" + dgv_konaklamaKayitlari.SelectedRows[0].Cells["konaklama_id"].Value);

            if (kayitSay > 0)
            {
                Konaklama_Load(null, null);
                MessageBox.Show("Seçili Konaklama Kaydı Güncellendi");
            }
        }

        private void btn_konaklamaSil_Click(object sender, EventArgs e)
        {
            if (dgv_konaklamaKayitlari.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek Satırı Seçiniz!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete("delete from tbl_konaklama where konaklama_id=" + dgv_konaklamaKayitlari.SelectedRows[0].Cells["konaklama_id"].Value);
            if (kayitSay > 0)
            {
                Konaklama_Load(null, null);
                MessageBox.Show("Seçili Konaklama Kaydı Silindi !");
            }
        }

        private void dgv_konaklamaKayitlari_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_konaklamaKayitlari.SelectedRows.Count == 0)
            {
                return;
            }
            tx_konaklama.Text = dgv_konaklamaKayitlari.SelectedRows[0].Cells["konaklamaAd"].Value.ToString();
        }

        private void Konaklama_FormClosing(object sender, FormClosingEventArgs e)
        {
            Masaustu mfrm = (Masaustu)this.MdiParent;
            mfrm.tsbtn_konaklama.Enabled = true;
        }

        private void btn_KCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_hizmetSayfaGec_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hizmetler hrfrm = new Hizmetler();
            hrfrm.MdiParent = this.MdiParent;

            hrfrm.Show();
            return;
        }

        private void Konaklama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.H)//H - Hizmetler
            {
                btn_hizmetSayfaGec_Click(sender, e);
            }
        }
    }
}
