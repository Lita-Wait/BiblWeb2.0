using System;
using System.Collections.Generic;

namespace BiblWeb2._0.Data
{
    public partial class Docs
    {
        public Docs()
        {
            AboutUsViews = new HashSet<AboutUsView>();
        }

        public int DocsId { get; set; }
        public string? Title { get; set; }

        public virtual ICollection<AboutUsView> AboutUsViews { get; set; }
    }
}
