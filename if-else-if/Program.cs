using System;

namespace ifelseif
{
     class Program
     {

            static public void Main(string[]args) 
            {
                
                //********* İf - Else - İf **********

                int time = DateTime.Now.Hour;

                if (time >= 6 && time < 11)
                    Console.WriteLine("Günaydın");
                else if ( time <= 18)
                    Console.WriteLine("İyi Günler!");
                else
                    Console.WriteLine("İyi Geceler!");

            // ************ Ternary *****************

            string zaman = time <= 18 ? "İyi Günler" : "İyi Geceler";

            zaman = time >= 6 && time < 11 ? "Günaydın" : time <= 18 ? "İyi Günler" : "İyi Geceler";

            Console.WriteLine(zaman);

        }
     }
}

    
;
