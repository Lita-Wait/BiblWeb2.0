using System;
using System.Collections.Generic;

namespace BiblWeb2._0.Data
{
    public partial class ServiceServicesId
    {
        public int ServiceServicesId1 { get; set; }
        public int ServiceId { get; set; }
        public int ServicesId { get; set; }

        public virtual Service Service { get; set; } = null!;
        public virtual Services Services { get; set; } = null!;
    }
}
