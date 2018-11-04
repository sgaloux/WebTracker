using System;
using Microsoft.EntityFrameworkCore;
using WebTracker.Domain;

namespace WebTracker.DataAccess
{
    public class WebTrackerDbContext: DbContext
    {
        public DbSet<WorkDay> WorkDays { get; set; }

        public WebTrackerDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
