﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
           //liste.Add("Ayşe");
            //liste.Add(2);
            //liste.Add(true);
            //liste.Add('A');

            // İçerisindeki verilere erişim
            //Console.WriteLine(liste[1]);
            //foreach (var i in liste)
            //{
               // Console.WriteLine(i);
            //}

            //AddRange Toplu Ekleme
            Console.WriteLine("*****AddRange*****");

            //string[] renkler = {"kırmızı","sarı","yeşil"};
            List<int> sayılar =new List<int>(){1,8,3,7,9,92,5};

            //liste.AddRange(renkler);
            liste.AddRange(sayılar);

            foreach (var i in liste)
            {
                Console.WriteLine(i);
            }
            
            // Sort(sıralama)
            Console.WriteLine("****Sort****");
            liste.Sort();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            // Binary Search (verilen değerin index karşılığını getirir)
            Console.WriteLine("****Binary Search");
            Console.WriteLine(liste.BinarySearch(9));

            //Reverse (En baştaki elemanı en sona, en sondaki elemanı en başa alıyor)

            Console.WriteLine("****Reverse****");
            liste.Reverse(); 
            foreach ( var  item in liste)
            {
                Console.WriteLine(item);
            }
            
            // Clear
             Console.WriteLine("****Clear****");
            liste.Clear();

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
        }
    }
}