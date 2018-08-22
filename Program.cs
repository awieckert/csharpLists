using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<string> planetList = new List<string>(){"Mercury", "Mars"};
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> lastPlanets = new List<string>(){"Uranus", "Venus"};
            planetList.AddRange(lastPlanets);
            planetList.Insert(0, "Earth");
            // planetList.Insert(3, "Pluto");
            planetList.Add("Pluto");

            List<string> rockeyPlanets = new List<string>();
            rockeyPlanets.AddRange(planetList.GetRange(0, 3));
            rockeyPlanets.AddRange(planetList.GetRange(6, 1));
            planetList.Remove("Pluto");

            foreach (string item in planetList)
            {
                Console.WriteLine($"Planets List: {item}");
            }

            foreach (string item in rockeyPlanets)
            {
                Console.WriteLine($"Rockey Planets: {item}");
            }

            List<Dictionary<string, string>> myDictionaries = new List<Dictionary<string, string>>();
            myDictionaries.Add(new Dictionary<string, string>()
            {
              {"LunarLander", "Uranus"}
            });
            myDictionaries.Add(new Dictionary<string, string>(){
              {"EarthsLastHope", "Mars"}
            });

            foreach (string planet in planetList)
            {
              foreach (Dictionary<string, string> spaceShipDict in myDictionaries)
              {
                foreach (KeyValuePair<string, string> spaceShip in spaceShipDict)
                {
                    if (planet == spaceShip.Value)
                    {
                        Console.WriteLine($"Spaceship {spaceShip.Key} visited the planet {planet}");
                    }
                }
              }
            }
        }
    }
}
