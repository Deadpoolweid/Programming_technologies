using System.IO;
using System.Text;

namespace RegularExpressions
{
    internal static class Expressions
    {
        public static string Regex1 = "^\\D$";
        public static string Regex2 = "^([-+]?(?:\\d+|\\d*(?:\\.\\d+)?(?:[Ee][+-]?\\d+)?))?([-+])?(\\d+|\\d*(?:\\.\\d+)?(?:[Ee][+-]?\\d+)?)?[ij]$";
        public static string Regex3 = "^[0-9]+[\\,\\.][0-9][0-9]$";
        public static string Regex4 = "^[-]?\\d+$";
        public static string Regex5 = "^[\\d]{6}$";
        public static string Regex6 = "^[A-Z][a-z]* obl., g. [A-Z][a-z]+, ul. [A-Z][a-z]+, d. [0-9]+$";
        public static string Regex7 = "^<(([^>]|\\n)*)>$";
        public static string Regex8 = "(https?:\\/\\/)?(www\\.)?[-а-яa-z0-9_\\.]{2,}\\.(рф|[a-z]{2,6})((\\/[-а-яa-z0-9_]\\/|[-а-яa-z0-9_]{2,}" +
                            "\\.(рф|[a-z]{2,6}))|(\\/[-а-яa-z0-9_]\\/[-а-яa-z0-9_]{2,}\\.(рф|[a-z]{2,6})))(\\?[a-z0-9_]{2,}=[-0-9]{1,})?(\\&[a-z0-9_]{2,}=[-0-9]{1,})?";
        public static string Regex9 = "([A-Z][a-z]+ ){2}([A-Z][a-z]+)";
        public static string Regex10 = "^[+]?[78][ ]?[(]?\\d{3}[)]?[ ]?\\d{2}[ ]*[-]?[ ]*[\\d]{2}[ ]*[-]?[ ]*[\\d]{3}$";
        public static string Regex11 = "^([a-z0-9_-]+\\.)*[a-z0-9_-]+@[a-z0-9_-]+(\\.[a-z0-9_-]+)*\\.[a-z]{2,6}$";
        public static string Regex12 = "^([a-z0-9_-]+\\.)*[a-z0-9_-]+@[a-z0-9_-]+(\\.[a-z0-9_-]+)*\\.ru$";
        public static string Regex13 = "^[\\d]{1,2}[./][\\d]{1,2}[./][\\d]{1,4}$";
        public static string Regex14 = "жы|шы|чя|щя|чю|щю/ig";
        public static string Regex15 = "^[\\d\\s]+$";
        public static string Regex16 = "\\s(\\w+\\s)\\1";

        public static void Change(int number, string txt)
        {
            switch (number)
            {
                case 1:
                    Regex1 = txt;
                    break;
                case 2:
                    Regex2 = txt;
                    break;
                case 3:
                    Regex3 = txt;
                    break;
                case 4:
                    Regex4 = txt;
                    break;
                case 5:
                    Regex5 = txt;
                    break;
                case 6:
                    Regex6 = txt;
                    break;
                case 7:
                    Regex7 = txt;
                    break;
                case 8:
                    Regex8 = txt;
                    break;
                case 9:
                    Regex9 = txt;
                    break;
                case 10:
                    Regex10 = txt;
                    break;
                case 11:
                    Regex11 = txt;
                    break;
                case 12:
                    Regex12 = txt;
                    break;
                case 13:
                    Regex13 = txt;
                    break;
                case 14:
                    Regex14 = txt;
                    break;
                case 15:
                    Regex15 = txt;
                    break;
                case 16:
                    Regex16 = txt;
                    break;
            }
        }

        public static void SaveExpressions()
        {
            string[] exs =
            {
                Regex1, Regex2, Regex3, Regex4, Regex5, Regex6, Regex7, Regex8,
                Regex9, Regex10, Regex11, Regex12, Regex13, Regex14, Regex15, Regex16
            };
            File.WriteAllLines(@"exs.txt",exs,Encoding.UTF8);
        }

        public static void RestoreExpressions()
        {
            string[] exs = File.ReadAllLines(@"exs.txt", Encoding.UTF8);
            Regex1 = exs[0];
            Regex2 = exs[1];
            Regex3 = exs[2];
            Regex4 = exs[3];
            Regex5 = exs[4];
            Regex6 = exs[5];
            Regex7 = exs[6];
            Regex8 = exs[7];
            Regex9 = exs[8];
            Regex10 = exs[9];
            Regex11 = exs[10];
            Regex12 = exs[11];
            Regex13 = exs[12];
            Regex14 = exs[13];
            Regex15 = exs[14];
            Regex16 = exs[15];
        }

        public static string GetExpression(int number)
        {
            switch (number)
            {
                case 1:
                    return Regex1;
                case 2:
                    return Regex2;
                case 3:
                    return Regex3;
                case 4:
                    return Regex4;
                case 5:
                    return Regex5;
                case 6:
                    return Regex6;
                case 7:
                    return Regex7;
                case 8:
                    return Regex8;
                case 9:
                    return Regex9;
                case 10:
                    return Regex10;
                case 11:
                    return Regex11;
                case 12:
                    return Regex12;
                case 13:
                    return Regex13;
                case 14:
                    return Regex14;
                case 15:
                    return Regex15;
                case 16:
                    return Regex16;
                default:
                    return null;
            }
        }
    }
}
