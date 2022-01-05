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
    public partial class MusteriIslemleri : Form
    {
        public MusteriIslemleri()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
       

        private void btn_musteriFotoEkle_Click(object sender, EventArgs e)
        {
            pbx_musteriFoto.SizeMode = PictureBoxSizeMode.StretchImage;
            ofd_musteriFotoYukle.ShowDialog();
            pbx_musteriFoto.ImageLocation = ofd_musteriFotoYukle.FileName;
        }

        private void MusteriIslemleri_Load(object sender, EventArgs e)
        {
            dgv_musteriKayitlar.DataSource = vt.Select(@"select musteri_id,ad,soyad,telefon,sifre,kimlikNo,mail,a.mahalle,a.sokak,a.numara,a.daire,a.il,a.ilce,tt.turAd,tp.paketAd,rn.rezervasyonAd,rn.baslangicTarihi,rn.bitisTarihi
                                                        from tbl_musteri m
                                                        join tbl_adres a on m.adres_id=a.adres_id
                                                        join tbl_turTur tt on m.turTur_id=tt.turTur_id
                                                        join tbl_turPaket tp on tt.turPaket_id=tp.turPaket_id
                                                        join tbl_Rezervasyon rn on m.rezervasyon_id=rn.rezervasyon_id
                                                        where musteri_id=m.musteri_id");
            dgv_musteriKayitlar.Columns[0].Visible = false;


            cbx_turTuru.DisplayMember = "turAd";
            cbx_turTuru.ValueMember = "turTur_id";
            cbx_turTuru.DataSource = vt.Select("select turTur_id,turAd from tbl_turTur");

            cbx_turPaket.DisplayMember = "paketAd";
            cbx_turPaket.ValueMember = "turPaket_id";
            cbx_turPaket.DataSource = vt.Select("select turPaket_id,paketAd from tbl_turPaket");

            cbx_rezervasyon.DisplayMember = "rezervasyonAd";
            cbx_rezervasyon.ValueMember = "rezervasyon_id";
            cbx_rezervasyon.DataSource = vt.Select("select rezervasyon_id, rezervasyonAd from tbl_Rezervasyon");                        
        }

        private void btn_musteriEkle_Click(object sender, EventArgs e)
        {
            if (tx_musteriAd.Text.Trim().Length == 0)
            {
                MessageBox.Show("Müşteri Adı boş bırakılmamalıdır.!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_musteriAd.Text.Trim().Length < 2) 
            {
                MessageBox.Show("Girilen Ad en az 2 karakter olmalıdır !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_musteriSoyad.Text.Trim().Length == 0)
            {
                MessageBox.Show("Müşteri Soyadı boş bırakılmamalıdır.!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_musteriSoyad.Text.Trim().Length < 2) 
            {
                MessageBox.Show("Girilen Soyad en az 2 karakter olmalıdır ! ", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_telefon.Text.Trim().Length == 0)
            {
                MessageBox.Show("Telefon Numarası boş bırakılmamalıdır.!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_telefon.Text.Trim().Length < 11) 
            {
                MessageBox.Show("Girilen Telefon no 11 karakter olmalıdır ! ", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_sifre.Text.Trim().Length == 0)
            {
                MessageBox.Show("Şifre alanı boş bırakılmamalıdır.!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_sifre.Text.Trim().Length < 8) 
            {
                MessageBox.Show("Girilen Şifre 8 karakter'den az olmamalıdır ! ", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_kimlikNo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Kimlik Numarası alanı boş bırakılmamalıdır.!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_kimlikNo.Text.Trim().Length < 11) 
            {
                MessageBox.Show("Girilen T.C. Kimlik No 11 haneye eşit olmalıdır !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_mail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Müşteri Mail alanı boş bırakılmamalıdır.!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tx_mail.Text.Trim().Length < 10)
            {
                MessageBox.Show("Girilen Mail Adresi 10 karakter'den az olmamalıdır ! ", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int kayitSay = vt.UpdateDelete(@"insert into tbl_musteri(ad,soyad,telefon,sifre,kimlikNo,mail,adres_id,turTur_id,turPaket_id,rezervasyon_id)
                                                values('"+tx_musteriAd.Text+"', '"+tx_musteriSoyad.Text+"', '"+tx_telefon.Text+@"'
                                                , '"+tx_sifre.Text+"', '"+tx_kimlikNo.Text+"', '"+tx_mail.Text+ "','" + tx_adresSec.Text + "','" + cbx_turTuru.SelectedValue+@"',
                                                '"+cbx_turPaket.SelectedValue+"', '"+cbx_rezervasyon.SelectedValue+"')");

            if (kayitSay > 0) 
            {
                MusteriIslemleri_Load(null,null);
                MessageBox.Show("Yeni Müşteri Eklendi...");
            }
        }

        private void btn_musteriGuncelle_Click(object sender, EventArgs e)
        {
            if (dgv_musteriKayitlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Güncelleme işlemini gerçekleştirebilmek için bir satır seçmelisiniz !", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dgv_musteriKayitlar.SelectedRows.Count > 1)
            {
                MessageBox.Show("Güncelleme işleminde sadece 1 satır seçili olmalıdır ! ", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete(@"update tbl_musteri
                                            set ad='"+tx_musteriAd.Text+ @"',
                                            soyad='"+tx_musteriSoyad.Text+@"',
                                            telefon='"+tx_telefon.Text+@"',
                                            sifre='"+tx_sifre.Text+@"',
                                            kimlikNo='"+tx_kimlikNo.Text+@"',
                                            mail='"+tx_mail.Text+@"',
                                            adres_id='"+tx_adresSec.Text+@"',
                                            turTur_id='"+cbx_turTuru.SelectedValue+@"',
                                            turPaket_id='"+cbx_turPaket.SelectedValue+ @"',
                                            rezervasyon_id='" + cbx_rezervasyon.SelectedValue + @"'
                                            where musteri_id=" + dgv_musteriKayitlar.SelectedRows[0].Cells["musteri_id"].Value);

            if (kayitSay > 0)
            {
                MusteriIslemleri_Load(null,null);
                MessageBox.Show("Müşteri Bilgileri Başarılı Bir Şekilde Güncellendi...");
            }


        }
        private void btn_musteriSil_Click(object sender, EventArgs e)
        {
            if (dgv_musteriKayitlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silinecek Satırı Seçiniz!", "Hata!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int kayitSay = vt.UpdateDelete("delete from tbl_musteri where musteri_id=" + dgv_musteriKayitlar.SelectedRows[0].Cells["musteri_id"].Value);
            if (kayitSay > 0)
            {
                MusteriIslemleri_Load(null,null);
                MessageBox.Show("Müşteri kaydı silindi!.");
            }

        }

        private void dgv_musteriKayitlar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_musteriKayitlar.SelectedRows.Count == 0)
            {
                return;
            }
            tx_musteriAd.Text = dgv_musteriKayitlar.SelectedRows[0].Cells["ad"].Value.ToString();
            tx_musteriSoyad.Text = dgv_musteriKayitlar.SelectedRows[0].Cells["soyad"].Value.ToString();
            tx_telefon.Text = dgv_musteriKayitlar.SelectedRows[0].Cells["telefon"].Value.ToString();
            tx_sifre.Text = dgv_musteriKayitlar.SelectedRows[0].Cells["sifre"].Value.ToString();
            tx_kimlikNo.Text = dgv_musteriKayitlar.SelectedRows[0].Cells["kimlikNo"].Value.ToString();
            tx_mail.Text = dgv_musteriKayitlar.SelectedRows[0].Cells["mail"].Value.ToString();
        }

        private void btn_musteriKayidAlanTemizle_Click(object sender, EventArgs e)
        {
            tx_musteriAd.Text = "";
            tx_musteriSoyad.Text = "";
            tx_telefon.Text = "";
            tx_sifre.Text = "";
            tx_kimlikNo.Text = "";
            tx_mail.Text = "";
            tx_adresSec.Text = "";
            cbx_turTuru.SelectedValue = -1;
            cbx_turPaket.SelectedValue = -1;
            cbx_rezervasyon.SelectedValue = -1;
            foreach (DataGridViewRow item in dgv_musteriKayitlar.SelectedRows) 
            {
                item.Selected = false;
            }
        }

        private void btn_adresSayfaGec_Click(object sender, EventArgs e)
        {

            this.Hide();
            AdresBilgileri abfrm = new AdresBilgileri();//Hocanın yaptığı kısım
            abfrm.MdiParent = this.MdiParent;//Hocanın yaptığı kısım
            abfrm.Show();
            return;
        }

        private void MusteriIslemleri_FormClosing(object sender, FormClosingEventArgs e)
        {
            
                Masaustu mfrm = (Masaustu)this.MdiParent;
                mfrm.tsbtn_musteriIslemleri.Enabled = true;

        }

        private void btn_MICikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MusteriIslemleri_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.A)//A - AdresBilg
            {
                btn_adresSayfaGec_Click(sender, e);
            }
            if (e.KeyData == Keys.R)//R - Rezervasyon
            {
                btn_rezervasyonSayfaGec_Click(sender, e);
            }
        }

        private void btn_rezervasyonSayfaGec_Click(object sender, EventArgs e)
        {
            this.Hide();
            RezervasyonIslemleri rifrm = new RezervasyonIslemleri();
            rifrm.MdiParent = this.MdiParent;

            rifrm.Show();
            return;
        }

        private void cbx_turTuru_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
