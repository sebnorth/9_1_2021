using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj rozmiar tablicy: ");
            int n = int.Parse(Console.ReadLine());

            int[] tab = new int[n];

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("elementy tablicy: ");

            for (int i = 0; i < tab.Length-1; i++)
            {
                Console.Write("{0}, ", tab[i]);
            }
            Console.Write(tab[tab.Length-1]);
            Console.WriteLine();

            uint ileUjemnych = 0;

            foreach (int item in tab)
            {
                if (item < 0) ileUjemnych++;
            }

            Console.Write("ilość liczb ujemnych w tablicy: {0}", ileUjemnych);

            Console.ReadKey();
        }
    }
}
