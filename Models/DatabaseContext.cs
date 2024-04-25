using Microsoft.EntityFrameworkCore;

namespace DesignEquipment.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL();
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Blacklist> Blacklist { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Rent> Rent { get; set; }
    }
}
