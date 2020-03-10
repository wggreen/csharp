using System;

namespace flowers
{
    public class Tulip : IGetWell
    {
        public string Color { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public double Cost { get; set; }

        public string WaterSchedule { get; set; }

        public bool Thorny { get; set; }

        public bool fragrant { get; set; }

        public double StemLength { get; set; }
    }
}