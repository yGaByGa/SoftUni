﻿//Лице на кръг и периметъра му

using System;

namespace _003.CircleAreaAndPerimeter
{
    class CircleAreaAndPerimeter
    {
        static void Main()
        {
            Console.Write("Radios= ");
            double radios = double.Parse(Console.ReadLine());
            double area = Math.PI * radios * radios;
            double perimetyr = 2 * Math.PI * radios;

            Console.WriteLine("Area= {0}", area);
            Console.WriteLine("Perimetye= {0}", perimetyr);
        }
    }
}
