//Пресмята възръста ти след 10 години


using System;

namespace Vyzrast_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birthday year :");
            int birthyear = int.Parse(Console.ReadLine());
            DateTime AfterTenYears = DateTime.Now.AddYears(10);
            int result10years = AfterTenYears.Year - birthyear;
            int resultnow = DateTime.Now.Year - birthyear;
            Console.WriteLine(" Your age now: {0}", resultnow);
            Console.WriteLine("Your age after 10 years : {0}", result10years);

        }
    }
}
