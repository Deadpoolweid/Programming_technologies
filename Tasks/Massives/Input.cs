using System;

namespace Massives
{
    internal static class Input
    {
        public static void Generate()
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            for (int i = 0; i < Data.Array.Length; i++)
            {
                Data.Array[i] = random.Next(Data.From, Data.To);
            }
        }

        public static void _Settings()
        {
            Data.From = -50;
            Data.To = 50;
        }

        public static void _Settings(int from, int to)
        {
            Data.From = from;
            Data.To = to;
        }
    }
}
