using System;

namespace _09.VowelsSum
{
    class VowelsSum
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];
                if (symbol == 'a')
                {
                    sum++;
                }
                if (symbol == 'e')
                {
                    sum += 2;
                }
                if (symbol == 'i')
                {
                    sum += 3;
                }
                if (symbol == 'o')
                {
                    sum += 4;
                }
                if (symbol == 'u')
                {
                    sum += 5;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
