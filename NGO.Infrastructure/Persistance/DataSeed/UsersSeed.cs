using NGO.Domain;
using NGO.Infrastructure.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGO.Infrastructure.Persistance.DataSeed
{
    public class UsersSeed
    {
        public static async Task Seed(NGODbContext context)
        {
            var user1 = new User()
            {
                FirstName = "Vasil",
                LastName = "Gromozeka",
                Email = "gromozeka@gmail.com",
                Phone = null,
                Login = "vasGrom",
                Passwd = "123456",
                IsAdmin = true,
                CanDownloadSpecialFiles = true, 
                IsLibraryeditor = true,
                IsNewsEditor = true,
                IsPersonalStoryesEditor = true,
                DateCreated = DateTime.Now,
                DateUpdated = null,
                IsDeleted = false,
            };
            var user2 = new User()
            {
                FirstName = "Olga",
                LastName = "Perova",
                Email = "o.perova@gmail.com",
                Phone = "37369854752",
                Login = "Olgutsa",
                Passwd = "123456",
                IsAdmin = false,
                CanDownloadSpecialFiles = true,
                IsNewsEditor = true,
                IsLibraryeditor = false,
                IsPersonalStoryesEditor = false,
                DateCreated = DateTime.Now,
                DateUpdated = null,
                IsDeleted = false,
            };

            context.Add(user1);
            context.Add(user2);
            await context.SaveChangesAsync();
        }
    }
}
