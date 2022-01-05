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
    public partial class YurticiTurAyarlama : Form
    {
        public YurticiTurAyarlama()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
       

        private void YurticiTurAyarlama_Load(object sender, EventArgs e)
        {
            dgv_YurtIciTurKayitlari.DataSource = vt.Select("select yurticiTurTur_id,yurticiTurAdi from tbl_yurticiTurTur");

            dgv_YurtIciTurKayitlari.Columns[0].Visible = false;
        }

        private void btn_yurticiTurEkle_Click(object sender, EventArgs e)
        {
            if(tx_yurtIciTurAyarla.Text.Trim().Length==0)
            {
                MessageBox.Show("Yurt İçi Tur Ayarla alanı boş bırakılmamlıdır !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(tx_yurtIciTurAyarla.Text.Trim().Length<12)
            {
                MessageBox.Show("Yurt İçi Tur Ayarla 12 karakter'den oluşmalıdır !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete("insert into tbl_yurticiTurTur(yurticiTurAdi)values('"+tx_yurtIciTurAyarla.Text+"')");
            if (kayitSay > 0)
            {
                YurticiTurAyarlama_Load(null, null);
                MessageBox.Show("Yeni Bölge Eklendi...");
            }

        }

        private void btn_yurticiTurGuncelle_Click(object sender, EventArgs e)
        {
            if (dgv_YurtIciTurKayitlari.SelectedRows.Count > 1)
            {
                MessageBox.Show("Güncelleme işleminde sadece 1 satır seçili olmalıdır !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            if (dgv_YurtIciTurKayitlari.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncelleme işlemini gerçekleştirebilmek için bir satır seçmelisiniz !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_yurticiTurTur
                                            set yurticiTurAdi='" + tx_yurtIciTurAyarla.Text + @"'
                                            where yurticiTurTur_id=" + dgv_YurtIciTurKayitlari.SelectedRows[0].Cells["yurticiTurTur_id"].Value);

            if (kayitSay > 0)
            {
                YurticiTurAyarlama_Load(null, null);
                MessageBox.Show("Seçili bölge başarıyla güncellendi");
            }
        }

        private void btn_yurticiTurSil_Click(object sender, EventArgs e)
        {
            if (dgv_YurtIciTurKayitlari.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek Satırı Seçiniz!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete("delete from tbl_yurticiTurTur where yurticiTurTur_id=" + dgv_YurtIciTurKayitlari.SelectedRows[0].Cells["yurticiTurTur_id"].Value);
            if (kayitSay > 0)
            {
                YurticiTurAyarlama_Load(null,null);
                MessageBox.Show("seçili Yurtİçi Tur kaydı silindi!.");
            }

        }

        private void dgv_YurtIciTurKayitlari_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_YurtIciTurKayitlari.SelectedRows.Count == 0)
            {
                return;
            }
            tx_yurtIciTurAyarla.Text = dgv_YurtIciTurKayitlari.SelectedRows[0].Cells["yurticiTurAdi"].Value.ToString();
        }

        private void YurticiTurAyarlama_FormClosing(object sender, FormClosingEventArgs e)
        {
            Masaustu mfrm = (Masaustu)this.MdiParent;
            mfrm.tsbtn_yurticiTur.Enabled = true;
        }

        private void btn_YDTACikis_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btn_yurtDisiSayfaGec_Click(object sender, EventArgs e)
        {
            this.Hide();
            YurtDisiTurAyarlama ydtfrm = new YurtDisiTurAyarlama();
            ydtfrm.MdiParent = this.MdiParent;

            ydtfrm.Show();
            return;
        }

        private void YurticiTurAyarlama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.D)//D - yurt(D)ışı
            {
                btn_yurtDisiSayfaGec_Click(sender, e);
            }
        }
    }
}
