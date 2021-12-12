using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsuTourneyRefHelper.Data.Mappool
{
    public class PoolSection
    {
        public string Name;
        public List<BeatMap> Maps = new List<BeatMap>();
        public List<MapMod> Mods = new List<MapMod>();

        public override string ToString()
        {
            string aux = $"Section: {Name}\r\n";
            aux += "Mods: ";
            foreach (MapMod mod in Mods)
            {
                aux += $"{mod}";
            }
            aux += "\r\n";
            foreach (BeatMap map in Maps)
            {
                aux += $"{map}\r\n";
            }
            return aux;
        }
    }
}
