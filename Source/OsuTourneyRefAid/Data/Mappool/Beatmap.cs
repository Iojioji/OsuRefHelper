using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsuTourneyRefHelper.Data.Mappool
{
    public enum MapMod { NM, HD, HR, EZ, DT, NC, HT, FL, FM, TB }
    public class BeatMap
    {
        int _mapId;
        string _title;
        string _artist;
        string _mapper;
        string _diffName;

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

        public BeatMap(int mapId, string title, string artist, string mapper, string diffName)
        {
            _mapId = mapId;
            _title = title;
            _artist = artist;
            _mapper = mapper;
            _diffName = diffName;
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
            return $"<{_mapId}> {_title} - {_artist} [{_diffName}]";
        }
    }
}
