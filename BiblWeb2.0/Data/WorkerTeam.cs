using System;
using System.Collections.Generic;

namespace BiblWeb2._0.Data
{
    public partial class WorkerTeam
    {
        public int WorkerTeamsId { get; set; }
        public int WorkerId { get; set; }
        public int TeamsId { get; set; }

        public virtual Team Teams { get; set; } = null!;
        public virtual Worker Worker { get; set; } = null!;
    }
}
