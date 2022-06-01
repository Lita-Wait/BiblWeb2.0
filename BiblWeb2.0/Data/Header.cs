using System;
using System.Collections.Generic;

namespace BiblWeb2._0.Data
{
    public partial class Header
    {
        public int HeaderId { get; set; }
        public int ContactInfoId { get; set; }

        public virtual ContactInfo ContactInfo { get; set; } = null!;
    }
}
