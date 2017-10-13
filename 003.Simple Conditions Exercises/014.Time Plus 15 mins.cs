using System;

namespace _14.TimePlus15min
{
    class TimePlus15min
    {
        static void Main(string[] args)
        {
            double chas = double.Parse(Console.ReadLine());
            double min = double.Parse(Console.ReadLine());

            double newtime = min + 15;

            if (newtime>=60)
            {
                chas++;
                newtime -= 60;
            }
            if (chas==24)
            {
                chas-=24;
            }
            if (newtime < 10)
            {
                Console.WriteLine("{0}:0{1}", chas, newtime);
            }
            else if (newtime <= 59)
            {
                Console.WriteLine("{0}:{1}", chas, newtime);
            }
        }
    }
}
