//Принтира общото време на 3ма състезатели от секунди в 0:02 формат


using System;
namespace demo8
{
    class Program
    {
        static void Main(string[] args)
        {
            int fistRuner = int.Parse(Console.ReadLine());
            int secondRuner = int.Parse(Console.ReadLine());
            int thertRuner = int.Parse(Console.ReadLine());

            int sec = fistRuner + secondRuner + thertRuner;
            int min = 0;

            if (sec >= 120)
            {
                min+=2;
                sec -= 120;
            }
            else if (sec >= 60)
            {
                min++;
                sec = sec - 60;
            }

            if (sec < 10)
            {
                Console.WriteLine("{0}:0{1}", min, sec);
            }
            else
            {
                Console.WriteLine("{0}:{1}", min, sec);
            }
        }
    }
}
