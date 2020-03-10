using System;
using System.Collections.Generic;

namespace diggersandfliers
{
    public class SwimmersContainer
    {
        public List<ISwimmer> Swimmers = new List<ISwimmer>();

        public void AddSwimmers(ISwimmer swimmer)
        {
            Swimmers.Add(swimmer);
        }
    }

}