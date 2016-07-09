using System;

namespace _12.Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            int redove = int.Parse(Console.ReadLine());
            int koloni = int.Parse(Console.ReadLine());

            if (type == "premiere")
            {
                Console.WriteLine("{0:f2}", (redove * koloni) * 12.00);
            }
            else if (type == "normal")
            {
                Console.WriteLine("{0:f2}", (redove * koloni) * 7.50);
            }
            else if (type == "discount")
            {
                Console.WriteLine("{0:f2}", (redove * koloni) * 5.00);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
