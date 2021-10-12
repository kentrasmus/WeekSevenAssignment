using System;

namespace RandomLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisesta oma eesnimi");
            string nimi = Console.ReadLine();


            Random rnd = new Random();
            int asi = rnd.Next(0, nimi.Length - 1);
            Console.WriteLine(nimi[asi]);

        }
    }
}
