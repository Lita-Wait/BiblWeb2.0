using System;
using System.Collections.Generic;

namespace BiblWeb2._0.Data
{
    public partial class Footer
    {
        public int FooterId { get; set; }
        public int? SlidersId { get; set; }
        public int? ContactInfoId { get; set; }
        public int? GalleriesId { get; set; }

        public virtual ContactInfo? ContactInfo { get; set; }
        public virtual Gallery? Galleries { get; set; }
        public virtual Sliders? Sliders { get; set; }
    }
}
