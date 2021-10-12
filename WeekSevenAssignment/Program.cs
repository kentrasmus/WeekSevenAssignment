using System;

namespace WeekSevenAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int loginAttempts = 0;
            Console.WriteLine("Sisesta kasutajatunnus:");
            string username = Console.ReadLine();
            Console.WriteLine("sisesta parool)");
            string userPassword = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {


                if (username != "admin" || userPassword != "1234")
                    loginAttempts++;
                else
                    break;
            }  
                {
                    Console.WriteLine("Vale PIN, proovi uuesti");
                }

                if (userPassword.Length > 4)
                {
                    if(loginAttempts > 2)&& ()
                }




            


            
            




            



        }
    }
}