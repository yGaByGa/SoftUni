using System;

namespace _01.Demo
{
    class Demo
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(new string('*' , 10));
            // zamestva Console.WriteLine('**********');

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(new string('*' , 10));
            }
        }
    }
}
