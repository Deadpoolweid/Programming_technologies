using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Ten
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

            foreach (var e in array)
            {
                if (e < array[0] && e > array[array.Count() - 1])
                {
                    k++;
                }
            }

            Console.WriteLine("Количество элементов, меньших первого и больших последнего: " + k);

            Console.ReadKey();
        }
    }
}
