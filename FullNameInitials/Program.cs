using System;

namespace FullNameInitials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisesta oma nimi:");
            string username = Console.ReadLine();

            Console.WriteLine("Palun sisesta oma perekonna nimi:");
            string usernamelast = Console.ReadLine();

            Console.WriteLine($"Hello, {username[0]}. {usernamelast[0]}.! ");

        }
    }
}
