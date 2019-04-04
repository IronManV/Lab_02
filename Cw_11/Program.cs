using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine("Podaj 1 cyfre: ");
            string str = Console.ReadLine();
            Int32.TryParse(str, out a);

            Console.WriteLine("Podaj 2 cyfre: ");
            string str1 = Console.ReadLine();
            Int32.TryParse(str1, out b);

            if(a > 0 || b > 0)
            {
                Console.WriteLine("przynajmniej jedna liczba jest wieksza od zera");
            }
            else
            {
                Console.WriteLine("Liczby są mniejsze od zera");
            }

            Console.ReadKey();
        }
    }
}
