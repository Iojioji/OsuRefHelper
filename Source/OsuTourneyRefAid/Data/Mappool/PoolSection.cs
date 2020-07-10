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
    }
}
