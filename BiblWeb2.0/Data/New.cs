using System;
using System.Collections.Generic;

namespace BiblWeb2._0.Data
{
    public partial class New
    {
        public New()
        {
            NewNews = new HashSet<NewNews>();
        }

        public int NewId { get; set; }
        public string? Date { get; set; }
        public string? Image { get; set; }
        public string? Link { get; set; }
        public string? Header { get; set; }
        public string? Text { get; set; }

        public virtual ICollection<NewNews> NewNews { get; set; }
    }
}
