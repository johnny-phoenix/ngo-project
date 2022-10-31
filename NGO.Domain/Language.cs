using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGO.Domain
{
    public class Language : BaseEntity
    {
        public string LanguageName { get; set; }
        public bool IsDeleted { get; set; } = false;

        public List<News> News { get; set; } = new();
        public List<Project> Projects { get; set; } = new();
        public List<Library> Libraries { get; set; } = new();
        public List<PersonalStory> PersonalStories { get; set; } = new();
    }
}
