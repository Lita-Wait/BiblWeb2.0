using System;
using System.Collections.Generic;

namespace BiblWeb2._0.Data
{
    public partial class MainView
    {
        public int MainViewElemId { get; set; }
        public int? MainSlidersId { get; set; }
        public int? MainProjectsId { get; set; }
        public int? MainNewsId { get; set; }
        public int? SecondSlidersId { get; set; }

        public virtual News? MainNews { get; set; }
        public virtual Projects? MainProjects { get; set; }
        public virtual Sliders? MainSliders { get; set; }
        public virtual Sliders? SecondSliders { get; set; }
    }
}
