using System;

namespace inheritance
{
    public class Tesla : Vehicle
    {  // Electric car
        public double BatteryKWh { get; set; }

        public void ChargeBattery() { }

        public override void Drive()
        {
            Console.WriteLine($"This is the sound a {MainColor} Tesla makes");
        }

        public void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla silently screeches to a silent halt");
        }
    }
}