using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop.Domain.Entities;

namespace Workshop.Infrastructure.Persistence
{
    public class WorkshopDbContext : DbContext
    {
        public WorkshopDbContext(DbContextOptions<WorkshopDbContext> options) :base(options)
        {
            
        }
        public DbSet<Domain.Entities.Workshop> Workshop { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Domain.Entities.Workshop>()
                .OwnsOne(c => c.ContactDetails);
              
        }

    }
}
