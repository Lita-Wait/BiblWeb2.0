using System;
using System.Collections.Generic;

namespace BiblWeb2._0.Data
{
    public partial class Service
    {
        public Service()
        {
            ServiceServicesIds = new HashSet<ServiceServicesId>();
        }

        public int SeviceId { get; set; }
        public string? Header { get; set; }
        public string? Text { get; set; }
        public string? Image { get; set; }

        public virtual ICollection<ServiceServicesId> ServiceServicesIds { get; set; }
    }
}
