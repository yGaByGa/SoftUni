//Преобразува 


using System;

namespace RadiansToDegrees
{
    class RadiansToDegrees
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Radians= ");
            double rad = double.Parse(Console.ReadLine());

            double result = rad * 180 / Math.PI;
            Console.WriteLine(Math.Round(result, 0));
        }
    }
}
