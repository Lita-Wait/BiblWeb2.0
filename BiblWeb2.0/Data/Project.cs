using System;
using System.Collections.Generic;

namespace BiblWeb2._0.Data
{
    public partial class Project
    {
        public Project()
        {
            ProjectProjects = new HashSet<ProjectProject>();
        }

        public int ProjectId { get; set; }
        public int ProjectTypeId { get; set; }
        public string? Title { get; set; }
        public string Image { get; set; } = null!;
        public string? ImageIncText { get; set; }
        public int ProjectStatusId { get; set; }
        public string? Link { get; set; }

        public virtual ProjectStatus ProjectStatus { get; set; } = null!;
        public virtual ProjectType ProjectType { get; set; } = null!;
        public virtual ICollection<ProjectProject> ProjectProjects { get; set; }
    }
}
