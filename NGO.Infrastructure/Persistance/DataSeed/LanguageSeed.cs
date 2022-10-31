using NGO.Domain;
using NGO.Infrastructure.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGO.Infrastructure.Persistance.DataSeed
{
    public class LanguageSeed
    {
        public static async Task Seed(NGODbContext context)
        {
            if (!context.Languages.Any())
            {
                var ro = new Language { Id = 1, LanguageName = "RO", IsDeleted = false };
                var en = new Language { Id = 2, LanguageName = "EN", IsDeleted = false };

                context.Languages.Add(ro);
                context.Languages.Add(en);

                await context.SaveChangesAsync();
            }
        }




    }
}
