using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AssignmentSample.Models;
using System;
using System.Linq;



namespace AssignmentSample.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AssignmentSampleContentContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AssignmentSampleContentContext>>()))
            {
                // Look for any content.
                if (context.Content.Any())
                {
                    return;   // DB has been seeded
                }

                context.Content.AddRange(
                    new Content
                    {
                        Title = "Kevi Mitnick's security",
                        Type = "Ethical",
                        Body = "Never",
                        Tag = "One",
                        ImgUrl = "www.youtube.com"
                    },

                    new Content
                    {
                        Title = "Garry Mackinon's security",
                        Type = "Non- Ethical",
                        Body = "Energetic",
                        Tag = "Two",
                        ImgUrl = "www.facebook.com"
                    },

                    new Content
                    {
                        Title = "Bhoomit's security",
                        Type = "Ethical Little",
                        Body = "Higher Power",
                        Tag = "Three",
                        ImgUrl = "www.hacker.com"
                    },

                    new Content
                    {
                        Title = "Jonathan Johnson's security",
                        Type = "Lower",
                        Body = "Nothing",
                        Tag = "Four",
                        ImgUrl = "www.twitter.com"
                    },

                    new Content
                    {
                        Title = "Peter Parker's security",
                        Type = "Higher",
                        Body = "Content creater",
                        Tag = "Five",
                        ImgUrl = "www.instagram.com"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}