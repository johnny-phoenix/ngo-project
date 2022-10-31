using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGO.Domain
{
    public class ProjectDonor : BaseEntity
    {
        public string Name { get; set; }
        public string Currency { get; set; }
        public string? SvgLogo { get; set; }
        //public virtual ICollection<Project> Projects { get; set; }
        /*
        public ProjectDonor()
        {
            this.Projects = new HashSet<Project>();
        }
        */
    }
}
