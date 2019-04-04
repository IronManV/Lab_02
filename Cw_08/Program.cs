using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = ++a;
            int c = a++;
            int f = 15;
            int g = --f;
            int h = f--;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("f = " + f);
            Console.WriteLine("g = " + g);
            Console.WriteLine("h = " + h);

            Console.ReadKey();   
        }
    }
}
