using System;

namespace diggersandfliers
{
    public class Parakeet : IFlier
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public void Fly()
        {
            Console.WriteLine("The animal is now flying");
        }
    }
}