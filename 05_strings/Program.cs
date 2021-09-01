using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName;
            string wholeName = "Amy Jones";

            string first = "The cars we sell are ";
            string second = "BMW, Lexus, and Mercedes.";
            Console.WriteLine(first + second);
            //result: The cars we sell are BMW, Lexus, and Mercedes
            Console.WriteLine(first + " " + second);//adds a space after the first string

            string firstName = "Jenn";
            string lastName = "Williams";

            Console.WriteLine("Her name is {0} {1}.", firstName, lastName);
            Console.WriteLine("{0} {1}", first, second);
            //result Her name is Jenn Williams.

            string fName = "Robin";
            string lName = "Holler";
            Console.WriteLine($"Her name is {fName} {lName}");
            Console.WriteLine($"The name is {firstName} {lastName}");
        }
    }
}
