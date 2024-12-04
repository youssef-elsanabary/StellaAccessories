using Microsoft.EntityFrameworkCore;
using StellaAccessories.Models;
using System;

namespace StellaAccessories.Context
{
    public class StellaDbContext : DbContext
    {
        public StellaDbContext(DbContextOptions<StellaDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
