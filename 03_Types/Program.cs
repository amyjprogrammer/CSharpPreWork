using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isLoggedIn = true;
            Console.WriteLine(isLoggedIn);

            decimal accountBalance = 8000.30m;
            Console.WriteLine(accountBalance);

            short practiceNum = 23;
            float practiceFloat = 3.33f;
            float anotherFloat = 15.25456f;
            int practiceInt = -3500;
            string practiceString = "HI!";

            Console.WriteLine("Testing practice- {0}, ${1}, {2}, {3}, {4}", practiceNum, 
                practiceFloat, anotherFloat, practiceInt, practiceString);

            Console.ReadLine();
        }
    }
}
