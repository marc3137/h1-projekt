using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace bilforhandler
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("welcome to the shop. Here you see the collection of cars available:");
            
            Console.WriteLine("1. Renault Megane");
            Console.WriteLine("2. Kia Ceed");
            Console.WriteLine("3. Mercedes A200");
            Console.WriteLine("4. Tesla Model S 75d");

            Console.WriteLine("");

            Console.WriteLine("For more detailed information on all the cars type showall");
            Console.WriteLine("type choose, if you want to choose a car to look at");
            Console.WriteLine("You can type quit at any time to quit the program");

            Cars t = new Cars();

            bool isRunning = true;
            while (isRunning == true)
            {
                string input = Console.ReadLine();

                string[] inputArray = input.Split(' ');

                switch (inputArray[0].ToLower())
                {

                    case "showall":
                        t.sql(t.carModels);
                        break;
                    case "choose":
                       t.ChooseCar(t.carModels);
                       break;

                    case "quit":
                        isRunning = false;
                        break;
                    case "modify":
                        t.modify(t.carModels);
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
                Console.WriteLine("");
                Console.WriteLine("Do you want to modify or buy it as it is?");
                

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
                Console.WriteLine(carModels[2] + " Costs 402.300 and comes with a 2.0, 184 hp engin. It drives 15,4km/L");
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
        public void sql(string[] carModels)
        {
            Console.Clear();
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=cars;";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            string query = "SELECT * FROM car";

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;

            databaseConnection.Open();

            reader = commandDatabase.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine(reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3) + " " + reader.GetString(4));
            }
            Console.WriteLine("Type choose if you want to look at a specific model");
        }
        //array for engines
        public string[] engines = new string[] {"1. 115hp + 0 DKK", "2. 125hp + 10.000 DKK", "3. 135hp + 20.000" };
        public string[] tires = new string[] { "1. standard tires", "2. upgraded tires + 3000 DKK" };
        public string[] interior = new string[] { "1. standard interior", "2. upgraded interior + 3000 DKK" };

        public void modify(string[] carModels)
        {
            Console.WriteLine("what do you want to modify?");
            Console.WriteLine("1. Engine");
            Console.WriteLine("2. Tires");
            Console.WriteLine("3. Interior");
            string modify = Console.ReadLine();

            if (modify == "1" || modify == "engine")
            {
                Console.WriteLine("The 3 upgrades for the engine are: " + engines[0] + ", " + engines[1] + ", " + engines[2]);
            }
            else if (modify == "2" || modify == "tires")
            {
                Console.WriteLine("The 2 upgrades for the tires are: " + tires[0] + ", " + tires[1]);
            }
            else if (modify == "3" || modify == "interior")
            {
                Console.WriteLine("The 2 upgrades for the interior: " + interior[0] + ", " + interior[1]);
            }
            else
            {
                Console.WriteLine("please choose one of the options showed to you");
            }
        }
    }
}