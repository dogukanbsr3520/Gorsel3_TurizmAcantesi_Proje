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
    public partial class AdresBilgileri : Form
    {
        public AdresBilgileri()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
       
        private void AdresBilgileri_Load(object sender, EventArgs e)
        {
            dgv_adresBilgileriKayitlari.DataSource = vt.Select("select adres_id,mahalle,sokak,numara,daire,il,ilce from tbl_adres");

            dgv_adresBilgileriKayitlari.Columns[0].Visible = false;

        }

        private void btn_adresEkle_Click(object sender, EventArgs e)
        {
            if(tx_mahalleGir.Text.Trim().Length==0)
            {
                MessageBox.Show("Mahalle girdi alanı boş bırakılmamalıdır !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(tx_mahalleGir.Text.Trim().Length<2)
            {
                MessageBox.Show("Mahalle adı en az 2 karakter'den oluşmalıdır !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(tx_sokakGir.Text.Trim().Length==0)
            {
                MessageBox.Show("Sokak girdi alanı boş bırakılmamalıdır !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(tx_sokakGir.Text.Trim().Length<2)
            {
                MessageBox.Show("Sokak adı en az 2 karakter'den oluşmalıdır !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(tx_numaraGir.Text.Trim().Length==0)
            {
                MessageBox.Show("Numara girdi alanı boş bırakılmamalıdır !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(tx_numaraGir.Text.Trim().Length<1)
            {
                MessageBox.Show("Numara en az 1 rakam'dan oluşmalıdır !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(tx_daireGir.Text.Trim().Length==0)
            {
                MessageBox.Show("Daire No girdi alanı boş bırakılmamalıdır !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_daireGir.Text.Trim().Length < 1)
            {
                MessageBox.Show("Daire No en az 1 rakam'dan oluşmalıdır !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(tx_ilGir.Text.Trim().Length==0)
            {
                MessageBox.Show("İl ad alanı boş bırakılmamalıdır !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(tx_ilGir.Text.Trim().Length<3)
            {
                MessageBox.Show("İl adı en az 3 karakter'den oluşmalıdır !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(tx_ilceGir.Text.Trim().Length==0)
            {
                MessageBox.Show("İlçe ad alanı boş bırakılmamalıdır !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(tx_ilceGir.Text.Trim().Length<2)
            {
                MessageBox.Show("İlçe adı en az 2 karakter'den oluşmalıdır !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete("insert into tbl_adres(mahalle,sokak,numara,daire,il,ilce)values('"+tx_mahalleGir.Text+"', '"+tx_sokakGir.Text+"', '"+tx_numaraGir.Text+@"', 
                                               '"+tx_daireGir.Text+"', '"+tx_ilGir.Text+"', '"+tx_ilceGir.Text+"')");
            if (kayitSay > 0)
            {
                AdresBilgileri_Load(null, null);
                MessageBox.Show("Yeni Adres Kaydı Eklendi.");
            }
        }

        private void btn_adresGuncelle_Click(object sender, EventArgs e)
        {
            if(dgv_adresBilgileriKayitlari.SelectedRows.Count>1)
            {
                MessageBox.Show("Güncelleme işleminde sadece 1 satır seçili olmalıdır !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgv_adresBilgileriKayitlari.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncelleme işlemini gerçekleştirebilmek için bir satır seçmelisiniz !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_adres
                                            set mahalle='" + tx_mahalleGir.Text + @"',
                                            sokak='" + tx_sokakGir.Text + @"',
                                            numara='" + tx_numaraGir.Text + @"',
                                            daire='" + tx_daireGir.Text + @"',
                                            il='" + tx_ilGir.Text + @"',
                                            ilce='" + tx_ilceGir.Text + @"'
                                            where adres_id=" + dgv_adresBilgileriKayitlari.SelectedRows[0].Cells["adres_id"].Value);

            if (kayitSay > 0)
            {
                AdresBilgileri_Load(null, null);
                MessageBox.Show("Seçili Adres Kaydı Güncellendi");
            }
        }
        private void btn_adresSil_Click(object sender, EventArgs e)
        {
            if (dgv_adresBilgileriKayitlari.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek Satırı Seçiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete("delete from tbl_adres where adres_id=" + dgv_adresBilgileriKayitlari.SelectedRows[0].Cells["adres_id"].Value);
            if (kayitSay > 0)
            {
                AdresBilgileri_Load(null, null);
                MessageBox.Show("Seçili Adres Kaydı Silindi !");
            }
        }

        private void dgv_adresBilgileriKayitlari_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_adresBilgileriKayitlari.SelectedRows.Count == 0)
            {
                return; 
            }
            tx_mahalleGir.Text = dgv_adresBilgileriKayitlari.SelectedRows[0].Cells["mahalle"].Value.ToString();
            tx_sokakGir.Text = dgv_adresBilgileriKayitlari.SelectedRows[0].Cells["sokak"].Value.ToString();
            tx_numaraGir.Text = dgv_adresBilgileriKayitlari.SelectedRows[0].Cells["numara"].Value.ToString();
            tx_daireGir.Text = dgv_adresBilgileriKayitlari.SelectedRows[0].Cells["daire"].Value.ToString();
            tx_ilGir.Text = dgv_adresBilgileriKayitlari.SelectedRows[0].Cells["il"].Value.ToString();
            tx_ilceGir.Text = dgv_adresBilgileriKayitlari.SelectedRows[0].Cells["ilce"].Value.ToString();
        }

        private void AdresBilgileri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Masaustu mfrm = (Masaustu)this.MdiParent;
            mfrm.tsbtn_adresBilg.Enabled = true;  
        }

        private void btn_ABCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdresBilgileri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.M)//M - Müşteri
            {
                btn_musteriSayfaDon_Click(sender, e);
            }
        }

        private void btn_musteriSayfaDon_Click(object sender, EventArgs e)
        {
            this.Hide();
            MusteriIslemleri mifrm = new MusteriIslemleri();
            mifrm.MdiParent = this.MdiParent;
            mifrm.Show();
            return;
        }
    }
}
