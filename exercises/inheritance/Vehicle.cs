using System;

namespace inheritance
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaxOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine("Vroom");
        }

        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The vehicle turns " + direction);
        }
    }
}