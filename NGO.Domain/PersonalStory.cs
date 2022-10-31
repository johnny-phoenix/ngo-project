using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGO.Domain
{
    public class PersonalStory : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string StoryContent { get; set; }
        public string? MainImage {get; set; }
        //possible in future add many to many link to table images for mltiple images for personal story (and other entities like news, blog ...)
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
