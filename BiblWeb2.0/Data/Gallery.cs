using System;
using System.Collections.Generic;

namespace BiblWeb2._0.Data
{
    public partial class Gallery
    {
        public Gallery()
        {
            Footers = new HashSet<Footer>();
            GalleryGalleries = new HashSet<GalleryGallery>();
            ProjectViews = new HashSet<ProjectView>();
        }

        public int GalleriesId { get; set; }
        public string? Title { get; set; }

        public virtual ICollection<Footer> Footers { get; set; }
        public virtual ICollection<GalleryGallery> GalleryGalleries { get; set; }
        public virtual ICollection<ProjectView> ProjectViews { get; set; }
    }
}
