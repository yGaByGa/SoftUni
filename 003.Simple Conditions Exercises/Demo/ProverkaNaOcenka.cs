//Проверява дали числото което е въведено е отлична оценка или по слаб резултат .


using System;

namespace demo2
{
    class demo2
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if (number>=5.50)
            {
                Console.WriteLine("ocenkata e mnogo dobra");
            }
            else
            {
                Console.WriteLine("ocenkata e pod 5.50");
            }
        }
    }
}
