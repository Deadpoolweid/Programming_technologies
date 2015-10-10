using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Six
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
                array[i] = random.Next(0, 50);
            }

            foreach (var VARIABLE in array)
            {
                Console.Write(VARIABLE + "\t");
            }

            int k = 0;
            foreach (var VARIABLE in array)
            {
                if (VARIABLE > array[3])
                {
                    k++;
                }
            }

            Console.WriteLine("Количество элементов, больших, чем четвёртый: " + k);

            Console.ReadKey();
        }
    }
}
