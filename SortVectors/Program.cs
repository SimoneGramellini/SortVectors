﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SortVectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vett = new int[10] { 0, 12, 2, 3, 4, 5, 6, 7, 8, 9 };

            Ordina(vett);
            int massimo = Massimo(vett);
           
            Massimo(vett);
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(vett[i]);
            }
                Console.WriteLine("Il numero massimo è " + massimo);
            Console.ReadKey();
        }

        public static void Ordina (int [] v)
        {
            Array.Sort(v);
        }
        public static int Massimo(int[] v)
        {
            return v[v.Length - 1];
        }
    }

}
