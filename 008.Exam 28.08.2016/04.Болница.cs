using System;

namespace _17.Demo
{
    class Hospital
    {
        static void Main(string[] args)
        {
            int izlekuvani = 0;
            int vurnati = 0;
            int lekari = 7;

            int dni = int.Parse(Console.ReadLine());

            for (int i = 1; i <= dni; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    if (vurnati > lekari)
                    {
                        lekari++;
                    }
                }
                if (number >= lekari)
                {
                    izlekuvani += lekari;
                    vurnati += number - lekari;

                }
                if (number < lekari)
                {
                    izlekuvani += number;

                }
            }
            Console.WriteLine("Treated patients: {0}." , izlekuvani);
            Console.WriteLine("Untreated patients: {0}." , vurnati);
        }
    }
}
