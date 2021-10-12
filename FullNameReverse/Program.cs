using System;

namespace FullNameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sisesta oma nimi");
            string Nimi = Console.ReadLine();
            
            if (Nimi.Length >= 5) 
            {
                for (int i = Nimi.Length - 1; i >= 1; i--)
                {
                    Console.WriteLine(Nimi[i]);
                }


            }
            else
            {
                Console.WriteLine(Nimi);

            }
        }
    }
}
