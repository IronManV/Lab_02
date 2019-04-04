using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[4][];
            array[0] = new int[1] { 5 };
            array[1] = new int[3] {3,4,6};
            array[2] = new int[5] {7,5,9,3,2};
            array[3] = new int[7] {8,5,4,9,0,3,1};

            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array[i].Length; j++)
                {
                    Console.Write(array[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
