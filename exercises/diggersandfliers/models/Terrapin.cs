using System;

namespace diggersandfliers
{
    public class Terrapin : IWalker, ISwimmer
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

        public void Swim()
        {
            Console.WriteLine("The animal is now swimming");
        }
    }
}