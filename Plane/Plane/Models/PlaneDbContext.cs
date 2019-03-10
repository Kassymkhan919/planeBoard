using System;
using Microsoft.EntityFrameworkCore;

namespace Plane.Models
{
    public class PlaneDbContext : DbContext
    {
        public DbSet<Plane> Planes { get; set; }

        public PlaneDbContext(DbContextOptions options): base(options)
        {
        }

        public PlaneDbContext()
        {
        }
    }
}
