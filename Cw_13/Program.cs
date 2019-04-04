using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.Write("Podaj wyskość trójkąta Pascala: ");
            string str = Console.ReadLine();
            Int32.TryParse(str, out size);

            int[][] array = new int[size][];

            array[0] = new int[] { 1 };
            array[1] = new int[] { 1, 1 };
            for(int i = 0; i < array.Length+2; i++)
            {
                
                for (int j; j < array[i].Length; j++)
                {
                    array[i+3] = new int[] {1, };
                }
            }
        }
    }
}
