using System;
using System.Collections.Generic;

namespace BiblWeb2._0.Data
{
    public partial class Services
    {
        public Services()
        {
            ServiceServicesIds = new HashSet<ServiceServicesId>();
            ServiceViewServices = new HashSet<ServiceView>();
            ServiceViewSevicesImages = new HashSet<ServiceView>();
        }

        public int ServicesId { get; set; }
        public string? Title { get; set; }

        public virtual ICollection<ServiceServicesId> ServiceServicesIds { get; set; }
        public virtual ICollection<ServiceView> ServiceViewServices { get; set; }
        public virtual ICollection<ServiceView> ServiceViewSevicesImages { get; set; }
    }
}
