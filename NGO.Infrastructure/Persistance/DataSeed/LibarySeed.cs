using NGO.Infrastructure.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGO.Infrastructure.Persistance.DataSeed
{
    public class LibarySeed
    {
        public async Task Seed(NGODbContext context)
        {
            if(!context.Librarys.Any())
            {
                //var Csharp = {}
            }
        }
    }
}
