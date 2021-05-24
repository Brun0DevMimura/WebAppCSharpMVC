using Microsoft.EntityFrameworkCore;

namespace WebApplicationFirst.Data
{
    public class WebApplicationFirstContext : DbContext
    {
        public WebApplicationFirstContext (DbContextOptions<WebApplicationFirstContext> options) : base(options)
        {
        }

        public DbSet<WebApplicationFirst.Models.Departament> Departament { get; set; }
        public DbSet<WebApplicationFirst.Models.Seller> Seller { get; set; }
        public DbSet<WebApplicationFirst.Models.SalesRecord> SalesRecords { get; set; }
    }
}
