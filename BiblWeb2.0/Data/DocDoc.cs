using System;
using System.Collections.Generic;

namespace BiblWeb2._0.Data
{
    public partial class DocDoc
    {
        public int DocDocsId { get; set; }
        public int Doc { get; set; }
        public int Docs { get; set; }

        public virtual Doc DocNavigation { get; set; } = null!;
        public virtual Docs DocsNavigation { get; set; } = null!;
    }
}
