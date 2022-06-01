using System;
using System.Collections.Generic;

namespace BiblWeb2._0.Data
{
    public partial class Projects
    {
        public Projects()
        {
            MainViews = new HashSet<MainView>();
            ProjectProjects = new HashSet<ProjectProject>();
            ProjectViews = new HashSet<ProjectView>();
        }

        public int ProjectsId { get; set; }
        public string? Title { get; set; }

        public virtual ICollection<MainView> MainViews { get; set; }
        public virtual ICollection<ProjectProject> ProjectProjects { get; set; }
        public virtual ICollection<ProjectView> ProjectViews { get; set; }
    }
}
