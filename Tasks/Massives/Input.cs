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
                Data.array[i] = random.Next(Data.@from, Data.to);
            }
        }

        static public void _Settings()
        {
            Data.@from = -50;
            Data.to = 50;
        }

        static public void _Settings(int from, int to)
        {
            Data.@from = from;
            Data.to = to;
        }
    }
}
