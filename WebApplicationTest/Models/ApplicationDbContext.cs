using Microsoft.EntityFrameworkCore;

namespace WebApplicationTest.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Conversion> conversions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            string connextionString = "server=localhost;port=3306;database=test_db;user=test_user;password=test_user";
            dbContextOptionsBuilder.UseMySql(connextionString,ServerVersion.AutoDetect(connextionString));
        }
    }
}
