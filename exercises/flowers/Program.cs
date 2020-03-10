using System;

namespace flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            var myRose = new Rose()
            {
                Color = "Red",
                Name = "That One Rose",
                Type = "That One Type of Rose",
                Cost = 1.50,
                WaterSchedule = "Constantly",
                Thorny = true,
                fragrant = true,
                StemLength = 500.00
            };
            var mySunflower = new Sunflower();
            var myLily = new Lily();
            var myIris = new Iris();
        }
    }
}
