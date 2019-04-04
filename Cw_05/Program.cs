using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("Podaj pierwsza liczbe: ");
            string str1 = Console.ReadLine();
            Int32.TryParse(str1, out num1);

            Console.WriteLine("Podaj druga liczbe: ");
            string str2 = Console.ReadLine();
            Int32.TryParse(str2, out num2);

            try
            {
                Console.WriteLine(num1/num2);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Nie wolno dzielic przez zero!");
            }
            finally
            {
                Console.WriteLine("Dziękuje!");
            }
            Console.ReadKey();
        }
    }
}
