using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace OsuTourneyRefHelper.Data.Mappool
{
    public class MapPool_OLD
    {
        public string Stage;
        public List<Beatmap_OLD> nmPool = new List<Beatmap_OLD>();
        public List<Beatmap_OLD> hdPool = new List<Beatmap_OLD>();
        public List<Beatmap_OLD> hrPool = new List<Beatmap_OLD>();
        public List<Beatmap_OLD> dtPool = new List<Beatmap_OLD>();
        public List<Beatmap_OLD> fmPool = new List<Beatmap_OLD>();
        public List<Beatmap_OLD> tbPool = new List<Beatmap_OLD>();

        string WritePool(List<Beatmap_OLD> pool, string poolName)
        {
            if (pool.Count == 0)
            {
                return $">{poolName}\r\n   •Empty";
            }
            string aux = $">{poolName}\r\n";
            for (int i = 0; i < pool.Count; i++)
            {
                aux += i < pool.Count - 1 ? $"   {pool[i].ToString()}\r\n" : $"   {pool[i].ToString()}";
            }
            return aux;
        }

        public Beatmap_OLD GetBeatmap(string map)
        {
            string cat = (map[0].ToString() + map[1].ToString());
            int number = int.Parse(map[2].ToString());

            List<Beatmap_OLD> currentCat = GetCategory(cat);
            Beatmap_OLD target = currentCat.Find(x => x.ModIndex == number);
            return target;
        }
        public List<Beatmap_OLD> GetCategory(string cat)
        {
            switch (cat)
            {
                case "NM":
                    return nmPool;
                case "HD":
                    return hdPool;
                case "HR":
                    return hrPool;
                case "DT":
                    return dtPool;
                case "FM":
                    return fmPool;
                case "TB":
                    return tbPool;
                default:
                    return null;
            }
        }
        public override string ToString()
        {
            return $"<{Stage}>\r\n{WritePool(nmPool, "NM")}\r\n{WritePool(hdPool, "HD")}\r\n{WritePool(hrPool, "HR")}\r\n{WritePool(dtPool, "DT")}\r\n{WritePool(fmPool, "FM")}\r\n{WritePool(tbPool, "TB")}";
        }
    }
}
