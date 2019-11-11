using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using PaceWeb.Models;

namespace PaceWeb.Data
{
    public class PaceDbContext : DbContext
    {
        public PaceDbContext()
        {
        }

        public PaceDbContext(DbContextOptions<PaceDbContext> options)
            : base(options)
        {

        }

        public DbSet<Address> Address { get; set; }

        public DbSet<Assessments> Assessments { get; set; }

        public DbSet<Participants> Participants { get; set; }

        public DbSet<ProjectInfo> ProjectInfo { get; set; }

        public DbSet<BondSeries> BondSeries { get; set; }

    }
}

