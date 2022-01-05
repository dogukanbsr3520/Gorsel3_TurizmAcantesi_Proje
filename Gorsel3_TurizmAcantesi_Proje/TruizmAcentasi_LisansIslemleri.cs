using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using Microsoft.Win32;
using System.Security.Cryptography;

namespace TALI
{
   static class TruizmAcentasi_LisansIslemleri
    {
        public static string YazilimKoduOlusturma()
        {
            string HDDSeri = HDDSeriNo();
            string CPUSeri = CPUSeriNo();
            string HddCpuSeriNo = HDDSeri + CPUSeri;
            HddCpuSeriNo = HddCpuSeriNo.ToUpper();
            string kodOlustur = "";
            foreach (var item in HddCpuSeriNo)
            {
                if (item == 'W')
                    kodOlustur += '?';
                else if (item == '5')
                    kodOlustur += 'Z';
                else if (item == '1')
                    kodOlustur += 'X';
                else if (item == 'H')
                    kodOlustur += '!';
                else if (item == '0')
                    kodOlustur += '&';
                else if (item == 'D')
                    kodOlustur += '$';
                else if (item == 'J')
                    kodOlustur += 'P';
                else if (item == '2')
                    kodOlustur += '<';
                else if (item == 'S')
                    kodOlustur += '*';
                else if (item == '7')
                    kodOlustur += '@';
                else
                    kodOlustur += item;
            }
            string yazilimkoduOlustur = Md5Sifrele(kodOlustur).ToUpper();
           // textBox3.Text = yazilimkoduOlustur;
            return yazilimkoduOlustur;
        }

        public static string LisansKodu(string yazilimKodu)
        {
            yazilimKodu = MD5Sifrele(yazilimKodu);
            string sonKodOlustur = (yazilimKodu.Substring(0, 25) + "-Turizm Acentası Uygulama");

            string ilkmd5 = Md5Sifrele(sonKodOlustur);

            string ikincimd5 = Md5Sifrele(ilkmd5);

            string lisansKodu = ikincimd5.Substring(16, 3) +
                ikincimd5.Substring(2, 4) + ikincimd5.Substring(12, 8) +
                ikincimd5.Substring(19, 3) + ikincimd5.Substring(5, 2) +
                ikincimd5.Substring(9, 3) + ikincimd5.Substring(20, 2);
            lisansKodu = lisansKodu.ToUpper();
            lisansKodu = lisansKodu.Insert(15, "-").Insert(7, "-").Insert(3, "-");

            return lisansKodu;
        }


        public static string HDDSeriNo()
        {
            return HDDSeriNoCek();
        }
        public static string CPUSeriNo()
        {
            return CPUSeriNoCek();
        }
        public static string Md5Sifrele(string sifrelenecekMetin)
        {
            return MD5Sifrele(sifrelenecekMetin);
        }
        public static string HDDSeriNoCek()
        {
            List<string> serials = new List<string>();
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
            ManagementObjectCollection disks = searcher.Get();
            foreach (ManagementObject disk in disks)
            {
                if (disk["SerialNumber"] == null)
                    serials.Add("");
                else
                    serials.Add(disk["SerialNumber"].ToString());
            }
            string HDDserialNo = "";
            //List<string> serialsList = HDDSeriNoCek();
            foreach (string s in serials)
            {
                HDDserialNo = HDDserialNo + s.Trim();
            }
            HDDserialNo = HDDserialNo.TrimStart(); //Baştaki Boşluğu Kaldırıyoruz.
            return HDDserialNo;
        }
        public static String CPUSeriNoCek()
        {
            String processorID = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * FROM WIN32_Processor");
            ManagementObjectCollection mObject = searcher.Get();

            foreach (ManagementObject obj in mObject)
            {
                processorID = obj["ProcessorId"].ToString();
            }

            return processorID;
        }

        public static string MD5Sifrele(string sifrelenecekMetin)
        {

            // MD5CryptoServiceProvider sınıfının bir örneğini oluşturduk.
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            //Parametre olarak gelen veriyi byte dizisine dönüştürdük.
            byte[] dizi = Encoding.UTF8.GetBytes(sifrelenecekMetin);
            //dizinin hash'ini hesaplattık.
            dizi = md5.ComputeHash(dizi);
            //Hashlenmiş verileri depolamak için StringBuilder nesnesi oluşturduk.
            StringBuilder sb = new StringBuilder();
            //Her byte'i dizi içerisinden alarak string türüne dönüştürdük.

            foreach (byte ba in dizi)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }

            //hexadecimal(onaltılık) stringi geri döndürdük.
            return sb.ToString();
        }
    }
}
