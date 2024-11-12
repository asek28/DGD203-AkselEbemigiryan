using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Class
{
    public class GameController
    {
        private Player _player;
        public GameController() 
        {
            _player = new Player();
        }
        public void StartGame()
        {
            Console.WriteLine("What's your name?");
            string playerName = Console.ReadLine(); 
            if (playerName =="" || playerName == null){
                Console.WriteLine("Okay, I get that you're a little shy, but I already knew your name was Andrew.");
                playerName = "Andrew";
            }

            Console.WriteLine("Now you can tell me your age.");
            int playerAge = _player.Age;
            if (int.TryParse(Console.ReadLine(), out int age))
            {
                playerAge = age;

                if (age < 16)
                {
                    Console.WriteLine("Normally you are too young to drive a car, but lucky for you it is a game, you are free to travel as you like, enjoy the journey.");
                }
                else
                {
                    Console.WriteLine("You may be experienced in driving, but let's see how well you can organize it.");
                }

            }
            else 
            {
                Console.WriteLine("You did not enter a valid age. I am using the default age.");
            }

            _player.Initialize(playerName, playerAge);

            Vehicle eVehicle = new Vehicle(100f);
            Vehicle gVehicle = new Vehicle(100f);
            Vehicle dVehicle = new Vehicle(100f);
          
            float Fuel;

            Console.WriteLine($"Welcome {_player.Name} of {_player.Age} years of age, to this game and first choose the fuel type of your car:");
            Console.WriteLine("Car Fuel Types: Electric, Gasoline, Diesel:");
            string fuelType = Console.ReadLine();
            if (fuelType == "Electric")
            {
                
                Console.WriteLine("So you chose an electric car, these are also data:");
                Console.WriteLine("--------");
                Console.WriteLine($"your car has {eVehicle.Fuel} percent fuel left");
                Console.WriteLine("your car consumes 2 percent of the battery per 1km.");
                Console.WriteLine("charging a 1 percent battery costs 1 dollar");
            }
            else if (fuelType == "Gasoline")
            {
                
                Console.WriteLine("So you chose a gasoline powered car, these are also data:");
                Console.WriteLine("--------");
                Console.WriteLine($"your car has {gVehicle.Fuel} percent fuel left");
                Console.WriteLine("your car consumes 1L of gasoline per 1km.");
                Console.WriteLine("1L gasoline cost 2 dollar");

            }
            else if (fuelType == "Diesel")
            {
                
                Console.WriteLine("So you chose a diesel powered car, these are also data:");
                Console.WriteLine("--------");
                Console.WriteLine($"your car has {dVehicle.Fuel} percent fuel left");
                Console.WriteLine("your car consumes 4L diesel per 1km.");
                Console.WriteLine("1L diesel cost 1 dollar");
            }
            else 
            {
                Console.WriteLine("no such fuel type has been found");
            }

            string myVechilce = fuelType;
            string aLocation;
            string ALocation;
            

            Budget Amount = new Budget(150f);

            if (age < 16)
            {
              
                Console.WriteLine("These are the locations you will visit during the day: Home, School, Fuel Station, Shopping Mall, Basketball Court");
                Console.WriteLine($"That's your budget for 1 day: {Amount.Amount}$");
                Console.WriteLine("choose your destination:(School(50km), Shopping Mall(100km))");
                aLocation = Console.ReadLine();
                if (aLocation == "School")
                {
                    eVehicle.UseFuel(6f);
                    Console.WriteLine("It's important to study, of course, and since you're doing your homework, we can move on.");
                    Console.WriteLine($"your car has {eVehicle.Fuel} percent fuel left");
                    Amount.SpendMoney(0f);
                    Console.WriteLine("----------");
                    Console.WriteLine("now choose your new destination:(Fuel Station(80km), Basketball Court(70km))");
                    string bLocation = Console.ReadLine();
                    if (bLocation == "Fuel Station")
                    {
                        eVehicle.UseFuel(20f);
                        Console.WriteLine("battery is full and we're ready to go.");
                        Console.WriteLine($"your car has {eVehicle.Fuel} percent fuel left");
                        Amount.SpendMoney(50f);
                        Console.WriteLine("----------");
                        Console.WriteLine("now choose your new destination:(Shopping Mall(200km), House(100km))");
                        string cLocation = Console.ReadLine();

                        if (cLocation == "Shopping Mall")
                        {
                            eVehicle.UseFuel(60f);
                            Console.WriteLine("it looks like shopping is going to be a bit expensive.");
                            Console.WriteLine($"your car has {eVehicle.Fuel} percent fuel left");
                            Amount.SpendMoney(80f);
                            Console.WriteLine("----------");
                        }
                        else if (cLocation == "House")
                        {
                            eVehicle.UseFuel(35f);
                            Console.WriteLine("come home safe and sound.");
                            Console.WriteLine($"your car has {eVehicle.Fuel} percent fuel left");
                            Amount.SpendMoney(0f);
                            Console.WriteLine("----------");
                        }
                    }
                    else if (bLocation == "Basketball Court")
                    {
                        eVehicle.UseFuel(20f);
                        Console.WriteLine("sport seems to have an important place in your life.");
                        Console.WriteLine($"your car has {eVehicle.Fuel} percent fuel left");
                        Amount.SpendMoney(20f);
                        Console.WriteLine("----------");
                        Console.WriteLine("now choose your new destination:(Shopping Mall(300km), House(150km))");
                        string cLocation = Console.ReadLine();
                        if (cLocation == "Shopping Mall")
                        {
                            eVehicle.UseFuel(55f);
                            Console.WriteLine("it looks like shopping is going to be a bit expensive.");
                            Console.WriteLine($"your car has {eVehicle.Fuel} percent fuel left");
                            Amount.SpendMoney(80f);
                            Console.WriteLine("----------");
                        }
                        else if (cLocation == "House")
                        {
                            eVehicle.UseFuel(45f);
                            Console.WriteLine("come home safe and sound.");
                            Console.WriteLine($"your car has {eVehicle.Fuel} percent fuel left");
                            Amount.SpendMoney(0f);
                            Console.WriteLine("----------");
                        }
                    }
                }
                else if (aLocation == "Shopping Mall")
                {
                    eVehicle.UseFuel(20f);
                    Console.WriteLine("Now that we've done our shopping, we can move on.");
                    Console.WriteLine($"your car has {eVehicle.Fuel} percent fuel left");
                    Amount.SpendMoney(10f);
                    Console.WriteLine("----------");
                    Console.WriteLine("now choose your new destination:(Fuel Station(80km), Basketball Court(70km))");
                    string bLocation = Console.ReadLine();
                    if (bLocation == "Fuel Station")
                    {
                        eVehicle.UseFuel(16f);
                        Console.WriteLine("battery is full and we're ready to go.");
                        Console.WriteLine($"your car has {eVehicle.Fuel} percent fuel left");
                        Amount.SpendMoney(50f);
                        Console.WriteLine("----------");
                        Console.WriteLine("now choose your new destination:(Shopping Mall(200km), House(100km))");
                        string cLocation = Console.ReadLine();

                        if (cLocation == "Shopping Mall")
                        {
                            eVehicle.UseFuel(40f);
                            Console.WriteLine("it looks like shopping is going to be a bit expensive.");
                            Console.WriteLine($"your car has {eVehicle.Fuel} percent fuel left");
                            Amount.SpendMoney(80f);
                            Console.WriteLine("----------");
                        }
                        else if (cLocation == "House")
                        {
                            eVehicle.UseFuel(20f);
                            Console.WriteLine("come home safe and sound.");
                            Console.WriteLine($"your car has {eVehicle.Fuel} percent fuel left");
                            Amount.SpendMoney(0f);
                            Console.WriteLine("----------");
                        }
                    }
                    else if (bLocation == "Basketball Court")
                    {
                        eVehicle.UseFuel(10f);
                        Console.WriteLine("sport seems to have an important place in your life.");
                        Console.WriteLine($"your car has {eVehicle.Fuel} percent fuel left");
                        Amount.SpendMoney(20f);
                        Console.WriteLine("----------");
                        Console.WriteLine("now choose your new destination:(Shopping Mall(300km), House(150km))");
                        string cLocation = Console.ReadLine();
                        if (cLocation == "Shopping Mall")
                        {
                            eVehicle.UseFuel(60f);
                            Console.WriteLine("it looks like shopping is going to be a bit expensive.");
                            Console.WriteLine($"your car has {eVehicle.Fuel} percent fuel left");
                            Amount.SpendMoney(80f);
                            Console.WriteLine("----------");
                        }
                        else if (cLocation == "House")
                        {
                            eVehicle.UseFuel(30f);
                            Console.WriteLine("come home safe and sound.");
                            Console.WriteLine($"your car has {eVehicle.Fuel} percent fuel left");
                            Amount.SpendMoney(0f);
                            Console.WriteLine("----------");
                        }
                    }
                }
            }
            else
            {
               
                Console.WriteLine("These are the locations you will visit during the day: Home, School, Workplace, Fuel Station, Restaurant, Museum");
                Console.WriteLine($"That's your budget for 1 day: {Amount.Amount}$");
                Console.WriteLine("choose your destination:(School(50km), Workplace(100km))");
                ALocation = Console.ReadLine();
                if (ALocation == "Workplace")
                {
                    eVehicle.UseFuel(20f);
                    Console.WriteLine("Should we take a break from work? Where should we go now?");
                    Console.WriteLine($"your car has {eVehicle.Fuel} percent fuel left");
                    Amount.SpendMoney(0f);
                    Console.WriteLine("----------");
                    Console.WriteLine("now choose your new destination:(Fuel Station(80km), Museum(50km))");
                    string BLocation = Console.ReadLine();
                    if (BLocation == "Fuel Station")
                    {
                        eVehicle.UseFuel(20f);
                        Console.WriteLine("battery is full and we're ready to go.");
                        Console.WriteLine($"your car has {eVehicle.Fuel} percent fuel left");
                        Amount.SpendMoney(50f);
                        Console.WriteLine("----------");
                        Console.WriteLine("now choose your new destination:(Resturant(200km), House(100km))");
                        string CLocation = Console.ReadLine();

                        if (CLocation == "Resturant")
                        {
                            eVehicle.UseFuel(35f);
                            Console.WriteLine("this restaurant looks like it's going to be expensive and don't drink too much alcohol.");
                            Console.WriteLine($"your car has {eVehicle.Fuel} percent fuel left");
                            Amount.SpendMoney(80f);
                            Console.WriteLine("----------");
                        }
                        else if (CLocation == "House")
                        {
                            eVehicle.UseFuel(25f);
                            Console.WriteLine("come home safe and sound.");
                            Console.WriteLine($"your car has {eVehicle.Fuel} percent fuel left");
                            Amount.SpendMoney(0f);
                            Console.WriteLine("----------");
                        }
                    }
                    else if (BLocation == "Museum")
                    {
                        eVehicle.UseFuel(40f);
                        Console.WriteLine("I see you're a very intellectual person.");
                        Console.WriteLine($"your car has {eVehicle.Fuel} percent fuel left");
                        Amount.SpendMoney(20f);
                        Console.WriteLine("----------");
                        Console.WriteLine("now choose your new destination:(Resturant(300km), House(150km))");
                        string CLocation = Console.ReadLine();
                        if (CLocation == "Resturant")
                        {
                            eVehicle.UseFuel(60f);
                            Console.WriteLine("this restaurant looks like it's going to be expensive and don't drink too much alcohol.");
                            Console.WriteLine($"your car has {eVehicle.Fuel} percent fuel left");
                            Amount.SpendMoney(80f);
                            Console.WriteLine("----------");
                        }
                        else if (CLocation == "House")
                        {
                            eVehicle.UseFuel(30f);
                            Console.WriteLine("come home safe and sound.");
                            Console.WriteLine($"your car has {eVehicle.Fuel} percent fuel left");
                            Amount.SpendMoney(0f);
                            Console.WriteLine("----------");

                        }
                    }
                }
                else if (ALocation == "School")
                {
                    eVehicle.UseFuel(10f);
                    Console.WriteLine("Now that you've dropped your kid off at school, we can move on.");
                    Console.WriteLine($"your car has {eVehicle.Fuel} percent fuel left");
                    Amount.SpendMoney(0f);
                    Console.WriteLine("----------");
                    Console.WriteLine("now choose your new destination:(Fuel Station(80km), Museum(50km))");
                    string BLocation = Console.ReadLine();
                    if (BLocation == "Fuel Station")
                    {
                        eVehicle.UseFuel(20f);
                        Console.WriteLine("battery is full and we're ready to go.");
                        Console.WriteLine($"your car has {eVehicle.Fuel} percent fuel left");
                        Amount.SpendMoney(50f);
                        Console.WriteLine("----------");
                        Console.WriteLine("now choose your new destination:(Resturant(200km), House(100km))");
                        string CLocation = Console.ReadLine();

                        if (CLocation == "Resturant")
                        {
                            eVehicle.UseFuel(35f);
                            Console.WriteLine("this restaurant looks like it's going to be expensive and don't drink too much alcohol.");
                            Console.WriteLine($"your car has {eVehicle.Fuel} percent fuel left");
                            Amount.SpendMoney(80f);
                            Console.WriteLine("----------");
                        }
                        else if (CLocation == "House")
                        {
                            eVehicle.UseFuel(25f);
                            Console.WriteLine("come home safe and sound.");
                            Console.WriteLine($"your car has {eVehicle.Fuel} percent fuel left");
                            Amount.SpendMoney(0f);
                            Console.WriteLine("----------");
                        }
                    }
                    else if (BLocation == "Museum")
                    {
                        eVehicle.UseFuel(40f);
                        Console.WriteLine("I see you're a very intellectual person.");
                        Console.WriteLine($"your car has {eVehicle.Fuel} percent fuel left");
                        Amount.SpendMoney(20f);
                        Console.WriteLine("----------");
                        Console.WriteLine("now choose your new destination:(Resturant(300km), House(150km))");
                        string CLocation = Console.ReadLine();
                        if (CLocation == "Resturant")
                        {
                            eVehicle.UseFuel(60f);
                            Console.WriteLine("this restaurant looks like it's going to be expensive and don't drink too much alcohol.");
                            Console.WriteLine($"your car has {eVehicle.Fuel} percent fuel left");
                            Amount.SpendMoney(80f);
                            Console.WriteLine("----------");
                        }
                        else if (CLocation == "House")
                        {
                            eVehicle.UseFuel(30f);
                            Console.WriteLine("come home safe and sound.");
                            Console.WriteLine($"your car has {eVehicle.Fuel} percent fuel left");
                            Amount.SpendMoney(0f);
                            Console.WriteLine("----------");

                        }
                    }
                }
            }


            
            
       
       


            

           /*ictionary<string, float> distances = new Dictionary<string, float>()
            {
                { "Home", 0 },
                { "School", 5 },
                { "Fuel Station", 3 },
                { "Shopping Mall", 8 },
                { "Basketball Court", 2 },
                { "Workplace", 10 },
        
            };
            string currentLocation = "Home";
            while (true) 
            {
                Console.WriteLine("Where do you want to go? (or type 'exit' to quit)");
                string destination = Console.ReadLine();

                if (destination == "exit")
                {
                    Console.WriteLine("Thank you for playing!");
                    break;
                }

                if (distances.ContainsKey(destination))
                {
                    Console.WriteLine("Invalid location. Please choose a valid location.");
                    continue;
                }

                float distance = distances[destination] - distances[currentLocation];

                if (Vehicle.Drive(distance)) 
                {
                    continue; 
                }

               
                Console.WriteLine(<span> class="math-inline">"You traveled {distance:F2} km to {destination}.");
                Console.WriteLine(<span>"Remaining fuel: {vehicle.FuelLevel:F2}");
                Console.WriteLine($"Remaining budget: {budget.CurrentAmount:C}");
            }*/





        }
    }
}
