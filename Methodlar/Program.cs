using System;

namespace metotlar
{
    class Prgram
    {
        static async void Main(string[] args)
        {
             int a=2;
             int b=3;

             Console.WriteLine(a+b);

            int sonuc = toplam(2,3);
            Console.WriteLine(sonuc);

            Methodlar ornek = new Methodlar();
            ornek.EkranaYazdır(Convert.ToString(sonuc));

            
            int sonuc2 = ornek.ArttırVeTopla(ref a ,ref b);
            ornek.EkranaYazdır(Convert.ToString(sonuc2));
            ornek.EkranaYazdır(Convert.ToString( a+b));
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

        public int ArttırVeTopla(ref int deger1,ref int deger2)
        {
            deger1 +=1;
            deger2 +=1;
            return deger1 + deger2;
        }
    }
}
