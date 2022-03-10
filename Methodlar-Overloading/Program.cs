using System;

namespace methodlaroverloading
{
    class Prgram
    {
        static void Main(string[] args)
        {
             string sayi = "999";
             int outSayi;

            bool sonuc =  int.TryParse(sayi, out outSayi);
            if(sonuc)
            {
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(2,6, out int toplamsonuc);
            Console.WriteLine(toplamsonuc);
        }
    }

    class Metotlar
    {
        public void Topla(int a,int b, out int toplam)
        {
            toplam = a+b;

        }
    }
}