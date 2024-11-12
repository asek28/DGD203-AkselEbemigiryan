using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Class
{
    
    public class Vehicle
    {
        public string Type { get; set; }
        public float Fuel { get; set; }
        public float FuelConsumpiton { get; set; }
        public float FuelPrice { get; set; }

      

        public Vehicle(float fuel, float fuelConsumption)
        {
            Fuel = fuel;
            FuelConsumpiton = fuelConsumption;
        }


        public float eFuel {  get; private set; }
        public float gFuel { get; private set; }
        public float dFuel { get; private set; }



        public void Drive(float distance)
        {
            if (distance <= 0)
            {
                Console.WriteLine("the distance cannot be less than 0.");
                return;
            }

            float fuelUsed = distance * FuelConsumpiton;
            if (fuelUsed > Fuel)
            {
                Console.WriteLine($"Not enough fuel! Distance traveled: {0:F2} km", Fuel / FuelConsumpiton);
            }
            else
            {
                Fuel = Fuel - fuelUsed;
                Console.WriteLine($"{distance:F2}km traveled. Remaining fuel: {Fuel:F2}");
            }
        }


        public void UseFuel(float fuel)
        {
            Fuel = Fuel - fuel < 0f ? 0f : Fuel - fuel;
        }









        public Vehicle(float fuel)
        {
            fuel = Math.Clamp(fuel, 0f, 100f);

            if (fuel < 0)
            {
                fuel = 0;
            }
            Fuel = fuel;
        }


        public void FuelConsumption(float fuel)
        {
            Fuel = Math.Clamp(Fuel - fuel, 0f, 100f);


        }
    }

}
