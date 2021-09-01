using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(5 + 2);//result 7
            Console.WriteLine(10 - 6);//result 4
            Console.WriteLine(2 * 3);//result 6
            Console.WriteLine(10 / 2);//result 5

            Console.WriteLine(10 % 2);//result 0, because no remainder
            Console.WriteLine(10 % 9 );//result 1, because 10/9 = 1 with remainder of 1
            Console.WriteLine(16 % 3);//result 1, because a remainder of 1
            Console.WriteLine(19 % 5);//result of 4

            //practice
            Console.WriteLine(10 % 3);//result 1
            Console.WriteLine(9 % 2);//result 1
            Console.WriteLine(100 % 22);//result 12
            Console.WriteLine(13 % 12);//result 1

          
        }
    }
}
