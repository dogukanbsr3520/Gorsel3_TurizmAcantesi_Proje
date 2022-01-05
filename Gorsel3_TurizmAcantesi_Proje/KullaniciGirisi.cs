using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace Gorsel3_TurizmAcantesi_Proje
{
    public partial class KullaniciGirisi : Form
    {
        public KullaniciGirisi()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();
        VTI.HashIslemleri h = new VTI.HashIslemleri();
        int sifreKontrol = 0;
        private void tx_kullaniciAd_Enter(object sender, EventArgs e)
        {
            if (tx_kullaniciAd.Text == "kullanıcı Ad giriniz...")
            {
                tx_kullaniciAd.Text = "";
                tx_kullaniciAd.ForeColor = Color.Black;

            }


        } 

        private void tx_kullaniciAd_Leave(object sender, EventArgs e)
        {
            if (tx_kullaniciAd.Text == "")
            {
                tx_kullaniciAd.Text = "kullanıcı Ad giriniz...";
                tx_kullaniciAd.ForeColor = Color.Gray;

            }

        }

        private void tx_kullaniciSifre_Enter(object sender, EventArgs e)
        {
            if(tx_kullaniciSifre.Text=="Şifre giriniz...")
            {
                tx_kullaniciSifre.Text = "";
                tx_kullaniciSifre.ForeColor = Color.Black;
                tx_kullaniciSifre.PasswordChar = '*';
            }

        }

        private void tx_kullaniciSifre_Leave(object sender, EventArgs e)
        {
            if(tx_kullaniciSifre.Text=="")
            {
                tx_kullaniciSifre.Text = "Şifre giriniz...";
                tx_kullaniciSifre.ForeColor = Color.Gray;
                tx_kullaniciSifre.PasswordChar = '\0';
            }

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            

            DataTable dtSonuc = vt.Select("select * from tbl_musteri where ad = '" + tx_kullaniciAd.Text + "' and sifre = '" + h.MD5Sifrele(tx_kullaniciSifre.Text) + "'");
            if (dtSonuc.Rows.Count == 0)
            {
                sifreKontrol++;
                if (sifreKontrol >= 3)
                {
                    MessageBox.Show("Kullanıcı Adı'nız yada Kullanıcı Şifreniz hatalı!!. \nBirden fazla hatalı giriş yapıldı\n\nUygulama güvenlik sebebiyle kapatılıyor!!.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
                MessageBox.Show("Telefon yada şifre hatalı...", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(chbx_beniHatırla.Checked)
            {
                Ayarlar a = new Ayarlar();
                a.BeniHatırla = true;
                a.ad = tx_kullaniciAd.Text;
                a.sifre = tx_kullaniciSifre.Text;
                a.Save();
            }


            this.Hide();
            Masaustu mfrm = new Masaustu();

            int musteri_id = Convert.ToInt32(dtSonuc.Rows[0]["musteri_id"]);
            if (musteri_id != 6)
            {
                mfrm.tsbtn_biletSatis.Visible = false;
                mfrm.tsbtn_biletTur.Visible = false;
                mfrm.tsbtn_hizmetler.Visible = false; 
                mfrm.tsbtn_konaklama.Visible = false;
                mfrm.tsbtn_biletSatis.Visible = false;
                mfrm.tsbtn_yurticiTur.Visible = false;
                mfrm.tsbtn_yurtDısıTur.Visible = false;
                mfrm.tsbtn_yoneticiKontrolPanel.Visible = false;
            }

            mfrm.Show();
            return;



        }


        private void chbx_beniHatırla_CheckedChanged(object sender, EventArgs e)
        {
            if (!chbx_beniHatırla.Checked)
            {
                Ayarlar a = new Ayarlar();
                a.BeniHatırla = false;
                a.ad = "";
                a.sifre = "";
                a.Save();
            }
        }

        private void KullaniciGirisi_Load(object sender, EventArgs e)
        {
            Ayarlar a = new Ayarlar();
            if(a.BeniHatırla)
            {
                tx_kullaniciAd_Enter(null,null);
                tx_kullaniciAd.Text = a.ad;
                tx_kullaniciAd_Leave(null, null);

                tx_kullaniciSifre_Enter(null, null);
                tx_kullaniciSifre.Text = a.sifre;
                tx_kullaniciSifre_Leave(null,null);
                chbx_beniHatırla.Checked = true;
            }
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
