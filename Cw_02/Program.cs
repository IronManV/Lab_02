using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw_02
{
    class Program
    {

        static void Print4D(int[,,,] array, int n)
        {
            Random randArray = new Random();
            int num1;
            int num2;
            int num3;
            int num4;

            for (int i = 0; i <= n; i++)
            {
                num1 = randArray.Next(5);
                num2 = randArray.Next(5);
                num3 = randArray.Next(5);
                num4 = randArray.Next(5);

                Console.WriteLine("Losowy element nr " + i + ":" + "array[" + num1 + "," + num2 + "," + num3 + "," +
                    num4 + "] = " + array[num1, num2, num3, num4]);
            }
        }
        static void Main(string[] args)
        {
            int[,,,] array = new int[5, 5, 5, 5];
            Random rand = new Random();
            int n = rand.Next(10)+1;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++ )
                    {
                        for(int l = 0; l < array.GetLength(3); l++)
                        {
                            array[i, j, k, l] = rand.Next(100);
                        }
                    }
                }
            }

            Print4D(array,n);



            Console.ReadKey();
        }
       
    }
}
