using System;
using System.Collections.Generic;

namespace flowers
{
    public class FlowerShop
    {
        public List<Rose> Roses = new List<Rose>();

        public List<Iris> Irises = new List<Iris>();

        public List<Sunflower> Sunflowers = new List<Sunflower>();

        public List<Lily> Lilies = new List<Lily>();

        public List<IMothersDay> MakeMothersDayArrangement()
        {
            List<IMothersDay> Arrangement = new List<IMothersDay>();
            Arrangement.Add(new Rose());
            Arrangement.Add(new Rose());
            Arrangement.Add(new Iris());
            Arrangement.Add(new Iris());

            return Arrangement;
        }

        public List<IBirthday> MakeBirthdayArrangement()
        {
            List<IBirthday> Arrangement = new List<IBirthday>();
            Arrangement.Add(new Lily());
            Arrangement.Add(new Lily());
            Arrangement.Add(new Sunflower());
            Arrangement.Add(new Sunflower());

            return Arrangement;
        }

        public List<IGetWell> MakeGetWellArrangement()
        {
            List<IGetWell> Arrangement = new List<IGetWell>();
            Arrangement.Add(new Tulip());
            Arrangement.Add(new Tulip());

            return Arrangement;
        }
    }
}