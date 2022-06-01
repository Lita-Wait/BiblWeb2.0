using System;
using System.Collections.Generic;

namespace BiblWeb2._0.Data
{
    public partial class NewsView
    {
        public int NewsViewElementId { get; set; }
        public int? NewsId { get; set; }

        public virtual News? News { get; set; }
    }
}
