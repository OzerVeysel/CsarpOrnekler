using System;

namespace HazırMethodlarString
{
    class Program
    {
        static void Main (string[] args)
        {
            string degisken = "Dersimiz C# Hoşgeldiniz ;";
            string degisken2 = "dersimiz C# ";

            // Length - değişkenin karakter sayısını bulur
            Console.WriteLine(degisken.Length);

            // ToUpper - değişkenin karakterlerini büyük harf yapar
            // ToLower - değişkenin karakterlerini küçük harf yapar
            
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            // Concat - 2 parametre alır birinci değişken, ikinci ise değiştirmek istenen değer

            Console.WriteLine(String.Concat(degisken,"Merhaba"));
            
            // Compare , CompareTo

            Console.WriteLine(degisken.CompareTo(degisken2)); // 0,1,-1 döner (karakter uzunluğuna göre karşılaştırarak)
            //değişken , değişken2'ye eşitse 0 döner
            //degğişken, değişken2'den büyükse 1 döner
            //değişken,  değişken2'den küçükse -1 döner


            Console.WriteLine(string.Compare(degisken,degisken2,true)); 
            // 2 değişken arasında büyük,küçük harf duyarlılığı
            // için 0,1 döner true duyarlı,false duyarsız 
            Console.WriteLine(string.Compare(degisken,degisken2,false));

            //Contains - degiskenin içinde değişken2 varmı diye bakar
            Console.WriteLine(degisken.Contains(degisken2));

            //EndsWith - StartWith (degiskenin girilen stringle bittiğini yada başladığını kontrol eder)
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz ;"));
            Console.WriteLine(degisken.StartsWith("Hoşgeldiniz ;")); 

            //IndexOf - degisken içindeki karakterin kaçıncı index'te olduğunu söyler
            Console.WriteLine(degisken.IndexOf("C#"));

            // LastIndexOf verilen değerin en son kaçıncı indexte kullanıldığını kontrol eder
            Console.WriteLine(degisken.LastIndexOf("i"));

            // Insert - Kaçıncı index'e ne eklenmek istendiği yazılır
            Console.WriteLine(degisken.Insert(0,"Merhaba"));

            //PadLeft,PadRight      
            Console.WriteLine(degisken+degisken2.PadLeft(30));
            Console.WriteLine(degisken+degisken2.PadLeft(30,'*'));
            Console.WriteLine(degisken.PadRight(50)+degisken2);
            Console.WriteLine(degisken.PadRight(50,'-')+degisken2);

            //Remove 10. indexten sonrasını siler
            Console.WriteLine(degisken.Remove(10));

            // Remove 5. indexten başlar 3 karakter siler
            Console.WriteLine(degisken.Remove(5,3)); 

            //Replace 1. verilen değeri 2. ile değiştirir
            Console.WriteLine(degisken.Replace("C#","Csarp"));
            Console.WriteLine(degisken.Replace(" ","*"));

            //Split verilen değerden keserek parçalar ve diziye atar
            Console.WriteLine(degisken.Split(" ")[1]); // Boşluk değerinden bölerek diziye atar ve indexi getirir

            //SubString - verilen indexten başlyarak sonuna kadar olan kısmı getirir
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,5)); //4. indexten başlayıp 5 karakter getirir

            

            


        }

    }
}