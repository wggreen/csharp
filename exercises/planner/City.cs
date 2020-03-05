using System;
using System.Collections.Generic;

namespace planner
{
    public class City
    {
        public string Name { get; set; }
        public string Mayor { get; set; }
        public int Year { get; set; }
        public List<Building> Buildings = new List<Building>();

        public void addBuilding(Building newBuilding)
        {
            Buildings.Add(newBuilding);
        }

    }
}