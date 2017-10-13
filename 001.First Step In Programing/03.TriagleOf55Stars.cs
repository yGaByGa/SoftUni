//Принтира триъгълник от звезди според числото подадено на конзолата.

using System;

namespace _03.TriagleOf55Stars
{
    class TriagleOf55Stars
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a:");
            int a = int.Parse(Console.ReadLine());

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine(new string('*', i + 1));
            }
        }
    }
}
