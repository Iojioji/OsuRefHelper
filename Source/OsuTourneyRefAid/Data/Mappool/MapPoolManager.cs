using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsuTourneyRefHelper.Data.Mappool
{
    public class MapPoolManager
    {
        public string version;
        public List<MapPool_OLD> pools_old = new List<MapPool_OLD>();
        public List<PoolStage> stages = new List<PoolStage>();

        public List<string> GetStageNames()
        {
            List<string> aux = new List<string>();
            for (int i = 0; i < pools_old.Count; i++)
            {
                aux.Add(pools_old[i].Stage);
            }
            return aux;
        }

        public override string ToString()
        {
            if (pools_old.Count == 0)
            {
                return "<<Pools>>\r\n   •Empty";
            }
            string aux = "<<Pools>>\r\n";
            for (int i = 0; i < pools_old.Count; i++)
            {
                aux += pools_old[i].ToString() + "\r\n";
            }
            return aux;
        }
    }
}
