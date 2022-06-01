using System;
using System.Collections.Generic;

namespace BiblWeb2._0.Data
{
    public partial class Galleries
    {
        public Galleries()
        {
            GalleryGalleries = new HashSet<GalleryGallery>();
        }

        public int GalleryId { get; set; }
        public string? Image { get; set; }

        public virtual ICollection<GalleryGallery> GalleryGalleries { get; set; }
    }
}
