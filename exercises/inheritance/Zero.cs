using System;

namespace inheritance
{
    public class Zero : Vehicle
    {  // Electric motorcycle
        public double BatteryKWh { get; set; }

        public void ChargeBattery() { }

        public override void Drive()
        {
            Console.WriteLine($"This is the sound a {MainColor} Zero makes");
        }

        public void Stop()
        {
            Console.WriteLine($"The {MainColor} Zero stops");
        }
    }
}