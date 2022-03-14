using System;

namespace CsarpModülOrnek1
{
    class Program
    {
        static void Main (string[] args)
        {

            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n).
            // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            // Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            Console.Write("Dizi İçin Pozitif Bir sayı giriniz :");
            int diziboyutu=Convert.ToInt32(Console.ReadLine());
            if (diziboyutu<0)
            {
              Console.WriteLine("Negatif Bir Sayı Girdiniz.");
            }
            else
            {
                int[] sayılar=new int[diziboyutu];  

            for (int i = 0; i < diziboyutu; i++)
            {
                Console.Write(" {0}. Pozitif  Sayıyı Giriniz :",i+1);
                sayılar[i]=Convert.ToInt32(Console.ReadLine());  

            }
            foreach (int i in sayılar)
            {   
                if (i%2==0)
                {
                    Console.WriteLine(i);
                }
            }
            }

            // Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m).
            // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            // Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            
            Console.Write("Pozitif Bir  Sayı Giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Pozitif Bir Sayı Giriniz: ");
            int m = Convert.ToInt32(Console.ReadLine());

            int[] sayılar2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Lütfen {0}. Sayıyı Giriniz",i+1);
                sayılar2[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < sayılar2.Length; i++)
            {
                if (sayılar2[i] % m == 0)
                {
                    Console.WriteLine(sayılar2[i]+" m Sayısına Tam Bölünmektedir.");
                }

                else if (sayılar2[i] == m)
                {
                    Console.WriteLine(sayılar2[i]+" m Sayısına Eşittir.");
                }
                else
                {
                    Console.WriteLine(sayılar2[i] +"m Sayısına Bölünemez ve Eşit Değildir.");
                }
            }

             // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n).
             //  Sonrasında kullanıcıdan n adet kelime girmesi isteyin.
             //  Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

                Console.WriteLine("Lütfen Bir Sayı Giriniz : ");
                int deger = Convert.ToInt32(Console.ReadLine());
                string[] kelimeler = new string[deger];
                for (int i = 0; i < deger; i++)
                {
                    Console.WriteLine("Lütfen {0}. Kelimeyi Giriniz.",i+1);
                    kelimeler[i] = Console.ReadLine();
                }

                foreach (var kelime in kelimeler)
                {
                    Console.WriteLine(kelime);
                }
                
                Array.Reverse(kelimeler);
                foreach (var kelime in kelimeler)
                {
                    Console.WriteLine(kelime);
                }
           

            
        }
    }
}
