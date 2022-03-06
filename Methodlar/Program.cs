using System;

namespace metotlar
{
    class Prgram
    {
        static void Main(string[] args)
        {
             int a=2;
             int b=3;

             Console.WriteLine(a+b);

            int sonuc = toplam(2,3);
            Console.WriteLine(sonuc);

            Methodlar ornek = new Methodlar();
            ornek.EkranaYazdır(Convert.ToString(sonuc));

         
        }
            static int toplam(int deger1,int deger2)
             {
                 return (deger1+deger2);
             }
    }

    class Methodlar
    {
        public void EkranaYazdır(string veri)
        {
            Console.WriteLine(veri);
        }
    }
}
