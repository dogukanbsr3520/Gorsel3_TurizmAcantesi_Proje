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
    public partial class YurtDisiTurAyarlama : Form
    {
        public YurtDisiTurAyarlama()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani(); 


        private void YurtDisiTurAyarlama_Load(object sender, EventArgs e)
        {
            dgv_yurtDisiTurKayitari.DataSource = vt.Select("select yurtdisiTurTur_id,yurtDisiTurAdi from tbl_yurtdisiTurTur");

            dgv_yurtDisiTurKayitari.Columns[0].Visible = false;
        }

        private void btn_yurtDisiTurEkle_Click(object sender, EventArgs e)
        {
            if(tx_yurtDisiTurAyarla.Text.Trim().Length==0)
            {
                MessageBox.Show("Yurt Dışı Tur Ayarla alanı boş bırakılmamalıdır !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(tx_yurtDisiTurAyarla.Text.Trim().Length<13)
            {
                MessageBox.Show("Yurt Dışı Tur Ayarla en az 13 karakterden oluşmalıdır !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete("insert into tbl_yurtdisiTurTur(yurtDisiTurAdi)values('" + tx_yurtDisiTurAyarla.Text + "')");
            if (kayitSay > 0)
            {
                YurtDisiTurAyarlama_Load(null, null);
                MessageBox.Show("Yeni Bölge Eklendi...");
            }
        }
        private void btn_yurtDisiTurGuncelle_Click(object sender, EventArgs e)
        {
        
            if (dgv_yurtDisiTurKayitari.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncelleme işlemini gerçekleştirebilmek için bir satır seçmelisiniz !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgv_yurtDisiTurKayitari.SelectedRows.Count > 1)
            {
                MessageBox.Show("Güncelleme işleminde sadece 1 satır seçili olmalıdır !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_yurtdisiTurTur
                                            set yurtDisiTurAdi='" + tx_yurtDisiTurAyarla.Text + @"'
                                            where yurtdisiTurTur_id=" + dgv_yurtDisiTurKayitari.SelectedRows[0].Cells["yurtdisiTurTur_id"].Value);

            if (kayitSay > 0)
            {
                YurtDisiTurAyarlama_Load(null, null);
                MessageBox.Show("Seçili bölge başarıyla güncellendi");
            }
        }
        private void btn_yurtDisiTurSil_Click(object sender, EventArgs e)
        {
            if (dgv_yurtDisiTurKayitari.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek Satırı Seçiniz!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete("delete from tbl_yurtdisiTurTur where yurtdisiTurTur_id=" + dgv_yurtDisiTurKayitari.SelectedRows[0].Cells["yurtdisiTurTur_id"].Value);
            if (kayitSay > 0)
            {
                YurtDisiTurAyarlama_Load(null, null);
                MessageBox.Show("seçili YurtDışı Tur kaydı silindi!.");
            }
        }


        private void dgv_yurtDisiTurKayitari_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_yurtDisiTurKayitari.SelectedRows.Count == 0)
            {
                return;
            }
            tx_yurtDisiTurAyarla.Text = dgv_yurtDisiTurKayitari.SelectedRows[0].Cells["yurtdisiTurAdi"].Value.ToString();
        }

        private void YurtDisiTurAyarlama_FormClosing(object sender, FormClosingEventArgs e)
        {
            Masaustu mfrm = (Masaustu)this.MdiParent;
            mfrm.tsbtn_yurtDısıTur.Enabled = true;
        }

        private void btn_YDTACikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_yurtIciSayfaGec_Click(object sender, EventArgs e)
        {
            this.Hide();
            YurticiTurAyarlama yitfrm = new YurticiTurAyarlama();
            yitfrm.MdiParent = this.MdiParent;

            yitfrm.Show();
            return;
        }

        private void YurtDisiTurAyarlama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.I)//I - Yurt(I)çi
            {
                btn_yurtIciSayfaGec_Click(sender, e);
            }
        }
    }
}
