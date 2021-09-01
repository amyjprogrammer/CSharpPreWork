using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            while(number <= 100)
            {
                Console.WriteLine(number); //print 0 to 100 skipping everything 5th
                number += 5;
            }

            Console.ReadLine();

            int number1 = 100;

            for (int i = 1; i <= number1; i++)
            {
                Console.WriteLine(i); //prints 1 to 100
            }
        }
    }
}
