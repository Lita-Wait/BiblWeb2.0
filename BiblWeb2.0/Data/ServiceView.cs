using System;
using System.Collections.Generic;

namespace BiblWeb2._0.Data
{
    public partial class ServiceView
    {
        public int ServiceViewElementId { get; set; }
        public string? MainHeader { get; set; }
        public string? HeaderText { get; set; }
        public string? ServiceHeader { get; set; }
        public string? ServiceText { get; set; }
        public int ServicesId { get; set; }
        public int SevicesImageId { get; set; }
        public string? ImageWorker { get; set; }

        public virtual Services Services { get; set; } = null!;
        public virtual Services SevicesImage { get; set; } = null!;
    }
}
