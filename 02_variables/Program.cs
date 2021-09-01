using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //1  //2   //3
            string firstName = "Paul";
            Console.WriteLine(firstName);
            string lastName = "Johnson";
            int birthYear; //Not initialized
            birthYear = 1990;
            float numPi = 3.14f;


            Console.WriteLine(lastName);
            Console.WriteLine(birthYear);
            Console.WriteLine("{0} {1} was born {2}", firstName, lastName, birthYear);
            Console.WriteLine("Pi is equal to {0}", numPi);
            Console.ReadLine();
        }
    }
}
