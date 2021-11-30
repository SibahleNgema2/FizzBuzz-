 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter num1");
           Int f = int.Parse(Console.ReadLine());
           Console.WriteLine("Enter num2");
           Int s = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 100; i++)
            {
                if (f % 3 == 0 && f % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (f % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (f % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
                Console.ReadLine();
            }
        }
    }
}
