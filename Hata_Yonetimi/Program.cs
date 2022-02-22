using System;

namespace hata_yonetimi{

    class Program{

        static void Main(string[] args){

                try
                {
                        Console.Write("Bir Sayı Giriniz :");
                         int sayi = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Girilen Sayi : "+ sayi);
                }

                catch(Exception ex)
                {
                        Console.WriteLine("Hata :" + ex.Message.ToString());
                }

                finally
                {
                        Console.WriteLine("İşlem Tamamlandı.");
                }        
                


                // *********************************************************

                Console.WriteLine("*******************************");

                try
                {
                    //int a = int.Parse(null);
                    //int a = int.Parse("test");
                      int a = int.Parse("2000035050505050550");
                }
                
                catch (ArgumentNullException exx)
                {
                    Console.WriteLine("Boş Değer Girdiniz");
                    Console.WriteLine(exx);
                }

                catch(FormatException exxx)
                {
                    Console.WriteLine("Veri Tipi Uygun Değil");
                    Console.WriteLine(exxx);
                }

                catch(OverflowException exxxx)
                {
                    Console.WriteLine("Çok Küçük veya Çok Büyük Değer Girdiniz :");
                    Console.WriteLine(exxxx);
                }

                finally
                {
                    Console.WriteLine("İşlem Başarıyla Tamamlandı");
                }

        }


    }

}

