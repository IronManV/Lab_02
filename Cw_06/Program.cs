using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_06
{
    class Program
    {
        static int Factorial(int silnia)
        {
             return silnia;
            /*
            if (silnia < 1)
                return 1;
            else
                return 5; //silnia * Factorial(silnia - 1);
                */
        }
        static void Main(string[] args)
        {
            //program nie przechodzi do funkcji
            int m;
            Console.WriteLine("Podaj liczbe do obliczenia silni: ");
            string str = Console.ReadLine();
            Int32.TryParse(str, out m);
            
            /*
            try
            {
                Factorial(m);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Podana liczba nie jest liczba calkowtia");
            }
            */
            /*
            if(!Int32.TryParse(str, out m))
            {
                throw new ArgumentException("Podana liczba nie jest liczba calkowtia");
            }
            else
            {
                Factorial(m);
            }
            */

           Console.WriteLine(Factorial(m));

            Console.ReadKey();
        }
    }
}
