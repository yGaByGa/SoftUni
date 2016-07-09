using System;

namespace _13.Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            double hollydays = double.Parse(Console.ReadLine());
            double weekends = double.Parse(Console.ReadLine());

            double normal =  0;
            double bonus = 0;
            double result = 0;
            double all = 0;
            
            if (year == "leap")
            {
                normal = (48 - weekends) * 3 / 4;
                result = hollydays * 2 / 3;
                bonus = (normal + result + weekends) * 15 / 100;
                all = normal + result + weekends + bonus;
                all = Math.Floor(all);

                Console.WriteLine("{0}", all );
            }
            else if (year == "normal")
            {
                normal = (48 - weekends) * 3 / 4;
                result = hollydays * 2 / 3;
                all = normal + result + weekends;
                all = Math.Floor(all);

                Console.WriteLine("{0}", all );
            }
            else
            {
                Console.WriteLine("error");
                
            }
        }
    }
}
