using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Massives
{
    class Input
    {
        static public void Generate()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < Data.array.Length; i++)
            {
                Data.array[i] = random.Next(0, 100);
            }
        }
    }
}
