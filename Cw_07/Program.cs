using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            Console.WriteLine("podaj licze: ");
            string str = Console.ReadLine();
            Int32.TryParse(str, out number);

            if(number == 0)
            {
                Console.WriteLine("Kier");
            }
            else if (number == 1)
            {
                Console.WriteLine("Karo");
            }
            else if (number == 2)
            {
                Console.WriteLine("Trefl");
            }
            else if (number == 3)
            {
                Console.WriteLine("Pik");
            }
            else
            {
                Console.WriteLine("Bez koloru");
            }


            Console.ReadKey();
        }
    }
}
