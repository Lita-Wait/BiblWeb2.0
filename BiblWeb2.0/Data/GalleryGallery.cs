using System;
using System.Collections.Generic;

namespace BiblWeb2._0.Data
{
    public partial class GalleryGallery
    {
        public int GalleryGalleriesId { get; set; }
        public int GalleryId { get; set; }
        public int GalleriesId { get; set; }

        public virtual Gallery Galleries { get; set; } = null!;
        public virtual Galleries Gallery { get; set; } = null!;
    }
}
