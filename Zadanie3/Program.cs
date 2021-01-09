using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            int licznik = 0;
            int liczba = 0; // zmienna liczba przechowywa aktualną wielokrotność 13 

            Console.WriteLine("Podaj wartość zmiennej ile: ");
            uint ile = uint.Parse(Console.ReadLine());

            while (licznik < ile)
            {
                if (liczba % 13 == 0 && liczba % 2 == 1) {

                    Console.Write("{0} ", liczba);
                    licznik++;
                
                }

                liczba += 13; 
            }

            Console.ReadKey();
        }
    }
}
