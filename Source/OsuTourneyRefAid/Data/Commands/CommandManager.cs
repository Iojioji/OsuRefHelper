using OsuTourneyRefHelper.Data.Settings;
using OsuTourneyRefHelper.Data.Mappool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsuTourneyRefHelper.Data.Commands
{
    class CommandManager
    {
        List<Command> commandList = new List<Command>();
        Random rand = new Random();
        public MapPool CurrentPool;

        public CommandManager()
        {
            commandList.Add(new Command() { Name = "Make", MPCommand = "!mp make" });
            commandList.Add(new Command() { Name = "Pass", MPCommand = "!mp password" });
            commandList.Add(new Command() { Name = "Config", MPCommand = "!mp set 2 3 4" });
            commandList.Add(new Command() { Name = "Invite", MPCommand = "!mp invite" });
            commandList.Add(new Command() { Name = "Config", MPCommand = "!mp set 2 3 4" });
            commandList.Add(new Command() { Name = "Config", MPCommand = "!mp set 2 3 4" });
        }

        public string Make()
        {
            return $"!mp make {SettingsManager.Settings.Tournament.TourneyAcronym}: (<red>) vs (<blue>)";
        }
        public string Pass()
        {
            //return $"!mp password potatoman123";
            return $"!mp password {RandomPassword()}";
        }
        public string Set()
        {
            return $"!mp set {(int)SettingsManager.Settings.Tournament.TeamMode} {(int)SettingsManager.Settings.Tournament.Scoring} {SettingsManager.Settings.Tournament.TeamSize * 2}";
        }

        public string ChangeMod()
        {
            return "";
        }
        public string Map(string id)
        {

            return "";
        }
        public string RandomPassword()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(2, true));
            builder.Append(RandomString(2, false));
            builder.Append(RandomNumber(1000, 9999));
            builder.Append(RandomString(2, false));
            return builder.ToString();
        }
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * rand.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
        public int RandomNumber(int min, int max)
        {
            return rand.Next(min, max);
        }

    }
}
