using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyPhotosManagerWeb.Models;

namespace MyPhotosManagerWeb.Data
{
    public class MyPhotosManagerWebContext : DbContext
    {
        public MyPhotosManagerWebContext (DbContextOptions<MyPhotosManagerWebContext> options)
            : base(options)
        {
        }

        public DbSet<MyPhotosManagerWeb.Models.DetailDTO> DetailDTO { get; set; }
		public DbSet<MyPhotosManagerWeb.Models.PhotoDTO> PhotoDTO { get; set; }
        public DbSet<MyPhotosManagerWeb.Models.EventDTO> EventDTO { get; set; }

        public DbSet<MyPhotosManagerWeb.Models.PeopleDTO> PeopleDTO { get; set; }

	}
}
