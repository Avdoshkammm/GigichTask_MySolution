using Microsoft.EntityFrameworkCore;

namespace GigichTask_MySolution_.Models
{
    public class TabachkaContext : DbContext
    {
        public TabachkaContext(DbContextOptions<TabachkaContext> options) : base(options)
        {
            
        }

        public DbSet<Tabachka> Tabak { get; set; }
    }
}
