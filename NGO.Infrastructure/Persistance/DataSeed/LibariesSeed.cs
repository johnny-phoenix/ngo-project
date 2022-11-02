using NGO.Infrastructure.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGO.Infrastructure.Persistance.DataSeed
{
    public class LibariesSeed
    {
        public async Task Seed(NGODbContext context)
        {
            if(!context.Libraries.Any())
            {
                //var Csharp = {}
            }
        }
    }
}
