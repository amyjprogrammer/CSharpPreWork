using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Types_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            //my two int variables
            int firstInt = 24;
            int secondInt;

            Console.WriteLine(firstInt);

            //my two string variables
            string firstString = "Howdy";
            string secondString;
            secondString = "Teacher";

            Console.WriteLine(firstString);

            //my two bool variables
            bool firstBool = true;
            bool secondBool;

            Console.WriteLine(firstBool);

            //my two float variables
            float firstFloat = 3.14f;
            float secondFloat;

            Console.WriteLine(firstFloat);

            //my two double variables
            double firstDouble = 3.3333333;
            double secondDouble;

            Console.WriteLine(firstDouble);

            //my two decimal variables
            decimal firstDecimal = 5.55555555555555m;
            decimal secondDecimal;

            Console.WriteLine(firstDecimal);


            //Silver Badge

            Console.WriteLine(firstString + " " + secondString);
            //another way to do it
            Console.WriteLine("{0} {1}", firstString, secondString);

            //Gold Badge
            int birthYear = 1977;
            Console.WriteLine(birthYear.ToString());
            //or
            int birYear = Int32.Parse("1977");
            Console.WriteLine(birYear);

        }
    }
}
