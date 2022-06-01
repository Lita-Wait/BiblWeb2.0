using System;
using System.Collections.Generic;

namespace BiblWeb2._0.Data
{
    public partial class Sliders
    {
        public Sliders()
        {
            Footers = new HashSet<Footer>();
            MainViewMainSliders = new HashSet<MainView>();
            MainViewSecondSliders = new HashSet<MainView>();
            SliderSliders = new HashSet<SliderSlider>();
        }

        public int SlidersId { get; set; }
        public string? Title { get; set; }

        public virtual ICollection<Footer> Footers { get; set; }
        public virtual ICollection<MainView> MainViewMainSliders { get; set; }
        public virtual ICollection<MainView> MainViewSecondSliders { get; set; }
        public virtual ICollection<SliderSlider> SliderSliders { get; set; }
    }
}
