using System;
//using NGO.Infrastructure.DataSeed;
using NGO.Infrastructure.Persistance.Contexts;

namespace NGO.Infrastructure.Persistance.DataSeed
{
	public class SeedFacade
	{
		public static async Task SeedData(NGODbContext context)
		{
			//context.Database.M//Migrate();

			await LanguagesSeed.Seed(context);
			await RegionsSeed.Seed(context);
			await UsersSeed.Seed(context);
			var userId = 1; // = context.Users(x => x.Id).Where(x => x.Login ==  )
							// need to get user id to seed News, project, Project
			await ProjectsSeed.Seed(context, userId);
			await NewsSeed.Seed(context, userId);
			//await 

		}
	}
}
