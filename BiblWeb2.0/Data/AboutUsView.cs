using System;
using System.Collections.Generic;

namespace BiblWeb2._0.Data
{
    public partial class AboutUsView
    {
        public int AboutUsElementId { get; set; }
        public string? MainImage { get; set; }
        public string? MainHeader { get; set; }
        public string? Text { get; set; }
        public int? TeamsId { get; set; }
        public int? DocsId { get; set; }

        public virtual Docs? Docs { get; set; }
        public virtual Team? Teams { get; set; }
    }
}
