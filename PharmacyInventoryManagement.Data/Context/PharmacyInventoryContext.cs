using Microsoft.EntityFrameworkCore;
using PharmacyInventoryManagement.Data.Entities;

namespace PharmacyInventoryManagement.Data.Context
{
    public class PharmacyInventoryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("PharmacyInventoryManagementDb");
        }

        public DbSet<Administration> Administrations { get; set; }
    }
}
