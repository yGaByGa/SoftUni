//Преобразува температура целзии във фарентхайнт

using System;

namespace _001.CelsiusToFahrenheit
{
    class CelsiusToFahrenheit
    {
        static void Main()
        {
            double celsius, faren;
            Console.Write("Temperature in Celsius(°C): ");
            celsius = double.Parse(Console.ReadLine());
            faren = (celsius * 9) / 5 + 32;
            Console.WriteLine("Temperature in Fahrenheit is(°F) : " + faren);
            Console.ReadLine();
        }
    }
}
