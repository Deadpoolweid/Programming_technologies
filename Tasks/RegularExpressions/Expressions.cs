using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExpressions
{
    class Expressions
    {
        public static string regex1 = "^\\D$";
        public static string regex2 = "^([-+]?(?:\\d+|\\d*(?:\\.\\d+)?(?:[Ee][+-]?\\d+)?))?([-+])?(\\d+|\\d*(?:\\.\\d+)?(?:[Ee][+-]?\\d+)?)?[ij]$";
        public static string regex3 = "^[0-9]+[\\,\\.][0-9][0-9]$";
        public static string regex4 = "^[-]?\\d+$";
        public static string regex5 = "^[\\d]{6}$";
        public static string regex6 = "^[A-Z][a-z]* obl., g. [A-Z][a-z]+, ul. [A-Z][a-z]+, d. [0-9]+$";
        public static string regex7 = "^<(([^>]|\\n)*)>$";
        public static string regex8 = "(https?:\\/\\/)?(www\\.)?[-а-яa-z0-9_\\.]{2,}\\.(рф|[a-z]{2,6})((\\/[-а-яa-z0-9_]\\/|[-а-яa-z0-9_]{2,}" +
                            "\\.(рф|[a-z]{2,6}))|(\\/[-а-яa-z0-9_]\\/[-а-яa-z0-9_]{2,}\\.(рф|[a-z]{2,6})))(\\?[a-z0-9_]{2,}=[-0-9]{1,})?(\\&[a-z0-9_]{2,}=[-0-9]{1,})?";
        public static string regex9 = "([A-Z][a-z]+ ){2}([A-Z][a-z]+)";
        public static string regex10 = "^[+]?[78][ ]?[(]?\\d{3}[)]?[ ]?\\d{2}[ ]*[-]?[ ]*[\\d]{2}[ ]*[-]?[ ]*[\\d]{3}$";
        public static string regex11 = "^([a-z0-9_-]+\\.)*[a-z0-9_-]+@[a-z0-9_-]+(\\.[a-z0-9_-]+)*\\.[a-z]{2,6}$";
        public static string regex12 = "^([a-z0-9_-]+\\.)*[a-z0-9_-]+@[a-z0-9_-]+(\\.[a-z0-9_-]+)*\\.ru$";
        public static string regex13 = "^[\\d]{1,2}[./][\\d]{1,2}[./][\\d]{1,4}$";
        public static string regex14 = "жы|шы|чя|щя|чю|щю/ig";
        public static string regex15 = "^[\\d\\s]+$";
        public static string regex16 = "\\s(\\w+\\s)\\1";

        static public void Change(int number, string txt)
        {
            switch (number)
            {
                case 1:
                    regex1 = txt;
                    break;
                case 2:
                    regex2 = txt;
                    break;
                case 3:
                    regex3 = txt;
                    break;
                case 4:
                    regex4 = txt;
                    break;
                case 5:
                    regex5 = txt;
                    break;
                case 6:
                    regex6 = txt;
                    break;
                case 7:
                    regex7 = txt;
                    break;
                case 8:
                    regex8 = txt;
                    break;
                case 9:
                    regex9 = txt;
                    break;
                case 10:
                    regex10 = txt;
                    break;
                case 11:
                    regex11 = txt;
                    break;
                case 12:
                    regex12 = txt;
                    break;
                case 13:
                    regex13 = txt;
                    break;
                case 14:
                    regex14 = txt;
                    break;
                case 15:
                    regex15 = txt;
                    break;
                case 16:
                    regex16 = txt;
                    break;
            }
        }

        static public void SaveExpressions()
        {
            string[] exs =
            {
                regex1, regex2, regex3, regex4, regex5, regex6, regex7, regex8,
                regex9, regex10, regex11, regex12, regex13, regex14, regex15, regex16
            };
            File.WriteAllLines(@"exs.txt",exs,Encoding.UTF8);
        }

        static public void RestoreExpressions()
        {
            string[] exs = File.ReadAllLines(@"exs.txt", Encoding.UTF8);
            regex1 = exs[0];
            regex2 = exs[1];
            regex3 = exs[2];
            regex4 = exs[3];
            regex5 = exs[4];
            regex6 = exs[5];
            regex7 = exs[6];
            regex8 = exs[7];
            regex9 = exs[8];
            regex10 = exs[9];
            regex11 = exs[10];
            regex12 = exs[11];
            regex13 = exs[12];
            regex14 = exs[13];
            regex15 = exs[14];
            regex16 = exs[15];
        }

        static public string GetExpression(int number)
        {
            switch (number)
            {
                case 1:
                    return regex1;
                case 2:
                    return regex2;
                case 3:
                    return regex3;
                case 4:
                    return regex4;
                case 5:
                    return regex5;
                case 6:
                    return regex6;
                case 7:
                    return regex7;
                case 8:
                    return regex8;
                case 9:
                    return regex9;
                case 10:
                    return regex10;
                case 11:
                    return regex11;
                case 12:
                    return regex12;
                case 13:
                    return regex13;
                case 14:
                    return regex14;
                case 15:
                    return regex15;
                case 16:
                    return regex16;
                default:
                    return null;
            }
        }
    }
}
