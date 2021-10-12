using System;

namespace DuckSong
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine($"{i} Little ducks wnt swimming one day, over the hill and far away motherduck said, quack quack quack, but only {i - 1} duck came back");
                Console.WriteLine("");
                if (i == 1)
                {
                    Console.WriteLine("1 Little ducks wnt swimming one day, over the hill and far away motherduck said, quack quack quack, but no little ducks came back!");
                    Console.WriteLine("");
                    Console.WriteLine("Sad mother duck went out one day over the hill and far away,the sad duck said, quack quack quack quack and all of the 5 little ducks came back!.");
                }
            }
        }
 }   }   
