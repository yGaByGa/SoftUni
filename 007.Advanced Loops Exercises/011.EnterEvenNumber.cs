using System;

namespace _11.EnterEvenNumber
{
    class EnterEvenNumber
    {
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                try
                {
                    Console.Write("Enter even number: ");
                    n = int.Parse(Console.ReadLine());

                    if (n % 2 == 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid number!");
                        Console.Write("Enter even number: ");
                        n = int.Parse(Console.ReadLine());
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid number!");
                }
            } while (true);
            Console.WriteLine("Even number entered: {0}", n);
        }
    }
}
