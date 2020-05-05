using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp_Cotet_Andreea_Roxana_Rp.Models;

namespace Asp_Cotet_Andreea_Roxana_Rp.Data
{
    public class Asp_Cotet_Andreea_Roxana_RpContext : DbContext
    {
        public Asp_Cotet_Andreea_Roxana_RpContext (DbContextOptions<Asp_Cotet_Andreea_Roxana_RpContext> options)
            : base(options)
        {
        }

        public DbSet<Asp_Cotet_Andreea_Roxana_Rp.Models.Movie> Movie { get; set; }
    }
}
