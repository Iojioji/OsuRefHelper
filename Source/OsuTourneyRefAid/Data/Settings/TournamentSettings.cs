using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsuTourneyRefHelper.Data.Settings
{
    public enum ScoreMode { Score, Accuracy, Combo, ScoreV2}
    public enum TeamMode { HeadToHead, TagCoop, TeamVs, TagTeamVs }
    public class TournamentSettings
    {
        public string TourneyAcronym;
        public TeamMode TeamMode;
        public ScoreMode Scoring;
        public int TeamSize;
    }
}