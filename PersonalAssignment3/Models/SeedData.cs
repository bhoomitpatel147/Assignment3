using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace HackingData.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new HackersHackerPagesContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<HackersHackerPagesContext>>()))
            {
                // Look for any movies.
                if (context.HackData.Any())
                {
                    return;   // DB has been seeded
                }
      
                context.HackData.AddRange(
                    new HackData
                    {
                        Name = "Kevin Mitnick",
                        PowerAcquisitionDate = DateTime.Parse("1989-2-12"),
                        Address = "USA",
                        BirthYear = "1959",
                        Type = "Black Hat",
                        Ethics = false
                    },
                  


                    new HackData
                    {
                        Name = "Garry Mackinon",
                        PowerAcquisitionDate = DateTime.Parse("1999-7-12"),
                        Address = "USA",
                        BirthYear = "2000",
                        Type = "White Hat",
                        Ethics = true
                    },

                    new HackData
                    {
                        Name = "Perker Lord",
                        PowerAcquisitionDate = DateTime.Parse("1989-10-30"),
                        Address = "Canada",
                        BirthYear = "1988",
                        Type = "Gray Hat",
                        Ethics = false
                    },

                    new HackData
                    {
                        Name = "Jonathan Johnson",
                        PowerAcquisitionDate = DateTime.Parse("1981-05-14"),
                        Address = "Rasia",
                        BirthYear = "1991",
                        Type = "White Hat",
                        Ethics = true
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
