using System;
using System.Collections.Generic;

namespace BiblWeb2._0.Data
{
    public partial class NewNews
    {
        public int NewNewsId { get; set; }
        public int? NewId { get; set; }
        public int? NewsId { get; set; }

        public virtual New? New { get; set; }
        public virtual News? News { get; set; }
    }
}
