using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Eight
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

            for (int i = 0; i < array.Count(); i++)
            {
                if (array[i]%5 == 0)
                {
                    array[i]++;
                }
            }

            Console.WriteLine("Элементы, кратные пяти увеличены на единицу:");
            foreach (var e in array)
            {
                Console.Write(e + "\t");
            }

            Console.ReadKey();
        }
    }
}
