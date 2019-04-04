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
             
            
            if (silnia < 1)
                return 1;
            else
                return silnia * Factorial(silnia - 1);
                
        }
        static void Main(string[] args)
        {
            
            
                int m;
            Console.WriteLine("Podaj liczbe do obliczenia silni: ");
            string str = Console.ReadLine();
            
           
            if(!Int32.TryParse(str, out m))
            {
                throw new ArgumentException("Podana liczba nie jest liczba calkowtia");
            }
            else
            {
                Console.WriteLine(Factorial(m));
            }
            

           

            Console.ReadKey();
        }
    }
}
