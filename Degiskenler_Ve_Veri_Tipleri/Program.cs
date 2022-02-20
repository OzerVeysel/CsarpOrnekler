using System;

    namespace degiskenker{
        class Program{
            static void Main (string[] args){

                 Console.WriteLine("");
                 String degisken = " ";
                 byte b = 5;        //1 byte
                 sbyte c = 5;       //1 byte
                 short s = 5;       // 2 byte
                 ushort us = 5;     // 2 byte
                 Int16 i16 = 2;     //2 byte
                 int i = 2;         // 4 byte
                 Int32 i32 = 2;     // 4 byte 
                 Int64 i64 = 2;     // 8 byte
                 uint ui = 2;       // 4 byte
                 long l = 4;        // 8 byte
                 ulong ul = 4;      // 8 byte

                 //// REEL Sayılar /////

                 float f = 5;       // 4 byte
                 double d = 5;      // 8 byte
                 decimal de = 5;    // 16 byte

                 /////            /////

                 char ch = '2';             // 2 byte
                 string str = "Veysel";     // Sınırsız karakter yazılabilir içine

                 bool b1 = true ;
                 bool b2 = false;

                 DateTime dt = DateTime.Now;  // Tarih 

                 Console.WriteLine(dt);

                 object o1 = "x";       // Her türden veriyi içinde tutar tüm değişkenlerde zaten objedir.
                 object o2 = "y";       // Her türden veriyi içinde tutar tüm değişkenlerde zaten objedir.
                 object o3 = "4";       // Her türden veriyi içinde tutar tüm değişkenlerde zaten objedir.
                 object o4 = "4.3";     // Her türden veriyi içinde tutar tüm değişkenlerde zaten objedir.

                 // String İfadeler

                 string str1 = "";                   // 3 işlemde string değerin boş olmasını sağlar 
                 string str2 = null;                 // 3 işlemde string değerin boş olmasını sağlar 
                 string str3 = string.Empty;          // 3 işlemde string değerin boş olmasını sağlar 


                str3 = "VEYSEL ÖZER";
                 string ad = "VEYSEL";
                 string soyad = "ÖZER";
                 string adsoyad = ad + " " + soyad ;


                // İnteger Tanımla Şekilleri 

                int integer1 = 5;
                int integer2 = 3;
                int integer3 = integer1 + integer2;

                // Bool İfadeler

                bool bool1 = 10>12;              // Bu işlemde koşul yanlış olduğundan False döner 
                bool bool2 = 10<12;              // Bu işlemde koşul doğru olduğundan True döner

                // Değişken Türleri 

                string strsayi = "20";
                int    intsayi =  20;

                string yenideger = strsayi + intsayi.ToString();
                int    YeniDeger = Convert.ToInt16(strsayi) + Convert.ToInt16(intsayi);
                Console.WriteLine(YeniDeger);


              // DateTime  Türü

              string datetime = DateTime.Now.ToString("dd.MM.yyyy");
                    Console.WriteLine(datetime);
              string saat = DateTime.Now.ToString("HH:mm");
                    Console.WriteLine(saat);






                  

        }
    }   
}


    
        
            
    


