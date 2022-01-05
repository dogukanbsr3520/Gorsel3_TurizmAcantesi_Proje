using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Gorsel3_TurizmAcantesi_Proje
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if(File.Exists("TAlisans.l"))
            {
                StreamReader sr = new StreamReader("TAlisans.l",Encoding.Default);
                string lisansKoduOku = sr.ReadLine();
                string lisansKodu = TALI.TruizmAcentasi_LisansIslemleri.LisansKodu(TALI.TruizmAcentasi_LisansIslemleri.YazilimKoduOlusturma());
                if (lisansKodu == lisansKoduOku)
                    Application.Run(new KullaniciGirisi());
                else
                    Application.Run(new BaslangicTA());
            }
            else
                 Application.Run(new BaslangicTA());
        }
    }
}
