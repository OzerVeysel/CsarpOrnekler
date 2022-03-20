using System;
using System.Collections.Generic;

namespace GenericKoleksiyonlarveList
{
    class Program
    {
        static void Main(string[] args)
        {
            // syntax'ı List<T> class
            // namespace'i System.Collection.Generic
            // T -> bunun bir generic olduğunu söylüyor. T object türündedir ve nesne alabilir

            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23); 
            sayiListesi.Add(10); 
            sayiListesi.Add(4); 
            sayiListesi.Add(5); 
            sayiListesi.Add(92); 
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count (Listedeki elemanları toplayıp adedini ekrana yazdırır)
            Console.WriteLine(renkListesi.Count); 
            Console.WriteLine(sayiListesi.Count);

            //Elemanlarını ekrana yazdırmak
            foreach (var  sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }
            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>Console.WriteLine(renk));

            //Listeden Eleman Çıkarmak
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil"); 

            
            sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>Console.WriteLine(renk));

                //İndex'e göre listeden eleman çıkarmak

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>Console.WriteLine(renk));

            //Liste içerisinde Arama
            if(sayiListesi.Contains(10))
            {
                Console.WriteLine("10 Liste İçerisinde Bulundu");
            }

            //Eleman ile index'e erişme
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            //Dizi'yi List'e Çevirme
            string[] hayvanlar = {"Kedi","Köpek","Kuş"};

            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Listeyi Nasıl Temizleriz
            hayvanListesi.Clear();


            //List içerisinde nesne tutmak
             List<kullanıcılar>kullanıcıListesi = new List<kullanıcılar>();

             kullanıcılar kullanıcı1 = new kullanıcılar();
             kullanıcı1.Isim = "Ayşe";
             kullanıcı1.Soyad= "Yılmaz";
             kullanıcı1.Yas=26;

            kullanıcılar kullanıcı2 = new kullanıcılar();
            kullanıcı1.Isim = "Özcan";
            kullanıcı1.Soyad= "Çalışkan";
            kullanıcı1.Yas=26;

            kullanıcıListesi.Add(kullanıcı1);
            kullanıcıListesi.Add(kullanıcı2);


            List<kullanıcılar> yeniliste=new List<kullanıcılar>();

            yeniliste.Add(new kullanıcılar(){

                Isim = "Deniz",
                Soyad = "Arda",
                Yas=24
                
            });

            foreach (var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı:"+kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyadı :"+kullanıcı.Soyad);
                Console.WriteLine("Kullanıcı Yaşı :"+kullanıcı.Yas);
            }

            



        }
    }

    public class kullanıcılar
    {
        private string isim;
        private string soyad;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyad { get => soyad; set => soyad = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
