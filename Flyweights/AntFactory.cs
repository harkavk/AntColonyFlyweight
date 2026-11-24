using System.Collections.Generic;
using System.Drawing;

namespace AntColonyFlyweight.Flyweights
{
    public sealed class AntFactory
    {
        private readonly Dictionary<string, AntFlyweight> cache =
            new Dictionary<string, AntFlyweight>();

        public AntFlyweight GetAnt(string type)
        {
            if (cache.ContainsKey(type))
                return cache[type];

            AntFlyweight ant;

            switch (type)
            {
                case "Робоча":
                    ant = new AntFlyweight("Робоча", Color.SaddleBrown, 12, 2.0f);
                    break;
                case "Солдат":
                    ant = new AntFlyweight("Солдат", Color.Firebrick, 17, 1.5f);
                    break;
                case "Розвідник":
                    ant = new AntFlyweight("Розвідник", Color.RoyalBlue, 10, 3.0f);
                    break;
                default:
                    ant = new AntFlyweight("Робоча", Color.SaddleBrown, 12, 2.0f);
                    break;
            }

            cache.Add(type, ant);
            return ant;
        }

        public int GetCreatedTypesCount()
        {
            return cache.Count;
        }
    }
}
