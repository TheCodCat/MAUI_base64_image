using Microsoft.EntityFrameworkCore;
using Models;

namespace ImageDatabse
{
    public class ImageContext : DbContext
    {
        public DbSet<Image> Images { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data Source=data.db");
        }
    }
}
