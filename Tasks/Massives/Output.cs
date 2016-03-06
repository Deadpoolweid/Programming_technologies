using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massives
{
    class Output
    {
        public static string Out()
        {
            string text = "";
            for (int i = 0; i < Data.array.Length; i++)
            {
                text += $"Элемент {i + 1} = {Data.array[i]}" + "\n";
            }
            return text;
        } 
    }
}
