using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGO.Domain
{
    public class Region : BaseEntity
    {
        public string NameRO { get; set; }
        public string NameEN { get; set; }

        public List<News> News { get; set; }
        public List<Project> Projects { get; set; }
        //public virtual ICollection<News> News { get; set; }
        //public virtual ICollection<Project> Projects { get; set; }
        /*
        public Region()
        {
            this.News = new HashSet<News>(); 
            this.Projects = new HashSet<Project>();
        */
    }
}
