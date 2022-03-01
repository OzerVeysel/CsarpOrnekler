using System;

namespace array_sinifleri
{
    class Program
    {
        static void Main (string[] args)
        {
            // Sort (sıralama işlemi)
            int [] sayidizisi = {23,12,4,86,72,3,11,17};
            

            Console.WriteLine("** SIRASIZ DİZİ **");
            foreach  (var sayi in sayidizisi)
                Console.WriteLine(sayi);
            

            Console.WriteLine("** SIRALI DİZİ **");
            Array.Sort(sayidizisi);

            foreach (var sayi in sayidizisi)
                Console.WriteLine(sayi);

        // Clear ( Verdiğimiz indexten başlayıp verdiğimiz sayı kadar değere 0 ataması yapıyor)

            Console.WriteLine("** Array Clear **");
            Array.Clear(sayidizisi,2,2);

                foreach(var sayi in sayidizisi)
                    Console.Write(sayi);

        
        // Reverse ( Ters çevirme işlemi baştakini sona sondakini başa alır)

        Console.WriteLine("** Array Reverse **");
        Array.Reverse(sayidizisi);

            foreach (var sayi in sayidizisi)
                Console.WriteLine(sayi);

        
        // IndexOf (verilen dizi üzerindeki elemanın indexini verir )

        Console.WriteLine("** Array IndexOf **");
        Console.WriteLine( Array.IndexOf(sayidizisi,17));


        // Resize (Yeniden Boyutlandırma Yapıyor)
        // <int>(dizinin türünü belirliyor) - ref (referans alınacak dizi adı yazılıyor) , den sonrada dizinin yeni boyutu belirtiliyor
        Console.WriteLine ("** Array Resize **");
        Array.Resize<int>(ref sayidizisi,9); 
        sayidizisi[8]= 99;

            foreach (var sayi in sayidizisi)
                Console.WriteLine(sayi);


        

                


            
        }
    }
}
