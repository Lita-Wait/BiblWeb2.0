using System;
using System.Collections.Generic;

namespace BiblWeb2._0.Data
{
    public partial class ContactView
    {
        public int ContactViewElementId { get; set; }
        public string? Header { get; set; }
        public string? Text { get; set; }
        public int? ContactInfoId { get; set; }

        public virtual ContactInfo? ContactInfo { get; set; }
    }
}
