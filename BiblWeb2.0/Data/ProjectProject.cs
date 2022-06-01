using System;
using System.Collections.Generic;

namespace BiblWeb2._0.Data
{
    public partial class ProjectProject
    {
        public int ProjectProjectsId { get; set; }
        public int ProjectId { get; set; }
        public int ProjectsId { get; set; }

        public virtual Project Project { get; set; } = null!;
        public virtual Projects Projects { get; set; } = null!;
    }
}
