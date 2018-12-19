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

            Console.WriteLine("welcome to the shop. Here you see the collection of cars available:");
            Console.WriteLine("1. Renault Megane - price: 206.900");
            Console.WriteLine("2. Kia Ceed - price: 214.999");
            Console.WriteLine("3. Mercedes A200 - price: 402.300");
            Console.WriteLine("4.Tesla Model S 75d - price: 669.820");
            Console.WriteLine("");

            Console.WriteLine("write the number of the car you want to look at");

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
        public string[] carModels = new string[] { "1. Renault Megane", "2. Kia Ceed", "3. Mercedes A200", "4. Tesla Model S 75d" };

        public void ShowAllCars(string[] carModels)
        {
            foreach (var car in carModels)
            {
                Console.WriteLine(car);
            }
        }

        public void ChooseCar(string[] carModels)
        {
            Console.WriteLine("write the number of the car you want to look at");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.Clear();
                Console.WriteLine("You chose the " + carModels[0]);
                Console.WriteLine("");
                Console.WriteLine(carModels[0] + " Costs 206.900 and comes with a 1.4, 115 hp engine. It drives 23km/L.");
            }
            else if (userInput == "2")
            {
                Console.Clear();
                Console.WriteLine("You chose the " + carModels[1]);
                Console.WriteLine("");
                Console.WriteLine(carModels[1] +  " Costs  214.999 and comes with a 1.6, 136 hp engine. It drives 17km/L");
            }
            else if (userInput == "3")
            {
                Console.Clear();
                Console.WriteLine("You chose the " + carModels[2]);
                Console.WriteLine("");
                Console.WriteLine(carModels[2] + "Costs 402.300 and comes with a 2.0, 184 hp engin. It drives 15,4km/L");
            }
            else if (userInput == "4")
            {
                Console.Clear();
                Console.WriteLine("You chose the " + carModels[3]);
                Console.WriteLine("");
                Console.WriteLine(carModels[3] + " Costs 669.820 and comes with an electric engine and a 100kWh battery");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("please write a valid input");
            }
        }    
    }
}