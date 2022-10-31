using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGO.Domain
{
    public class News : BaseEntity
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int LanguagesId { get; set; } // not necessary
        public Language Languages { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;
        public string NewsContent { get; set; }
        //public string KeyWords { get; set; } = string.Empty;
        public string? MainImagePath { get; set; } = null;
        public int? ProjectId { get; set; } // for now the number project is 1 (possible need more)
        public Project Projects { get; set; }
        public int? RegionId { get; set; } = null;
        public Region Regions { get; set; }
        //public virtual ICollection<Region> Regions { get; set; }
        public string Url { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime DateTimeCreated { get; set; } = DateTime.Now;

        /*
        public News()
        {
            this.Regions = new HashSet<Region>();
        }
        */

    }
}
