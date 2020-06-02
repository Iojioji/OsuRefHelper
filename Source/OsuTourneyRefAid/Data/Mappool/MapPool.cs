using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace OsuTourneyRefHelper.Data.Mappool
{
    class MapPool
    {
        public string Stage;
        public List<Beatmap> nmPool = new List<Beatmap>();
        public List<Beatmap> hdPool = new List<Beatmap>();
        public List<Beatmap> hrPool = new List<Beatmap>();
        public List<Beatmap> dtPool = new List<Beatmap>();
        public List<Beatmap> fmPool = new List<Beatmap>();
        public List<Beatmap> tbPool = new List<Beatmap>();

        string WritePool(List<Beatmap> pool, string poolName)
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

        public Beatmap GetBeatmap(string map)
        {
            string cat = (map[0].ToString() + map[1].ToString());
            int number = int.Parse(map[2].ToString());

            List<Beatmap> currentCat = GetCategory(cat);
            Beatmap target = currentCat.Find(x => x.ModIndex == number);
            return target;
        }
        public List<Beatmap> GetCategory(string cat)
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
