using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_classes_and_objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating the objects
            Donut dougDonut = new Donut();
            Donut chrisDonut = new Donut();
            Donut nickDonut = new Donut();

            //setting the property values
            dougDonut.Filling = "cherry";
            dougDonut.Price = 3;
            dougDonut.Type = "normal";
            dougDonut.IsSpecial = true;
            dougDonut.Sprinkles = false;
            dougDonut.isRound = true;

            chrisDonut.Filling = "none";
            chrisDonut.Price = 2;
            chrisDonut.Type = "small";
            chrisDonut.IsSpecial = false;
            chrisDonut.Sprinkles = false;
            chrisDonut.isRound = false;

            nickDonut.Filling = "chocolate";
            nickDonut.Price = 3;
            nickDonut.Type = "normal";
            nickDonut.IsSpecial = true;
            nickDonut.Sprinkles = true;
            nickDonut.isRound = true;

            Console.WriteLine(nickDonut.Filling);
        }
    }
}
