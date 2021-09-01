using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_conditionals_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("What's your name?");
            string inputName = Console.ReadLine().ToLower();

            //2
            switch (inputName)
            {
                //3
                case "fred": //Same as checking: if (inputName == "fred") 
                    Console.WriteLine("Hey Fred, let's go golfing.");
                    //4
                    break;
                case "karl": Console.WriteLine("Let's hang.");
                    break;
                case "john": Console.WriteLine("Sorry, I'm busy right now.");
                    break;
                default: Console.WriteLine("Hey " + char.ToUpper(inputName[0]) + inputName.Substring(1) + ", can I call you back.");
                    //same as else
                    break;
            }

            Console.Write("What's your friend's name? ");
            string friend = Console.ReadLine().ToLower();

            switch (friend)
            {
                case "david": Console.WriteLine("David is a great friend!");
                    break;
                case "lindy": Console.WriteLine("Lindy is very caring.");
                    break;
                case "barb": Console.WriteLine("Barb is a wonderful listener.");
                    break;
                default: Console.WriteLine("I don't know " + char.ToUpper(friend[0]) + friend.Substring(1) + ".");
                    break;
            }
        }
    }
}
