using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Nine
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

            int s = 0;

            foreach (var e in array)
            {
                if (e%3 != 0)
                {
                    s += e;
                }
            }

            Console.WriteLine("Сумма элементов, не кратных трём: " + s);

            Console.ReadKey();
        }
    }
}
