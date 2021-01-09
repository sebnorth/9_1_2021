using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj a: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj b: ");
            int b = int.Parse(Console.ReadLine());

            //if (a < b) Console.WriteLine(a);
            //else {
            //    if (a == b) Console.WriteLine("Podane wartości są równe.");

            //    else Console.WriteLine(b);
            //}

            if (a < b) Console.WriteLine(a);

            if (b < a) Console.WriteLine(b);

            if (a == b) Console.WriteLine("Są równe.");

            Console.ReadKey();
        }

    }
}
