using System;

namespace DongulerleDiziKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizi Tanımlama
            string[] renkler = new string[5];
            string[] hayvanlar = {"Kedi","Köpek","Kuş","Balık"};
            int[] dizi;
            dizi = new int[5];


            // Dizilere Değer Atama ve Erişim 
            renkler[0]="Mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);


            //Döngülerle Dizi Kullanımı 

            Console.Write("Lütfen Dizinin Eleman Sayısını Giriniz :");
            int diziuzunlugu = int.Parse(Console.ReadLine());
            int[] sayidizisi = new int[diziuzunlugu];

            for ( int i=0; i< diziuzunlugu; i++)
            {
                Console.Write("Lütfen {0}. Sayıyı giriniz :", i+1);
                sayidizisi[i]= int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach(var sayi in sayidizisi)
                toplam += sayi;

            Console.WriteLine("Ortalama :",toplam/diziuzunlugu);

        }
    }
}