using System;

namespace diggersandfliers
{
    public class Finch : IFlier
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public void Fly()
        {
            Console.WriteLine("The animal is now flying");
        }
    }
}