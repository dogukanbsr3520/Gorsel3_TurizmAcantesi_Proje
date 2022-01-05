using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Gorsel3_TurizmAcantesi_Proje
{
    public partial class BaslangicTA : Form
    {
        public BaslangicTA()
        {
            InitializeComponent();
        }
       // TALI.TruizmAcentasi_LisansIslemleri tal = new TALI.TruizmAcentasi_LisansIslemleri();
        private void BaslangicTA_Load(object sender, EventArgs e)
        {
            tx_yazilimKodu.Text = TALI.TruizmAcentasi_LisansIslemleri.YazilimKoduOlusturma();
           
        }

        private void btn_lisansla_Click(object sender, EventArgs e)
        {
            string lisansKodu = TALI.TruizmAcentasi_LisansIslemleri.LisansKodu(tx_yazilimKodu.Text);
            if (tx_lisansKodu.Text == lisansKodu) 
            {

                StreamWriter sw = new StreamWriter("TAlisans.l",false,Encoding.Default);
                sw.WriteLine(lisansKodu);
                sw.Close();
                MessageBox.Show("Lisanslama İşleminiz Başarılı...\n Uygulamayı Yeniden Başlatınız!!", "Lisans Onayı Bilgilendirme...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Lisans Kodunuz Geçersiz !!\n Lisans Kodunuzu kontrol edip tekrardan deneyiniz...", "Lisanslama Hatası !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
