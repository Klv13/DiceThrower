using System;

namespace NumberCracker
{
    class Program
    {
        static void Main(string[] args)
        {
           

            

            

            Console.WriteLine("Enter passcode: ");

            string Codes = Console.ReadLine();

            int Code = int.Parse(Codes);

            

            int guess = 0;


            while(guess != Code)
            {
                Console.WriteLine(guess);
                guess++;
       
            }

            Console.WriteLine("Guess: " + guess);
            Console.WriteLine("\n\nIf the digits in gues != in Code just put 0s infront");

            Console.WriteLine("The Actual input at start: " +Codes);

            

            

            Console.ReadLine();
            
        }


        
    }
}
