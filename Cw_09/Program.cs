using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string str2;
            Console.WriteLine("Podaj licze: ");
            string str = Console.ReadLine();
            Int32.TryParse(str, out num);

            str2 = num % 2 == 0 ? "Parzysta" : "Nieparzysta";

            Console.WriteLine(str2);

            Console.ReadKey();
        }
    }
}
