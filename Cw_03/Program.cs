    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_03
{
    class Program
    {
        static void change(ref int a1, ref int b1)
        {
            int c = a1;
            a1 = b1;
            b1 = c;
            Console.WriteLine("Pierwsza zmienna: " + a1 + "\n Druga zmienna: " + b1);
        }
        static void Main(string[] args)
        {
            int a = 5;
            int b = 13;
            Console.WriteLine("Pierwsza zmienna: " + a + "\n Druga zmienna: " + b);

            change(ref a, ref b);
            Console.ReadKey();
        }
        
    }
}
