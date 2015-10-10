using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Sixteenth
{
    class Program
    {
        static void Main(string[] args)
        {
            // Случайно сгенерированный массив
            int[] array = new int[10];
            Random random = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < array.Count(); i++)
            {
                array[i] = random.Next(1, 50);
            }

            foreach (var VARIABLE in array)
            {
                Console.Write(VARIABLE + "\t");
            }

            int k = 1;

            Console.WriteLine("Гистограмма вышеуказанного массива: ");

            foreach (var e in array)
            {
                if (k > 9)
                {
                    Console.Write(k + ": ");
                }
                else
                {
                    Console.Write(k++ + ":  ");                    
                }

                for (int i = 0; i < e; i++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}
