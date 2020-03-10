using System;

namespace diggersandfliers
{
    public class Rattlesnake : IWalker
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public void Walk()
        {
            Console.WriteLine("The animal is now walking");
        }

        public void Run()
        {
            Console.WriteLine("The animal is now running");
        }
    }
}