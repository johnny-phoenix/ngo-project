using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGO.Domain
{
    public class Library : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string CoverImageUri { get; set; }
        public string Url { get; set; }
        public DateTime AddedDate { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
