using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Five
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
                array[i] = random.Next(-10, 10);
            }

            foreach (var VARIABLE in array)
            {
                Console.Write(VARIABLE + "\t");
            }

            bool positive = IsPositive(array[0]);
            int k = 0;
            foreach (var variable in array)
            {
                if (positive != IsPositive(variable))
                {
                    k++;
                    positive = !positive;
                }
            }

            string[] words = new string[10];
            for (int i = 0; i < words.Count(); i++)
            {
                if (i > 1 && i < 5)
                {
                    words[i] = "раза";
                    continue;
                }
                words[i] = "раз";
            }

            Console.WriteLine("Элементы в последовательноси меняют знак {0} {1}", k, words[k]);

            Console.ReadKey();
        }

        static bool IsPositive(int x)
        {
            return (x > 0) ? true : false;
        }
    }
}
