using System;
using System.Collections.Generic;

namespace diggersandfliers
{
    public class DiggersContainer
    {
        public List<IDigger> Diggers = new List<IDigger>();

        public void AddDigger(IDigger digger)
        {
            Diggers.Add(digger);
        }
    }

}