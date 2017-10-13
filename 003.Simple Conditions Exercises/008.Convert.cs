using System;

namespace _08.Convert
{
    class Convert
    {
        static void Main(string[] args)
        {
            var value = double.Parse(Console.ReadLine());
            var input = Console.ReadLine();
            // Enter m , mm , cm , mi , inch , km , ft , yd 
            var output = Console.ReadLine();
            // Enter m , mm , cm , mi , inch , km , ft , yd

            var meter = 1;
            var mm = 1000;
            var cm = 100;
            var mi = 0.000621371192;
            var inch = 39.3700787;
            var km = 0.001;
            var ft = 3.2808399;
            var yd = 1.0936133;

            switch (input)
            {
                case "m":
                    break;
                case "mm":
                    value = value / mm;
                    break;
                case "cm":
                    value = value / cm;
                    break;
                case "mi":
                    value = value / mi;
                    break;
                case "in":
                    value = value / inch;
                    break;
                case "km":
                    value = value / km;
                    break;
                case "ft":
                    value = value / ft;
                    break;
                case "yd":
                    value = value / yd;
                    break;
                default:
                    break;
            }
            switch (output)
            {
                case "m":
                    break;
                case "mm":
                    value = value * mm;
                    break;
                case "cm":
                    value = value * cm;
                    break;
                case "mi":
                    value = value * mi;
                    break;
                case "in":
                    value = value * inch;
                    break;
                case "km":
                    value = value * km;
                    break;
                case "ft":
                    value = value * ft;
                    break;
                case "yd":
                    value = value * yd;
                    break;
                default:
                    break;
                
            }
            Console.WriteLine(value + " " + output);
        }
    }
}
