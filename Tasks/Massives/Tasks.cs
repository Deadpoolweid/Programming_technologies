using System;
using System.Linq;

namespace Massives
{
    internal class Tasks
    {
        private string Task1(int[] array)
        {
            int k = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    k++;
                }
            }

            return "Количество элементов, больших, чем их соседи: " + k;
        }

        private string Task2(int[] array)
        {
            int k = 0;
            bool exist = false;
            foreach (var a in array)
            {
                k++;
                if (a > 25)
                {
                    exist = true;
                    break;
                }
            }

            if (exist)
            {
                return "Номер элемента, большего 25: " + k;
            }
            return "Такого элемента нет в массиве.";
        }

        private string Task3(int[] array)
        {
            int s = array.Where(variable => variable > array[1]).Sum();

            return "Сумма элементов больших, чем второй элемент массива: " + s;
        }

        private string Task4(int[] array)
        {
            float averageValue = array.Aggregate<int, float>(0, (current, variable) => current + variable);

            averageValue /= array.Length;

            if (array[0] > averageValue)
            {
                return "Первый элемент массива превосходит среднее значение всех элементов.";
            }
            return "Первый элемент массива не превосходит среднее значение всех элементов.";
        }

        private string Task5(int[] array)
        {
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
            for (int i = 0; i < words.Length; i++)
            {
                if (i > 1 && i < 5)
                {
                    words[i] = "раза";
                    continue;
                }
                words[i] = "раз";
            }

            return $"Элементы в последовательноси меняют знак {k} {words[k]}";
        }

        private static bool IsPositive(int x)
        {
            return (x > 0);
        }

        private string Task6(int[] array)
        {
            int k = array.Count(variable => variable > array[3]);

            return "Количество элементов, больших, чем четвёртый: " + k;
        }

        private string Task7(int[] array)
        {
            int s = array.Where(e => e > 21).Sum();

            return "Сумма элементов, больших 21: " + s;
        }

        private string Task8(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 5 == 0)
                {
                    array[i]++;
                }
            }

            return array.Aggregate("Элементы, кратные пяти увеличены на единицу:" + "\n", (current, e) => current + (e + "  "));
        }

        private string Task9(int[] array)
        {
            int s = array.Where(e => e%3 != 0).Sum();

            return "Сумма элементов, не кратных трём: " + s;
        }

        private string Task10(int[] array)
        {
            int k = array.Count(e => e < array[0] && e > array[array.Length - 1]);

            return "Количество элементов, меньших первого и больших последнего: " + k;
        }

        private string Task11(int[] array)
        {
            int k = array.Count(e => e >= 0);

            return "Количество неотрицательных элементов массива: " + k;
        }

        private string Task12(int[] array)
        {
            int e = array[0];
            int x = array[1];
            int n = 1;
            for (int i = 2; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) - Math.Abs(x) < Math.Abs(e) - Math.Abs(x))
                {
                    e = array[i];
                    n = i+1;
                }
            }

            return "Элемент, меньше всего отличающийся от второго - " + "Элемент " + n + ": " + e;
        }

        private string Task13(int[] array)
        {
            int k = array.Count(e => e != 0);

            return "Количество ненулевых элементов: " + k;

        }

        private string Task14(int[] array)
        {
            int k = array.Count(a => a%3 == 0);

            return "Количество элементов, кратных 3: " + k;
        }

        private string Task15(int[] array)
        {
            int s = array.Where(e => e < array[4]).Sum();

            return "Сумма элементов, меньших пятого элемента: " + s;
        }

        private string Task16(int[] array)
        {
            int k = 1;

            string text = "Гистограмма вышеуказанного массива: \n";

            int min = array.Concat(new[] {int.MaxValue}).Min();

            min = Math.Abs(min);

            foreach (var e in array)
            {
                if (k > 9)
                {
                    text += k + ": ";
                }
                else
                {
                    text += k++ + ": ";
                }

                if (e >= 0)
                {
                    for (int i = 0; i < min; i++)
                    {
                        text += "-";
                    }
                }
                else
                {
                    for (int i = 0; i < min-Math.Abs(e); i++)
                    {
                        text += "-";
                    }
                }

                for (int i = 0; i < Math.Abs(e); i++)
                {
                    text+= "*";
                }
                text += "\n";
            }

            return text;
        }

        /// <summary>
        /// Запускает задание указанного номера и возвращает результат
        /// </summary>
        /// <param name="number">Номер задания</param>
        /// <param name="array">Массив для работы</param>
        /// <returns>Результат задания</returns>
        public string ExecuteTask(int number, int[] array)
        {
            switch (number)
            {
                case 1:
                    return Task1(array);
                case 2:
                    return Task2(array);
                case 3:
                    return Task3(array);
                case 4:
                    return Task4(array);
                case 5:
                    return Task5(array);
                case 6:
                    return Task6(array);
                case 7:
                    return Task7(array);
                case 8:
                    return Task8(array);
                case 9:
                    return Task9(array);
                case 10:
                    return Task10(array);
                case 11:
                    return Task11(array);
                case 12:
                    return Task12(array);
                case 13:
                    return Task13(array);
                case 14:
                    return Task14(array);
                case 15:
                    return Task15(array);
                case 16:
                    return Task16(array);
                default:
                    return null;
            }
        }
    }
}
