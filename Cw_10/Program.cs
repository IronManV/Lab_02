using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine("Podaj 1 liczbe: ");
            string str1 = Console.ReadLine();
            Int32.TryParse(str1, out a);

            Console.WriteLine("Podaj 2 liczbe: ");
            string str2 = Console.ReadLine();
            Int32.TryParse(str2, out b);

            if(a%2 == 0 && b%2 == 0)
            {
                Console.WriteLine("parzysta");
            }
            else
            {
                Console.WriteLine("nieparzysta");
            }
            Console.ReadKey();
        }
    }
}
