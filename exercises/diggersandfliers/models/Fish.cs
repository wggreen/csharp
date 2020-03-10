using System;

namespace diggersandfliers
{
    public class Fish : ISwimmer
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public void Swim()
        {
            Console.WriteLine("The animal is now swimming");
        }
    }
}