using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assesment.Models;
using Assesment.Seeders;
using Microsoft.EntityFrameworkCore;

namespace Assesment.Data;

public class ApplicationDbContext : DbContext
{

    public DbSet<User> Users { get; set; }



    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
    {
    }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    
         UserSeeder.Seed(modelBuilder);

    }
}
