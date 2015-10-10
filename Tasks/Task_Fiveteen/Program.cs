using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Fiveteen
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
                if (e < array[4])
                {
                    s += e;
                }
            }

            Console.WriteLine("Сумма элементов, меньших пятого элемента: " + s);

            Console.ReadKey();
        }
    }
}
