//Система която добава до 100 добавя 5 , от 100 до 1000 добавя 20% , а над 1000 добавя 10% бонуст точки


using System;

namespace demo6
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = number;

            if (number >= 1000)
            {
                result = result + result * 10 / 100;
            }
            else if (number >= 100)
            {
                result = result + result * 20 / 100; 
                // 20/100 otgovarq na 20% ili se izpolzva twentyPercent
            }
            else
            {
                result += 5;
            }

            if (number %2 == 0)
            {
                result++;
            }

            if (number %5 == 0)
            {
                result += 2;
            }

            Console.WriteLine(result);
        }
    }
}
