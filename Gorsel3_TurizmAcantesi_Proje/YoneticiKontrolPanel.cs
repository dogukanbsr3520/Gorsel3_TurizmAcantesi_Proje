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
    public partial class YoneticiKontrolPanel : Form
    {
        public YoneticiKontrolPanel()
        {
            InitializeComponent();
        }
        VTI.Veritabani vt = new VTI.Veritabani();

        private void YoneticiKontrolPanel_Load(object sender, EventArgs e)
        {
            dgv_YKKPmusterikayitlar.DataSource = vt.Select(@"select musteri_id,ad,soyad,telefon,sifre,kimlikNo,mail,a.mahalle,a.sokak,a.numara,a.daire,a.il,a.ilce,tt.turAd,tp.paketAd,rn.rezervasyonAd,rn.baslangicTarihi,rn.bitisTarihi
                                                        from tbl_musteri m
                                                        join tbl_adres a on m.adres_id=a.adres_id
                                                        join tbl_turTur tt on m.turTur_id=tt.turTur_id
                                                        join tbl_turPaket tp on tt.turPaket_id=tp.turPaket_id
                                                        join tbl_Rezervasyon rn on m.rezervasyon_id=rn.rezervasyon_id
                                                        where musteri_id=m.musteri_id");

            dgv_YKKPmusterikayitlar.Columns[0].Visible = false;


            dgv_YKKPrezervasyonkayitlar.DataSource = vt.Select(@"select rezervasyon_id,rezervasyonAd,baslangicTarihi,bitisTarihi,tt.turAd 
                                                            from tbl_Rezervasyon r
                                                            join tbl_turTur tt on r.turTur_id=tt.turTur_id");

            dgv_YKKPrezervasyonkayitlar.Columns[0].Visible = false;

            dgv_YKKPhizmetkayitlar.DataSource = vt.Select("select hizmet_id,hizmetAd from tbl_hizmetler");

            dgv_YKKPhizmetkayitlar.Columns[0].Visible = false;

            dgv_YKKPkonaklamakayitlar.DataSource = vt.Select("select konaklama_id,konaklamaAd from tbl_konaklama");

            dgv_YKKPkonaklamakayitlar.Columns[0].Visible = false;


            dgv_YKKPbiletsatiskayitlar.DataSource = vt.Select(@"select bs.musteri_id,bt.biletTur_id, bs.biletSatis_id,m.ad,m.soyad,m.telefon,biletTutar,bt.turAd
                                                                    from tbl_biletSatis bs
                                                                    join tbl_musteri m on bs.musteri_id = m.musteri_id
                                                                    join tbl_biletTur bt on bs.biletTur_id = bt.biletTur_id");

            dgv_YKKPbiletsatiskayitlar.Columns[0].Visible = false;
            dgv_YKKPbiletsatiskayitlar.Columns[1].Visible = false;
            dgv_YKKPbiletsatiskayitlar.Columns[2].Visible = false;


            dgv_YKKPbiletturkayitlari.DataSource = vt.Select("select biletTur_id,turNo,turAd from tbl_biletTur");

            dgv_YKKPbiletturkayitlari.Columns[0].Visible = false;

            dgv_YKKPyurticiturkayitlar.DataSource = vt.Select("select yurticiTurTur_id,yurticiTurAdi from tbl_yurticiTurTur");

            dgv_YKKPyurticiturkayitlar.Columns[0].Visible = false;

            dgv_YKKPyurtdisiturkayitlar.DataSource = vt.Select("select yurtdisiTurTur_id,yurtDisiTurAdi from tbl_yurtdisiTurTur");

            dgv_YKKPyurtdisiturkayitlar.Columns[0].Visible = false;

            dgv_YKKPturpaketkayitlar.DataSource = vt.Select(@"select turPaket_id,paketAd,gecerlilikSure,h.hizmetAd,k.konaklamaAd 
                                                            from tbl_turPaket tp
                                                            join tbl_hizmetler h on tp.hizmet_id=h.hizmet_id
                                                            join tbl_konaklama k on tp.konaklama_id=k.konaklama_id");

            dgv_YKKPturpaketkayitlar.Columns[0].Visible = false;


            dgv_YKKPturturukayitlar.DataSource = vt.Select(@"select turTur_id, tt.turAd,yit.yurticiTurAdi,ydt.yurtDisiTurAdi,tp.paketAd
                                                        from tbl_turTur tt
                                                        join tbl_turPaket tp on tp.turPaket_id = tt.turPaket_id
                                                        join tbl_yurticiTurTur yit on yit.yurticiTurTur_id = tt.yurticiTurTur_id
                                                        join tbl_yurtdisiTurTur ydt on ydt.yurtdisiTurTur_id = tt.yurtdisiTurTur_id");

            dgv_YKKPturturukayitlar.Columns[0].Visible = false;

            dgv_YKKPadreskayitlar.DataSource = vt.Select("select adres_id,mahalle,sokak,numara,daire,il,ilce from tbl_adres");

            dgv_YKKPadreskayitlar.Columns[0].Visible = false;



        }
        private void YoneticiKontrolPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Masaustu mfrm = (Masaustu)this.MdiParent;
            mfrm.tsbtn_yoneticiKontrolPanel.Enabled = true;
        }

        private void btn_YKPCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
