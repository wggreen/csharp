using System;
using System.Collections.Generic;

namespace planetsProbes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Venus", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };
            List<KeyValuePair<string, string>> probeDestinations = new List<KeyValuePair<string, string>>();
            probeDestinations.Add(new KeyValuePair<string, string>("Mariner 10", "Mercury"));
            probeDestinations.Add(new KeyValuePair<string, string>("MESSENGER", "Mercury"));
            probeDestinations.Add(new KeyValuePair<string, string>("Mariner 1", "Venus"));
            probeDestinations.Add(new KeyValuePair<string, string>("Mariner 2", "Venus"));
            probeDestinations.Add(new KeyValuePair<string, string>("Mariner 5", "Venus"));
            probeDestinations.Add(new KeyValuePair<string, string>("Mariner 10", "Venus"));
            probeDestinations.Add(new KeyValuePair<string, string>("Mariner 10", "Venus"));
            probeDestinations.Add(new KeyValuePair<string, string>("Pioneer Venus", "Venus"));
            probeDestinations.Add(new KeyValuePair<string, string>("Galileo", "Venus"));
            probeDestinations.Add(new KeyValuePair<string, string>("Magellan", "Venus"));
            probeDestinations.Add(new KeyValuePair<string, string>("Magellan", "Venus"));
            probeDestinations.Add(new KeyValuePair<string, string>("Cassini", "Venus"));
            probeDestinations.Add(new KeyValuePair<string, string>("MESSENGER", "Venus"));
            probeDestinations.Add(new KeyValuePair<string, string>("Parker Solar Probe", "Venus"));
            probeDestinations.Add(new KeyValuePair<string, string>("Mariner 3", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("Mariner 4", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("Mariner 6", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("Mariner 7", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("Mariner 8", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("Mariner 9", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("Viking 1", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("Viking 2", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("Mars Observer", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("Mars Pathfinder", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("Mars Global Surveyor", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("Mars Climate Orbiter", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("Mars Polar Lander", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("Deep Space 2", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("2001 Mars Odyssey", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("Spirit", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("Opportunity", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("Mars Reconnaissance Orbiter", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("Mars Reconnaissance Orbiter", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("Phoenix", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("Dawn", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("Curiosity", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("MAVEN", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("InSight", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("MarCO", "Mars"));
            probeDestinations.Add(new KeyValuePair<string, string>("Pioneer 10", "Jupiter"));
            probeDestinations.Add(new KeyValuePair<string, string>("Pioneer 11", "Jupiter"));
            probeDestinations.Add(new KeyValuePair<string, string>("Voyager 1", "Jupiter"));
            probeDestinations.Add(new KeyValuePair<string, string>("Voyager 2", "Jupiter"));
            probeDestinations.Add(new KeyValuePair<string, string>("Ulysses", "Jupiter"));
            probeDestinations.Add(new KeyValuePair<string, string>("Galileo", "Jupiter"));
            probeDestinations.Add(new KeyValuePair<string, string>("Cassini", "Jupiter"));
            probeDestinations.Add(new KeyValuePair<string, string>("New Horizons", "Jupiter"));
            probeDestinations.Add(new KeyValuePair<string, string>("Juno", "Jupiter"));
            probeDestinations.Add(new KeyValuePair<string, string>("Europa Clipper", "Jupiter"));
            probeDestinations.Add(new KeyValuePair<string, string>("Pioneer 11", "Saturn"));
            probeDestinations.Add(new KeyValuePair<string, string>("Voyager 1", "Saturn"));
            probeDestinations.Add(new KeyValuePair<string, string>("Voyager 2", "Saturn"));
            probeDestinations.Add(new KeyValuePair<string, string>("Cassini", "Saturn"));
            probeDestinations.Add(new KeyValuePair<string, string>("Voyager 2", "Uranus"));
            probeDestinations.Add(new KeyValuePair<string, string>("Voyager 2", "Neptune"));

            // Iterate planets
            foreach (string planet in planetList)
            {
                // List to store probes that visited the planet
                List<string> matchingProbes = new List<string>();

                // Iterate probeDestinations
                foreach (KeyValuePair<string, string> probePlanetPair in probeDestinations)
                {
                    /*
                        Does the current probe's destination
                        match the value of the `planet` variable?
                        If so, add it to the list.
                    */
                    if (probePlanetPair.Value == planet)
                    {
                        matchingProbes.Add(probePlanetPair.Key);
                    }
                }

                /*
                    Use String.Join(",", matchingProbes) as part of the
                    solution to get the output below. It's the C# way of
                    writing `array.join(",")` in JavaScript.
                */
                Console.WriteLine($"{planet}: {String.Join(", ", matchingProbes)}\n");
            }
        }
    }
}
