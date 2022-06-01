using System;
using System.Collections.Generic;

namespace BiblWeb2._0.Data
{
    public partial class ProjectStatus
    {
        public ProjectStatus()
        {
            Projects = new HashSet<Project>();
        }

        public int ProjectStatusId { get; set; }
        public string? Status { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}
