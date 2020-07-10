using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsuTourneyRefHelper.Data.Mappool
{
    public class Beatmap_OLD
    {
        int _mapId;
        string _title;
        string _artist;
        string _mapper;
        string _diffName;
        float _bpm;
        float _stars;
        MapMod _mod;
        int _modIndex;
        string _mapCategory;

        public int MapID
        {
            get { return _mapId; }
        }
        public string Title
        {
            get { return _title; }
        }
        public string Artist
        {
            get { return _artist; }
        }
        public string Mapper
        {
            get { return _mapper; }
        }
        public string DiffName
        {
            get { return _diffName; }
        }
        public float BPM
        {
            get { return _bpm; }
        }
        public float Stars
        {
            get { return _stars; }
        }
        public MapMod Mod
        {
            get { return _mod; }
        }
        public int ModIndex
        {
            get { return _modIndex; }
        }
        //public string MapCategory
        //{
        //    get { return $"{_mod}{_modIndex}"; }
        //}

        public Beatmap_OLD(int mapId, string title, string artist, string mapper, string diffName, float bpm, float stars, int mod, int modIndex)
        {
            _mapId = mapId;
            _title = title;
            _artist = artist;
            _mapper = mapper;
            _diffName = diffName;
            _bpm = bpm;
            _stars = stars;
            _mod = (MapMod)mod;
            //_mod = ConvertMapMod(mod);
            _modIndex = modIndex;
        }
        MapMod ConvertMapMod(string toConvert)
        {
            switch (toConvert)
            {
                case "NM":
                    return MapMod.NM;
                case "HD":
                    return MapMod.HD;
                case "HR":
                    return MapMod.HR;
                case "DT":
                    return MapMod.DT;
                case "FM":
                    return MapMod.FM;
                default:
                    Console.WriteLine($"Got something else ({toConvert}), setting as \"FM\"");
                    return MapMod.FM;
            }
        }
        public string ToMod()
        {
            switch (_mod)
            {
                case MapMod.NM:
                    return "None";
                case MapMod.HD:
                    return "HD";
                case MapMod.HR:
                    return "HR";
                case MapMod.DT:
                    return "DT";
                case MapMod.FM:
                    return "Freemod";
                case MapMod.TB:
                    return "Freemod";
                default:
                    return "None";
            }
        }
        public string MapCategory()
        {
            return $"{_mod}{_modIndex}";
        }

        public string MapNameWithDiff()
        {
            return $"{_title} - {_artist} [{_diffName}]";
        }
        public string MapName()
        {
            return $"{_artist} - {_title}";
        }

        public override string ToString()
        {
            return $"<{_mapId}> {_title} - {_artist} [{_diffName}] -- ({_mod}{_modIndex})";
        }
    }
}
