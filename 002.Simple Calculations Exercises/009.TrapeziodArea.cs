//Пресмята лице на трапец по 2 страни и височина


using System;

namespace TrapeziodArea
{
    class TrapeziodArea
    {
        static void Main(string[] args)
        {
            Console.Write("Strana AB= ");
            double stranaAB = double.Parse(Console.ReadLine());

            Console.Write("Strana CD= ");
            double stranaCD = double.Parse(Console.ReadLine());

            Console.Write("Visochina h= ");
            double h = double.Parse(Console.ReadLine());

            double result = (stranaAB + stranaCD) * h / 2;
            Console.WriteLine("Liceto na trapeca e {0}" ,result);
        }
    }
}
