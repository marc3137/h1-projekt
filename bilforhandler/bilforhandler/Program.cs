using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilforhandler
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Type showall if you want to see the cars");
            Console.WriteLine("");

            Cars t = new Cars();


            bool isRunning = true;
            while (isRunning == true)
            {
                string input = Console.ReadLine();

                string[] inputArray = input.Split(' ');

                switch (inputArray[0].ToLower())
                {
                    case "showall":
                        t.ShowAllCars(t.carModels);
                        break;

                    case "choose":
                       t.ChooseCar(t.carModels);
                       break;

                    case "quit":
                        isRunning = false;
                        break;

                    default:
                        Console.WriteLine("not a valid input");
                        break;
                }
            }

        }
    }

    class Cars
    {
        public string[] carModels = new string[] { "Renault Megane", "Kia Ceed", "Mercedes A200", "Tesla Model S 75d" };

        public void ShowAllCars(string[] carModels)
        {
            foreach (var car in carModels)
            {
                Console.WriteLine(car);
            }
        }


        public void ChooseCar(string[] carModels)
        {
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("You chose the " + carModels[0]);
            }
            else if (userInput == "2")
            {
                Console.WriteLine("You chose the " + carModels[1]);
            }
            else if (userInput == "3")
            {
                Console.WriteLine("You chose the " + carModels[2]);
            }
            else if (userInput == "4")
            {
                Console.WriteLine("You chose the " + carModels[3]);
            }
            else
            {
                Console.WriteLine("please write a valid input");
            }
        }    
    }
}
