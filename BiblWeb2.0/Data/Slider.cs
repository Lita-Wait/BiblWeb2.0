using System;
using System.Collections.Generic;

namespace BiblWeb2._0.Data
{
    public partial class Slider
    {
        public Slider()
        {
            SliderSliders = new HashSet<SliderSlider>();
        }

        public int SliderId { get; set; }
        public string? Image { get; set; }
        public string? AdImage { get; set; }
        public string? Header { get; set; }
        public string? LowHeader { get; set; }
        public string? Text { get; set; }

        public virtual ICollection<SliderSlider> SliderSliders { get; set; }
    }
}
