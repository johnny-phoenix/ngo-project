using NGO.Domain;
using NGO.Infrastructure.Persistance.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NGO.Infrastructure.Persistance.DataSeed
{
    public class RegionsSeed
    {
        public static async Task Seed(NGODbContext context)
        {
            if (!context.Regions.Any())
            {
                // Better way to  filling data
                var seedData = new List<Region>
                {
                    new Region { Id = 1, NameRO = "Chișinău", NameEN="Chsinau" },
                    new Region { Id = 2, NameRO = "Bălți", NameEN="Balti" },
                    new Region { Id = 3, NameRO = "Orhei", NameEN="Orhei" },
                    new Region { Id = 4, NameRO = "Găgăuzia", NameEN="Gagauzia" },
                    new Region { Id = 5, NameRO = "Căușeni", NameEN="Causeni" },
                    new Region { Id = 6, NameRO = "Fălești", NameEN="Falesti" },
                    new Region { Id = 7, NameRO = "Edineț", NameEN="Edinet" },
                    new Region { Id = 8, NameRO = "Rîșcani", NameEN="Riscani" },
                    new Region { Id = 9, NameRO = "Nisporeni", NameEN="Nisporeni" },
                    new Region { Id = 10, NameRO = "Strășeni", NameEN="Straseni" },
                    new Region { Id = 11, NameRO = "Ialoveni", NameEN="Ialoveni" },
                    new Region { Id = 12, NameRO = "Cimișlia", NameEN="Cimislia" },
                    new Region { Id = 13, NameRO = "Leova", NameEN="Leova" },
                    new Region { Id = 14, NameRO = "Hîncești", NameEN="Hîncești" },
                    new Region { Id = 15, NameRO = "Criuleni", NameEN="Criuleni" },
                    new Region { Id = 16, NameRO = "Rezina", NameEN="Rezina" },
                    new Region { Id = 17, NameRO = "Telenești", NameEN="Telenești" },
                    new Region { Id = 18, NameRO = "Călărași", NameEN="Călărași" },
                    new Region { Id = 19, NameRO = "Ungheni", NameEN="Ungheni" },
                    new Region { Id = 20, NameRO = "Soroca", NameEN="Soroca" },
                    new Region { Id = 21, NameRO = "Drochia", NameEN="Drochia" },
                    new Region { Id = 22, NameRO = "Dondușeni", NameEN="Dondușeni" },
                    new Region { Id = 23, NameRO = "Ocnița", NameEN="Ocnița" },
                    new Region { Id = 24, NameRO = "Cantemir", NameEN="Cantemir" },
                    new Region { Id = 25, NameRO = "Anenii Noi", NameEN="Anenii Noi" },
                    new Region { Id = 26, NameRO = "Șoldanești", NameEN="Șoldanești" },
                    new Region { Id = 27, NameRO = "Taraclia", NameEN="Taraclia" },
                    new Region { Id = 28, NameRO = "Glodeni", NameEN="Glodeni" },
                    new Region { Id = 29, NameRO = "Ștefan-Vodă", NameEN="Stefan-Voda" },
                    new Region { Id = 30, NameRO = "Cahul", NameEN="Cahul" },
                    new Region { Id = 31, NameRO = "Briceni", NameEN="Briceni" },
                    new Region { Id = 32, NameRO = "Basarabeasca", NameEN="Basarabeasca" },
                    new Region { Id = 33, NameRO = "Bender", NameEN="Bender" },
                    new Region { Id = 34, NameRO = "Tiraspol", NameEN="Tiraspol" },
                    new Region { Id = 35, NameRO = "Florești", NameEN="Floresti" },
                    new Region { Id = 36, NameRO = "Sîngegei", NameEN="Singerei" }
                };
                foreach (var item in seedData)
                {
                    context.Add(item);
                }
                context.SaveChanges();


                // Bad aproace
                //var Chisinau = new Region { Id = 1, NameRO = "Chișinău", NameEN = "Chsinau" };
                //var Balti = new Region { Id = 2, NameRO = "Bălți", NameEN = "Balti" };
                //var Orhei = new Region { Id = 3, NameRO = "Orhei", NameEN = "Orhei" };
                //var Gagauzia = new Region { Id = 4, NameRO = "Găgăuzia", NameEN = "Gagauzia" };
                //var Causeni = new Region { Id = 5, NameRO = "Căușeni", NameEN = "Causeni" };
                //var Falesti = new Region { Id = 6, NameRO = "Fălești", NameEN = "Falesti" };
                //var Edineti = new Region { Id = 7, NameRO = "Edineț", NameEN = "Edinet" };
                //var Riscani = new Region { Id = 8, NameRO = "Rîșcani", NameEN = "Riscani" };
                //var Nisporeni = new Region { Id = 9, NameRO = "Nisporeni", NameEN = "Nisporeni" };
                //var Straseni = new Region { Id = 10, NameRO = "Strășeni", NameEN = "Straseni" };
                //var Ialoveni = new Region { Id = 11, NameRO = "Ialoveni", NameEN = "Ialoveni" };
                //var Cimislia = new Region { Id = 12, NameRO = "Cimișlia", NameEN = "Cimislia" };
                //var Leova = new Region { Id = 13, NameRO = "Leova", NameEN = "Leova" };
                //var Hincesti = new Region { Id = 14, NameRO = "Hîncești", NameEN = "Hincesti" };
                //var Criuleni = new Region { Id = 15, NameRO = "Criuleni", NameEN = "Criuleni" };
                //var Rezina = new Region { Id = 16, NameRO = "Rezina", NameEN = "Rezina" };
                //var Telenesti = new Region { Id = 17, NameRO = "Telenești", NameEN = "Telenesti" };
                //var Calarasi = new Region { Id = 18, NameRO = "Călărași", NameEN = "Calarasi" };
                //var Ungheni = new Region { Id = 19, NameRO = "Ungheni", NameEN = "Ungheni" };
                //var Soroca = new Region { Id = 20, NameRO = "Soroca", NameEN = "Soroca" };
                //var Drochia = new Region { Id = 21, NameRO = "Drochia", NameEN = "Drochia" };
                //var Donduseni = new Region { Id = 22, NameRO = "Dondușeni", NameEN = "Donduseni" };
                //var Ocnita = new Region { Id = 23, NameRO = "Ocnița", NameEN = "Ocnita" };
                //var Cantemir = new Region { Id = 24, NameRO = "Cantemir", NameEN = "Cantemir" };
                //var AneniiNoi = new Region { Id = 25, NameRO = "Anenii Noi", NameEN = "Anenii Noi" };
                //var Soldanesti = new Region { Id = 26, NameRO = "Șoldanești", NameEN = "Soldanesti" };
                //var Taraclia = new Region { Id = 27, NameRO = "Taraclia", NameEN = "Taraclia" };
                //var Glodeni = new Region { Id = 28, NameRO = "Glodeni", NameEN = "Glodeni" };
                //var StefanVoda = new Region { Id = 29, NameRO = "Ștefan-Vodă", NameEN = "Stefan-Voda" };
                //var Cahul = new Region { Id = 30, NameRO = "Cahul", NameEN = "Cahul" };
                //var Briceni = new Region { Id = 31, NameRO = "Briceni", NameEN = "Briceni" };
                //var Basarabeasca = new Region { Id = 32, NameRO = "Basarabeasca", NameEN = "Basarabeasca" };
                //var Bender = new Region { Id = 33, NameRO = "Bender", NameEN = "Bender" };
                //var Tiraspol = new Region { Id = 34, NameRO = "Tiraspol", NameEN = "Tiraspol" };
                //var Floresti = new Region { Id = 35, NameRO = "Florești", NameEN = "Floresti" };
                //var Singerei = new new Region { Id = 36, NameRO = "Sîngegei", NameEN = "Singerei" };

                //context.Add(Chisinau);
                //context.Add(Balti); //what a !@#@*&^ it should make for all 36
            }
        }
    }
}
