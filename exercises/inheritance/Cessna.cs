using System;

namespace inheritance
{
    public class Cessna : Vehicle
    {  // Propellor light aircraft
        public double FuelCapacity { get; set; }

        public void RefuelTank() { }

        public override void Drive()
        {
            Console.WriteLine($"This is the sound a {MainColor} Cessna makes");
        }

        public void Stop()
        {
            Console.WriteLine($"The {MainColor} attempts to stop but goes flying off the runway");
        }
    }
}