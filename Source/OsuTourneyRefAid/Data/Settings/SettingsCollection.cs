using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsuTourneyRefHelper.Data.Settings
{
    public class SettingsCollection
    {
        public ProgramSettings Program = new ProgramSettings();
        public TournamentSettings Tournament = new TournamentSettings();
    }
}