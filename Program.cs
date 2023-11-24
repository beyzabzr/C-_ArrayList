using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{
    class Program
    {
        public static void Main(string[] args)
        {
            //System.Collections namespace

            ArrayList liste = new ArrayList();
            /*             
            liste.Add("Ayse");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');
            */

            //İcerisindeki verilere erisme

            /*
            Console.WriteLine(liste[1]); 
            */

            /* 
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            } 
            */

            Console.WriteLine("*************");

            //AddRange (Birden fazla elemani toplu halde ekleme)

            /* 
            string[] renkler = { "Kirmizi", "sari", "Yesil" }; 
            */

            List<int> sayilar = new List<int>() { 1, 8, 3, 7, 9, 92, 5 }; //System.Collections.Generic

            /* 
            liste.AddRange(renkler); 
            */

            liste.AddRange(sayilar);

            foreach (var item in liste)
            {
                Console.WriteLine(item);
            };

            Console.WriteLine("*********");

            //Sort (siralama)

            liste.Sort();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            };

            Console.WriteLine("*********");

            //Binary Search
            Console.WriteLine(liste.BinarySearch(9));

            Console.WriteLine("*********");

            //Reverse
            liste.Reverse();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("*********");

            //Clear
            liste.Clear();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

        }
    }
}