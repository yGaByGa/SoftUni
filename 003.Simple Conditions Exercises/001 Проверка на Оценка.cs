using System;
namespace Proverka_na_ocenka
{
    class PRoverkaNaOcenka
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade >=5.50)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
