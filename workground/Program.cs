using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;

using System.Threading.Tasks;

namespace workground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            degiskenler();
            Vatandas vatandas1 = new Vatandas();


            SelamVer();
            SelamVer(isim: "Engin");
            SelamVer(isim: "Ahemt");
            SelamVer(isim: "Ayşe");


            int sonuc = Topla(6,58);

            //Diziler /Arrays
            string ogrenci1 = "Engin";
            string ogrenci2 = "Kerem";
            string ogrenci3 = "Berkay";

            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";
            //ogrenciler[3] = "İlker";

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }
            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]);
            
            Person person = new Person();
            person1.FirstName = "ENGİN";
            person1.LastName = "DEMİROĞ";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity = 1;


            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);

            }
            List<string> yeniSehirler1 = new List<string> { "Ankara 1","İstabul 1","İzmir 1 "};
            yeniSehirler1.Add(item: "Adana");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);
            
            Console.ReadLine();

        }
        static void SelamVer(string isim = "isimsiz")
        {
            Console.WriteLine("Merhaba" + isim);
        }
        static int Topla(int sayi1 =5, int sayi2=10)
        {
            int sonuc = sayi1 + sayi2;  
            Console.WriteLine("Toplam :"+ sonuc.ToString());
            return sonuc;
        }



        private static void degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 100000;
            int sayi = 100;
            bool girisYapmismi = false;


            string ad = "Engin";
            string soyad = "Demiroğ";
            int dogumYili = 1985;
            long tcNo = 12345678910;

            Console.WriteLine(tutar * 1.18);
            Console.WriteLine(tutar * 1.18);
        }
    }
    public class Vatandas
    {
        public string Ad { get; set; }  
        public double Soyad { get; set;}    
        public int DogumYili { get; set;}
        public long TcNo { get; set;}
    }

    
}
