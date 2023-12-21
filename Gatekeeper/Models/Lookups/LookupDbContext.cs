using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Gatekeeper.Models.Lookups
{
    public partial class LookupDbContext : DbContext
    {
        private readonly IConfiguration configuration;

        public LookupDbContext(DbContextOptions<LookupDbContext> options) : base(options) { }

        public virtual DbSet<PersonName> PersonNames { get; set; }

        public virtual DbSet<CompanyName> CompanyNames { get; set; }

        public virtual DbSet<POIName> POINames { get; set; }

        public virtual DbSet<AddressInfo> AddressInfos { get; set; }

        public virtual DbSet<ContactInfo> ContactInfos { get; set; }

        public virtual DbSet<Searchrequestfile> RequestfileInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

            //     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            //=> optionsBuilder.UseSqlServer("Server=.\\; Database=GateKeeper;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");

            //   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            //=> optionsBuilder.UseSqlServer(configuration.GetConnectionString("gkConnectionString"));

        }
}
