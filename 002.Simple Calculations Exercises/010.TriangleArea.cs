//Лице на триъгълник


using System;

namespace TriangleArea
{
    class TriangleArea
    {
        static void Main(string[] args)
        {
            Console.Write("Strana a:");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Vuvedete h:");
            double h = double.Parse(Console.ReadLine());

            double area = a * h / 2 ;
            Console.WriteLine(Math.Round(area,2));
        }
    }
}
