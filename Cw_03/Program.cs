    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_03
{
    class Program
    {
        static void Change(ref int a1, ref int b1)
        {
            int sup = a1;
            a1 = b1;
            b1 = sup;
            
        }
        static void Main(string[] args)
        {
            int a = 5;
            int b = 13;
            Console.WriteLine("Pierwsza zmienna: {0} \n Druga zmienna: {1}", a, b);

            Change(ref a, ref b);
            Console.WriteLine("Pierwsza zmienna: {0} \n Druga zmienna: {1}", a, b);

            Console.ReadKey();
        }
        
    }
}
