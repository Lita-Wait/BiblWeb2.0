using System;
using System.Collections.Generic;

namespace BiblWeb2._0.Data
{
    public partial class Team
    {
        public Team()
        {
            AboutUsViews = new HashSet<AboutUsView>();
            WorkerTeams = new HashSet<WorkerTeam>();
        }

        public int TeamsId { get; set; }
        public string? Title { get; set; }

        public virtual ICollection<AboutUsView> AboutUsViews { get; set; }
        public virtual ICollection<WorkerTeam> WorkerTeams { get; set; }
    }
}
