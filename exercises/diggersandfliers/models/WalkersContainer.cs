using System;
using System.Collections.Generic;

namespace diggersandfliers
{
    public class WalkersContainer
    {
        public List<IWalker> Walkers = new List<IWalker>();

        public void AddWalker(IWalker walker)
        {
            Walkers.Add(walker);
        }
    }

}