using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_One
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
                array[i] = random.Next(0, 100);
            }

            foreach (var VARIABLE in array)
            {
                Console.Write(VARIABLE + "\t");
            }

            // Количество элементов массива, больших своих соседей
            int k = 0;
            for (int i = 1; i < array.Count()-1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    k++;
                }
            }

            Console.WriteLine("Количество элементов, больших, чем их соседи: " + k);

            Console.ReadKey();
        }
    }
}
