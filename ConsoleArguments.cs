using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppI
{
    public class ConsoleArguments
    {
        public static void Run(string[] args)
        {
            int sum = 0;
            foreach (var arg in args)
            {
                var a = int.Parse(arg);
                a += 35;
                sum = sum + a;
                //Console.WriteLine(a);
            }

            Console.WriteLine(sum);
        }
    }
}
