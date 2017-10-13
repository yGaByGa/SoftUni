//Събиране на стрингове(първо име, фамилия, години и град)

using System;

namespace _004.NameAgeTown
{
    class NameAgeTown
    {
        static void Main(string[] args)
        {
            var firstName = Console.ReadLine();
            var lastName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var town = Console.ReadLine();

            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}. ", firstName, lastName, age, town);
        }
    }
}
