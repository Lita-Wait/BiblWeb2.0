using System;
using System.Collections.Generic;

namespace BiblWeb2._0.Data
{
    public partial class Worker
    {
        public Worker()
        {
            WorkerTeams = new HashSet<WorkerTeam>();
        }

        public int WorkerId { get; set; }
        public string? Image { get; set; }
        public string? Name { get; set; }
        public string? Text { get; set; }
        public string? Link1 { get; set; }
        public string? Link2 { get; set; }
        public string? Link3 { get; set; }

        public virtual ICollection<WorkerTeam> WorkerTeams { get; set; }
    }
}
