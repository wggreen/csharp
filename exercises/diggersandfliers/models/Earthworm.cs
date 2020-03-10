using System;

namespace diggersandfliers
{
    public class Earthworm : IDigger
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public void Dig()
        {
            Console.WriteLine("The animal is now digging");
        }
    }
}