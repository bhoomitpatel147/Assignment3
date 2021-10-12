using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HackingData.Models;

    public class HackersHackerPagesContext : DbContext
    {
        public HackersHackerPagesContext (DbContextOptions<HackersHackerPagesContext> options)
            : base(options)
        {
        }

        public DbSet<HackingData.Models.HackData> HackData { get; set; }
    }
