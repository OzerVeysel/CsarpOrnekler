using System;

namespace dongulerforloop
{
    class Program
    {
        static void Main (string [] args)
        {       

                Console.Write("Litfen Bir Sayı Giriniz : ");
                int sayac = Convert.ToInt32(Console.ReadLine());
                for ( int i = 1 ; i<=sayac; i++)
                {
                    if (i % 2 == 1)
                        Console.WriteLine(i);

                }

                int TekToplam = 0;
                int CiftToplam = 0;

                for (int i = 1; i <= 1000 ; i++)
                {
                    if(i%2==1)
                        TekToplam += i;
                    else
                        CiftToplam += i;
                    
                }
                Console.WriteLine("Tek Sayıların Toplamı : " +  TekToplam);
                Console.WriteLine("Çift Sayıların Toplamı : " + CiftToplam);

                for (int i = 1; i < 10; i++)
                {
                    if (i==4)
                        break;
                        Console.WriteLine(i);
                }
                for (int i = 1; i < 10; i++)
                {
                    if(i==4)
                        continue;
                        Console.WriteLine(i);
                }
        }
    }
}
