using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGO.Domain
{
    public class ProjectImplementor : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public string? SvgLogo { get; set; }

        public virtual ICollection<Project> Projects { get; set; }

        public ProjectImplementor()
        {
            this.Projects = new HashSet<Project>();
            
        }
    }
}
