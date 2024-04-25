using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace DesignEquipment.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(File.ReadAllText("connection"));
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Blacklist> Blacklist { get; set; }
        public DbSet<Equipment> Equipment { get; set; }
        public DbSet<Rent> Rent { get; set; }
        public DbSet<Comments> Comments { get; set; }
    }
}
