using System;
using System.Collections.Generic;

namespace BiblWeb2._0.Data
{
    public partial class News
    {
        public News()
        {
            MainViews = new HashSet<MainView>();
            NewNews = new HashSet<NewNews>();
            NewsViews = new HashSet<NewsView>();
        }

        public int NewsId { get; set; }
        public string? Title { get; set; }

        public virtual ICollection<MainView> MainViews { get; set; }
        public virtual ICollection<NewNews> NewNews { get; set; }
        public virtual ICollection<NewsView> NewsViews { get; set; }
    }
}
