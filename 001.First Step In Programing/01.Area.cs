//A x B = Area
// Намиране на лицето на правоъгълник


using System;

namespace Area
{
    class Area
    {
        static void Main()
        {
            Console.WriteLine("enter a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter b:");
            int b = int.Parse(Console.ReadLine());
            int result = a * b;

            Console.WriteLine("This area is : {0}", result);
        }
    }
}
