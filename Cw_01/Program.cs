using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4,3];
            Random rand = new Random();

            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rand.Next(10);
                    Console.Write(array[i, j] + " ");
                }
                Console.Write("\n");
            }
            
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                    
                }
                Console.WriteLine("Suma wiersza " + i + ": " + sum);

            }
            Console.ReadKey();
        }
    }
}
