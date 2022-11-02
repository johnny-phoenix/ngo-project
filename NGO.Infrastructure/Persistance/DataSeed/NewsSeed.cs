using NGO.Domain;
using NGO.Infrastructure.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGO.Infrastructure.Persistance.DataSeed
{
    public class NewsSeed
    {
        public static async Task Seed(NGODbContext context, int UserId)
        {
            if(!context.News.Any())
            {
                var n1 = new News()
                {

                };
            }
        }
    }
}
