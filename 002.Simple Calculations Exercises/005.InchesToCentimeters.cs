//Поздрав плус въведеното име

using System;

namespace _005.InchesToCentimeters
{
    class InchesToCentimeters
    {
        static void Main()
        {
            Console.Write("Inch= ");
            double inch = double.Parse(Console.ReadLine());
            double result = inch * 2.54;

            Console.WriteLine("Santimetri: {0}", result);
        }
    }
}
