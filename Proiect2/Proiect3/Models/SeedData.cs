using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyPhotosManagerWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPhotosManagerWeb.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MyPhotosManagerWebContext(serviceProvider.GetRequiredService<DbContextOptions<MyPhotosManagerWebContext>>()))
            {
                // Look for any movies.
                if (context.PhotoDTO.Any())
                {
                    return;   // DB has been seeded
                }
                context.PhotoDTO.AddRange(

                    new PhotoDTO
                    {
                        Name = "Fructe",
                        Path= "C:\\Users\\Roxana\\Desktop\\images\\mar.jpg",
                        CreationDate = "1989-2-12",
                        Location = "livada, toamne, sanatos",
                        IsDeleted = false,
                        IsVideo = false,
                        Event = new EventDTO
                        {
                            Name = "toamna"
                        }

                    },

                    new PhotoDTO
                    {
                        Name = "Ferma",
                        Path = "C:\\Users\\Roxana\\Desktop\\images\\ferma.jpg",
                        CreationDate = "1989-5-12",
                        Location = "la tara, vacanta vara, la tara, animale",
                        IsDeleted = false,
                        IsVideo = false,
                        Event = new EventDTO
                        {
                            Name = "vacanta vara, la tara, animale"
                        }

                    },

                    new PhotoDTO
                    {
                        Name = "Mare",
                        Path = "C:\\Users\\Roxana\\Desktop\\images\\mare.jpg",
                        CreationDate = "1999-08-23",
                        Location = "Marea Neagra, vacanta de vara, soare, plaja",
                        IsDeleted = false,
                        IsVideo = false,
                        Event =  new EventDTO
                        {
                            Name = "vacanta de vara"
                        }

                    },

                    new PhotoDTO
                    {
                        Name = "Munte",
                        Path = "C:\\Users\\Roxana\\Desktop\\images\\munte.jpg",
                        CreationDate = "1989-2-03",
                        Location = "Bucegi, vacanta de iarna, zapada, Craciun, sanie, frig",
                        IsDeleted = false,
                        IsVideo = false,
                        Event =  new EventDTO
                        {
                            Name = "vacanta de iarna"
                        }
                    }, 

                    new PhotoDTO
                    {
                        Name = "Familie",
                        Path = "C:\\Users\\Roxana\\Desktop\\images\\familie.jpg",
                        CreationDate = "1989-2-03",
                        Location = "Acasa, iubire, casa, sarbatori, mama",
                        IsDeleted = false,
                        IsVideo = false,
                        Event =  new EventDTO
                        {
                            Name = "sarbatori"
                        }
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
