using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massives
{
    class Tasks
    {
        public string Task1(int[] array)
        {
            int k = 0;
            for (int i = 1; i < array.Count() - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    k++;
                }
            }

            return "Количество элементов, больших, чем их соседи: " + k;
        }

        public string Task2(int[] array)
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
            else
            {
                return "Такого элемента нет в массиве.";
            }
        }

        public string Task3(int[] array)
        {
            int s = 0;

            foreach (var VARIABLE in array)
            {
                if (VARIABLE > array[1])
                {
                    s += VARIABLE;
                }
            }

            return "Сумма элементов больших, чем второй элемент массива: " + s;
        }

        public string Task4(int[] array)
        {
            float averageValue = 0;

            foreach (var VARIABLE in array)
            {
                averageValue += VARIABLE;
            }
            averageValue /= array.Count();

            if (array[0] > averageValue)
            {
                return "Первый элемент массива превосходит среднее значение всех элементов.";
            }
            else
            {
                return "Первый элемент массива не превосходит среднее значение всех элементов.";
            }
        }

        public string Task5(int[] array)
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
            for (int i = 0; i < words.Count(); i++)
            {
                if (i > 1 && i < 5)
                {
                    words[i] = "раза";
                    continue;
                }
                words[i] = "раз";
            }

            return String.Format("Элементы в последовательноси меняют знак {0} {1}", k, words[k]);
        }

        static bool IsPositive(int x)
        {
            return (x > 0) ? true : false;
        }

        public string Task6(int[] array)
        {
            int k = 0;
            foreach (var VARIABLE in array)
            {
                if (VARIABLE > array[3])
                {
                    k++;
                }
            }

            return "Количество элементов, больших, чем четвёртый: " + k;
        }

        public string Task7(int[] array)
        {
            int s = 0;
            foreach (int e in array)
            {
                if (e > 21)
                {
                    s += e;
                }
            }

            return "Сумма элементов, больших 21: " + s;
        }

        public string Task8(int[] array)
        {
            for (int i = 0; i < array.Count(); i++)
            {
                if (array[i] % 5 == 0)
                {
                    array[i]++;
                }
            }

            string _out = "Элементы, кратные пяти увеличены на единицу:" + "\n";
            foreach (var e in array)
            {
                _out += e + "  ";
            }

            return _out;
        }

        public string Task9(int[] array)
        {
            int s = 0;

            foreach (var e in array)
            {
                if (e % 3 != 0)
                {
                    s += e;
                }
            }

            return "Сумма элементов, не кратных трём: " + s;
        }

        public string Task10(int[] array)
        {
            int k = 0;

            foreach (var e in array)
            {
                if (e < array[0] && e > array[array.Count() - 1])
                {
                    k++;
                }
            }

            return "Количество элементов, меньших первого и больших последнего: " + k;
        }

        public string Task11(int[] array)
        {
            int k = 0;
            foreach (var e in array)
            {
                if (e >= 0)
                {
                    k++;
                }
            }

            return "Количество неотрицательных элементов массива: " + k;
        }

        public string Task12(int[] array)
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

        public string Task13(int[] array)
        {
            int k = 0;
            foreach (var e in array)
            {
                if (e != 0)
                {
                    k++;
                }
            }

            return "Количество ненулевых элементов: " + k;

        }

        public string Task14(int[] array)
        {
            int k = 0;
            foreach (var a in array)
            {
                if (a%3 == 0)
                {
                    k++;
                }
            }

            return "Количество элементов, кратных 3: " + k;
        }

        public string Task15(int[] array)
        {
            int s = 0;

            foreach (var e in array)
            {
                if (e < array[4])
                {
                    s += e;
                }
            }

            return "Сумма элементов, меньших пятого элемента: " + s;
        }

        public string Task16(int[] array)
        {
            int k = 1;

            string text = "Гистограмма вышеуказанного массива: \n";

            int min = int.MaxValue;

            foreach (var a in array)
            {
                if (a < min)
                {
                    min = a;
                }
            }

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
