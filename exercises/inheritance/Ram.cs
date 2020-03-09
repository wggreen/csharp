using System;

namespace inheritance
{
    public class Ram : Vehicle
    {  // Gas powered truck
        public double FuelCapacity { get; set; }

        public void RefuelTank() { }

        public override void Drive()
        {
            Console.WriteLine($"This is the sound a {MainColor} Ram makes");
        }

        public void Stop()
        {
            Console.WriteLine($"The {MainColor} Ram roars to a stop");
        }
    }
}