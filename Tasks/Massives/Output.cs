using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massives
{
    class Output
    {
        static public string Out()
        {
            string text = "";
            for (int i = 0; i < Data.array.Length; i++)
            {
                text += String.Format("Элемент {0} = {1}",i+1,Data.array[i]) + "\n";
            }
            return text;
        } 
    }
}
