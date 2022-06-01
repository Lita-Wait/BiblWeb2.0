using System;
using System.Collections.Generic;

namespace BiblWeb2._0.Data
{
    public partial class ProjectType
    {
        public ProjectType()
        {
            Projects = new HashSet<Project>();
        }

        public int ProjectTypeId { get; set; }
        public string? Title { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}
