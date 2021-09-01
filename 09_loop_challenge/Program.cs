using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_loop_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num = 525;
            
            for(int i = 500; i <= num; i++)
            {
                Console.WriteLine(i);
            }

            int num2 = 100;
            for (int i = 0; i <= num2; i += 5)
            {
                Console.WriteLine(i);
            }
            

            int fizz = 100;
            for (int i = 1; i <= fizz; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
