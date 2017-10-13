using System;

namespace _01.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            double pariZaDen = double.Parse(Console.ReadLine());
            double kursDolar = double.Parse(Console.ReadLine());

            double zaplata = days * pariZaDen;
            double godishnaZaplata = ( zaplata * 12 ) + ( zaplata * 2.5 );
            double danuk = godishnaZaplata * 25 / 100 ;
            double newGodishnaZaplata = godishnaZaplata - danuk;
            double dolariLeva = newGodishnaZaplata * kursDolar;
            double result = dolariLeva / 365;


            Console.WriteLine(Math.Round(result, 2));
        }
    }
}
