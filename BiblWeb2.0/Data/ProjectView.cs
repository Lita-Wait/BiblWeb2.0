using System;
using System.Collections.Generic;

namespace BiblWeb2._0.Data
{
    public partial class ProjectView
    {
        public int ProjectViewElementId { get; set; }
        public int? ProjectsId { get; set; }
        public int? GalleriesId { get; set; }

        public virtual Gallery? Galleries { get; set; }
        public virtual Projects? Projects { get; set; }
    }
}
