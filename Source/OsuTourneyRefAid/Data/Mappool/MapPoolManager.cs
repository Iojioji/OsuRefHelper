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
        public List<MapPool_OLD> pools = new List<MapPool_OLD>();
        public List<PoolStage> stages = new List<PoolStage>();

        public List<string> GetStageNames()
        {
            List<string> aux = new List<string>();
            for (int i = 0; i < pools.Count; i++)
            {
                aux.Add(pools[i].Stage);
            }
            return aux;
        }

        public override string ToString()
        {
            if (pools.Count == 0)
            {
                return "<<Pools>>\r\n   •Empty";
            }
            string aux = "<<Pools>>\r\n";
            for (int i = 0; i < pools.Count; i++)
            {
                aux += pools[i].ToString() + "\r\n";
            }
            if (stages.Count > 0)
            {
                aux += "\r\n\r\nNew Pool Stages:\r\n";
                foreach (PoolStage stage in stages)
                {
                    aux += $"{stage}\r\n";
                }
            }
            return aux;
        }
    }
}
