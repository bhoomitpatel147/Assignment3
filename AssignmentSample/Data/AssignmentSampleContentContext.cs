using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AssignmentSample.Models;

    public class AssignmentSampleContentContext : DbContext
    {
        public AssignmentSampleContentContext (DbContextOptions<AssignmentSampleContentContext> options)
            : base(options)
        {
        }

        public DbSet<AssignmentSample.Models.Content> Content { get; set; }
    }
