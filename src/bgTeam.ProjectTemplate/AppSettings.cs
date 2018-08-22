﻿namespace bgTeam.ProjectTemplate
{
    using bgTeam.Core;

    internal interface IAppSettings
    {
        string NameCompany { get; set; }

        string NameProject { get; set; }

        string BgTeamVersion { get; set; }
    }

    class AppSettings : IAppSettings
    {
        public string NameCompany { get; set; }

        public string NameProject { get; set; }

        public string BgTeamVersion { get; set; }

        public AppSettings(IAppConfiguration config)
        {
            NameCompany = config["NameCompany"];

            NameProject = config["NameProject"];

            BgTeamVersion = config["BgTeamVersion"];
        }
    }
}
