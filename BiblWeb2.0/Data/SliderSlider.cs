using System;
using System.Collections.Generic;

namespace BiblWeb2._0.Data
{
    public partial class SliderSlider
    {
        public int SliderSlidersId { get; set; }
        public int SliderId { get; set; }
        public int SlidersId { get; set; }

        public virtual Slider Slider { get; set; } = null!;
        public virtual Sliders Sliders { get; set; } = null!;
    }
}
