using System;

namespace _02.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            double chasove = double.Parse(Console.ReadLine());
            double dni = double.Parse(Console.ReadLine());
            double slujiteli = double.Parse(Console.ReadLine());

            double neefektivniprocent = dni * 10 / 100;
            double efektivni = dni - neefektivniprocent;
            double evektivniChasove =( efektivni * 8 );
            double uzvunredno = slujiteli * (2 * dni);

            double obshoChasove = evektivniChasove + uzvunredno;
            
            double arazlika = Math.Abs(chasove - obshoChasove);
            double razlika = Math.Ceiling(arazlika);


            if (obshoChasove >= chasove)
            {
                Console.WriteLine("Yes!{0} hours left." , razlika);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed." ,razlika);
            }
            
        } 
    }
}
