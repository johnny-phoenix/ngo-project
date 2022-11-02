using System.ComponentModel.DataAnnotations;
//using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace NGO.Domain
{
    public class User : BaseEntity
    {
        //public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public string Login { get; set; }
        public string Passwd { get; set; }

        public bool IsAdmin { get; set; } = false;
        public bool CanDownloadSpecialFiles { get; set; } = false;
        public bool IsNewsEditor { get; set; } = false;
        public bool IsLibraryeditor { get; set; } = false;
        public bool IsPersonalStoryesEditor { get; set; } = false;
        //public string PasswdHash { get; set; }
        //public int UserAccessId { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool IsDeleted { get; set; } = false;

        public List<News> News { get; set; } = new();
        public List<Library> Libraries { get; set; } = new();
        public List<PersonalStory> PersonalStories { get; set; } = new();
        public List<Project> Projects { get; set; }
        //public int UserAccessId { get; set; }
        //public UserAccess UserAccess { get; set; }
        

    }
}
