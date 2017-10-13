using System;
 
namespace _06.BonusPoint
{
    class BonustPoint
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double result = number;
            double bonus = 0.0;
 
            if (number > 100 && number <=1000)
            {
                bonus = number / 5.0;
            }
            else if (number <= 100)
            {
                bonus = 5;
            }
            else if(number > 1000)
            {
                bonus = number / 10.0;
            }
           
            if (number % 2 == 0)
            {
                bonus++;
            }
            else if (number % 5 == 0)
            {
                bonus += 2;
            }
            double totalScore = number + bonus;
            Console.WriteLine("Bonus score: " + bonus);
            Console.WriteLine("Total score: " + totalScore);
        }
    }
}
