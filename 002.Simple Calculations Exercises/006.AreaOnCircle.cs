//Лице на кръг

using System;

namespace _006.AreaOnCircle
{
    class AreaOnCircle
    {
        static void Main()
        {
            //p*r*r
            double r = double.Parse(Console.ReadLine());
            double p = 3.14;

            var area = p * r * r;
            Console.WriteLine(area);
        }
    }
}
