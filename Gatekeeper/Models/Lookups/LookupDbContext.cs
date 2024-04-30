using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Gatekeeper.Models.Lookups
{
    public partial class LookupDbContext : DbContext
    {
        private readonly IConfiguration configuration;

        public LookupDbContext(DbContextOptions<LookupDbContext> options) : base(options) { }

        public virtual DbSet<AddressInfo> AddressInfos { get; set; }

        public virtual DbSet<SearchAnalystNotes> AnalystNoteInfos { get; set; }
        public virtual DbSet<CompanyName> CompanyNames { get; set; }

        public virtual DbSet<ContactInfo> ContactInfos { get; set; }

        public virtual DbSet<DisclosedViewitem> DisclosedViewitems { get; set; }

        public virtual DbSet<SearchExtension> ExtensionInfos { get; set; }
        
        public virtual DbSet<HolidayView> HolidayInfos { get; set; }

        public virtual DbSet<SearchLkLocation> LkLocationInfos { get; set; }

        public virtual DbSet<SearchLkPaymentTypes> LkPaymentTypeInfos { get; set; }


        public virtual DbSet<SearchLkCity> LkCityInfos { get; set; }

        //public virtual DbSet<LkRequeststate> LkRequeststates { get; set; }
        public virtual DbSet<SearchLkRequestState> LkRequestStateInfos { get; set; }
        
        public virtual DbSet<SearchLkRecordDeliveryMethod> LkRecordDeliveryMethodInfos { get; set; }


        public virtual DbSet<LkSection> LkSections { get; set; }

        public virtual DbSet<SearchLkSections> LkSectionInfos { get; set; }
        
        public virtual DbSet<LocationViewitem> LocationViewitems { get; set; }

        public virtual DbSet<Searchmytask> MytaskfileInfos { get; set; }

        public virtual DbSet<SearchPayment> PaymentInfos { get; set; }
        public virtual DbSet<PersonName> PersonNames { get; set; }

        public virtual DbSet<POIName> POINames { get; set; }

        public virtual DbSet<ProcessingDeficiencyView> ProcessingDeficiencyInfos { get; set; }

        public virtual DbSet<SearchRequestfee> RequestfeeInfos { get; set; }

        public virtual DbSet<Searchrequestfile> RequestfileInfos { get; set; }

        public virtual DbSet<Summarydisclosure> Summarydisclosures { get; set; }

        public virtual DbSet<SearchVideoNotes> VideoNoteInfos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<AddressInfo>().HasNoKey();
            modelBuilder.Entity<ContactInfo>().HasNoKey();
            modelBuilder.Entity<Searchrequestfile>().HasNoKey();
            modelBuilder.Entity<Searchmytask>().HasNoKey();
            modelBuilder.Entity<SearchAnalystNotes>().HasNoKey();
            modelBuilder.Entity<SearchVideoNotes>().HasNoKey();
            modelBuilder.Entity<DisclosedViewitem>().HasNoKey();
            modelBuilder.Entity<Summarydisclosure>().HasNoKey();
            modelBuilder.Entity<SearchPayment>().HasNoKey();
            modelBuilder.Entity<DisclosedViewitem>().HasNoKey();
            modelBuilder.Entity<LocationViewitem>().HasNoKey();
            modelBuilder.Entity<SearchRequestfee>().HasNoKey();
            modelBuilder.Entity<SearchExtension>().HasNoKey();
            modelBuilder.Entity<HolidayView>().HasNoKey();
            modelBuilder.Entity<ProcessingDeficiencyView>().HasNoKey();
            modelBuilder.Entity<LkSection>().HasNoKey();
         


        }

        //     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //=> optionsBuilder.UseSqlServer("Server=.\\; Database=GateKeeper;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");

        //   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //=> optionsBuilder.UseSqlServer(configuration.GetConnectionString("gkConnectionString"));

    }
}
