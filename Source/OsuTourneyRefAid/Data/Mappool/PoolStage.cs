using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsuTourneyRefHelper.Data.Mappool
{
    public class PoolStage
    {
        public string Name;
        public List<PoolSection> Sections = new List<PoolSection>();

        public override string ToString()
        {
            string aux = $"Stage: {Name}";
            foreach (PoolSection section in Sections)
            {
                aux += $"{section}\r\n";
            }
            return aux;
        }
    }
}
