using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGO.Domain
{
    public class Project : BaseEntity
    {
        public string Title { get; set; }
        public string? PageDonationTitle { get; set; }
        public int? PageDonationAccount { get; set; }
        public bool CollectDonation { get; set; }
        public int LanguageId { get; set; }
        public Language Languages { get; set; }
        public string Url { get; set; }
        public string ShortDescription { get; set; } = string.Empty;
        public string? KeyWords { get; set; }
        public string Currency { get; set; } = "Euro";  // ????
        public int AmountOfBudget { get; set; }
        public int? RegionId { get; set; } = null;// just 1 region or null can be set for project
        public Region Regions { get; set; } 
        //public virtual ICollection<Region> Regions { get; set; } // multiple or null regions can be set 
        public string ProjectDonors { get; set; } = string.Empty; // using string for donors
        //public virtual ICollection<ProjectDonor> ProjectDonors { get; set; }
        public string ProjectImplementors { get; set; } = string.Empty;
        //public virtual ICollection<ProjectImplementor>? ProjectImplementors { get; set; }
        public string Aims { get; set; } = string.Empty;
        public string? Results { get; set; } = null;
        public bool IsActive { get; set; } = true;
        public bool IsHightPriority { get; set; } = false;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? LastUpdateDate { get; set; } = DateTime.Now;
        public int UserId { get; set; } 
        public User Users { get; set; }
        
        public List<News> News { get; set; } = new List<News>();    
        /*
        public Project()
        {
            this.Regions = new HashSet<Region>();
            this.ProjectImplementors = new HashSet<ProjectImplementor>();
            this.ProjectDonors = new HashSet<ProjectDonor>();
        */
    }
}
