using System;
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
            int[] vett = new int[10] { 82, 12, 2, 3, 4, 5, 6, 7, 8, 9 };

            Ordina(vett);

            int minimo = Minimo(vett);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(vett[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("il valore minimo è: " + minimo);
            Console.ReadKey();
        }

        public static void Ordina (int [] v)
        {
            Array.Sort(v);
        }
        public static int Minimo (int [] v)
        {
            return v[0];
        }
    }
}
