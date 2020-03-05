using System;

namespace planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            FiveOneTwoEigth.Stories = 3;
            FiveOneTwoEigth.Width = 2;
            FiveOneTwoEigth.Depth = 4;
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Kevin");
            Console.Clear();

            Building OneTwoThree = new Building("123 Main St");
            OneTwoThree.Stories = 4;
            OneTwoThree.Width = 3;
            OneTwoThree.Depth = 5;
            OneTwoThree.Construct();
            OneTwoThree.Purchase("James");

            City ItCity = new City();

            ItCity.addBuilding(FiveOneTwoEigth);
            ItCity.addBuilding(OneTwoThree);

            foreach (Building building in ItCity.Buildings)
            {
                Console.WriteLine(building.ToString());
            }
        }


    }
}