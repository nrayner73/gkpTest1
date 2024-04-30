using System;
using System.Collections.Generic;
using Gatekeeper.Models;
using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.Models;

public partial class AppDbContext : DbContext
{
//    public AppDbContext()
//    {

//    }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public virtual DbSet<Analyst> Analysts { get; set; }
    public virtual DbSet<Analystnote> Analystnotes { get; set; }
    public virtual DbSet<AuditLog> AuditLogs { get; set; }
    public virtual DbSet<Discloseditem> Discloseditems { get; set; }
    public virtual DbSet<Extension> Extensions { get; set; }
    public virtual DbSet<Holiday> Holidays { get; set; }
    public virtual DbSet<LkCity> LkCities { get; set; }
    public virtual DbSet<LkExtension> LkExtensions { get; set; }
    
    public virtual DbSet<LkLocationsearch> LkLocationsearchs { get; set; }
    public virtual DbSet<LkMytaskstatus> LkMytaskstatuses { get; set; }
    public virtual DbSet<LkPage> LkPages { get; set; }
    public virtual DbSet<LkPaymenttype> LkPaymenttypes { get; set; }
    public virtual DbSet<LkProcessingdeficiency> LkProcessingdeficiencies { get; set; }
    public virtual DbSet<LkProvince> LkProvinces { get; set; }
    public virtual DbSet<LkReason> LkReasons { get; set; }
    public virtual DbSet<LkReasongroup> LkReasongroups { get; set; }
    public virtual DbSet<LkRecorddeliverymethod> LkRecorddeliverymethods { get; set; }

    public virtual DbSet<LkReviewtype> LkReviewtypes { get; set; }
    public virtual DbSet<LkRequeststate> LkRequeststates { get; set; }
    public virtual DbSet<LkRequesttype> LkRequesttypes { get; set; }

    public virtual DbSet<LkSection> LkSections { get; set; }

    public virtual DbSet<Locationitem> Locationitems { get; set; }
    public virtual DbSet<Mytask> Mytasks { get; set; }
    public virtual DbSet<Oipc> Oipcs { get; set; }
    public virtual DbSet<OipcItem> OipcItems { get; set; }
    public virtual DbSet<Pageitem> Pageitems { get; set; }
    public virtual DbSet<Payment> Payments { get; set; }
    public virtual DbSet<Person> People { get; set; }
    public virtual DbSet<Requestfee> Requestfees { get; set; }
    public virtual DbSet<Requestfile> Requestfiles { get; set; }
    public virtual DbSet<Sectionuseditem> Sectionuseditems { get; set; }
    public virtual DbSet<Summarydisclosure> Summarydisclosures { get; set; }
    public virtual DbSet<Videonote> Videonotes { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.HasDefaultSchema("gkp");
    }

}
