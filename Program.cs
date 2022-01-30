using System;
using System.Linq;

namespace Teori
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input first size: ");
            int terning = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second size: ");
            int terning1 = int.Parse(Console.ReadLine());
            int attemtps = 0;
            int roll = 0;
            int roll1 = 1;
            int[] AttemtpsAry = new int[20000];
            Random numGen = new Random();


            for (int i = 0; i < AttemtpsAry.Length; i++)
            {
                while (roll + roll1 != terning + terning1)
                {
                    roll = numGen.Next(1, terning + 1);
                    roll1 = numGen.Next(1, terning1 + 1);

                    Console.WriteLine(roll + " : " + roll1);

                    attemtps++;
                   

                }

                Console.WriteLine("Attempts: " + attemtps);
                AttemtpsAry[i] = attemtps;
                attemtps = 0;
                roll = 0;
                roll1 = 0;
            }

            double snit = Queryable.Average(AttemtpsAry.AsQueryable());

            Console.WriteLine("Average attempts is: " + snit);


            Console.WriteLine("\n\n press any key to exit");
            Console.ReadKey();
        }
    }
}
