using System;

namespace _07.Demo7
{
    class Demo7
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
                if (symbol == 'o')
                {
                    sum+=2;
                }
                if (symbol == 'e')
                {
                    sum+=3;
                }
                if (symbol == 'i')
                {
                    sum+=4;
                }
                if (symbol == 'y')
                {
                    sum+=5;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
