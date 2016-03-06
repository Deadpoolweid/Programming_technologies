namespace Massives
{
    internal class Output
    {
        public static string Out()
        {
            string text = "";
            for (int i = 0; i < Data.Array.Length; i++)
            {
                text += $"Элемент {i + 1} = {Data.Array[i]}" + "\n";
            }
            return text;
        } 
    }
}
