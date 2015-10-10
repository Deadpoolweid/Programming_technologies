using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Two
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
            bool exist = false;
            foreach (var VARIABLE in array)
            {
                k++;
                if (VARIABLE > 25)
                {
                    exist = true;
                    break;
                }
            }

            if (exist)
            {
                Console.WriteLine("Номер элемента, большего 25: " + k);
            }
            else
            {
                Console.WriteLine("Такого элемента нет в массиве.");
            }

            Console.ReadKey();
        }
    }
}
