using System;

namespace ClassIntro
{
    public class Car
    {
        private int _milesDriven = 0;
        public string Make { get; set; }

        public string Model { get; set; }
        public int Year { get; set; }
        public bool NeedsMaintenance { get; set; } = false;
        public bool IsClean { get; set; } = false;
        public string Description
        {
            get
            {
                return $"{Year} {Make} {Model}";
            }
        }
        public void Drive(int miles)
        {
            _milesDriven += miles;
            if (_milesDriven > 10000)
            {
                NeedsMaintenance = true;
            }
        }
        public void Service()
        {
            NeedsMaintenance = false;
        }

        public void Service(bool addCleaningService)
        {
            NeedsMaintenance = false;

            if (addCleaningService)
            {
                IsClean = true;
            }
        }

        public Car(int milesDriven)
        {
            _milesDriven = milesDriven;
        }

        public Car(int milesDriven, string make, string model, int year)
        {
            _milesDriven = milesDriven;
            Make = make;
            Model = model;
            Year = year;
        }
    }
}
