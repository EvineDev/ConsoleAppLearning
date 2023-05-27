using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppI
{
    public class Fizzbuzz
    {
        public static void Run()
        {
            var fizzNumbers = new int[] {
                3, 6, 9, 12, 15, 18, 21, 24, 27, 30,
            };

            var buzzNumbers = new int[] {
                5, 10, 15, 20, 25, 30,
            };

            for (var i = 1; i <= 100; ++i)
            {
                bool shouldPrintNumber = true;
                if (i / 3.0 - i / 3 == 0)
                {
                    shouldPrintNumber = false;
                    Console.Write("Fizz");
                }

                if (i % 5 == 0)
                {
                    shouldPrintNumber = false;
                    Console.Write("Buzz");
                }

                if (shouldPrintNumber)
                {
                    Console.Write(i);
                }

                Console.WriteLine();
            }
        }
    }
}
