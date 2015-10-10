using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Four
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

            float averageValue = 0;

            foreach (var VARIABLE in array)
            {
                averageValue += VARIABLE;
            }
            averageValue/=array.Count();

            if (array[0] > averageValue)
            {
                Console.WriteLine("Первый элемент массива превосходит среднее значение всех элементов.");
            }
            else
            {
                Console.WriteLine("Первый элемент массива не превосходит среднее значение всех элементов.");
            }

            Console.ReadKey();
        }
    }
}
