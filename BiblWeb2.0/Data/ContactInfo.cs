using System;
using System.Collections.Generic;

namespace BiblWeb2._0.Data
{
    public partial class ContactInfo
    {
        public ContactInfo()
        {
            ContactViews = new HashSet<ContactView>();
            Footers = new HashSet<Footer>();
            Headers = new HashSet<Header>();
        }

        public int ContactInfoId { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Adress { get; set; }

        public virtual ICollection<ContactView> ContactViews { get; set; }
        public virtual ICollection<Footer> Footers { get; set; }
        public virtual ICollection<Header> Headers { get; set; }
    }
}
