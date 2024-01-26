using System;
using System.Collections.Generic;


using Microsoft.EntityFrameworkCore;

namespace Gatekeeper.Models;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
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

    public virtual DbSet<LkLocationsearch> LkLocationsearches { get; set; }

    public virtual DbSet<LkMytaskstatus> LkMytaskstatuses { get; set; }

    public virtual DbSet<LkNametype> LkNametypes { get; set; }

    public virtual DbSet<LkPage> LkPages { get; set; }

    public virtual DbSet<LkProcessingdeficiency> LkProcessingdeficiencies { get; set; }

    public virtual DbSet<LkProvince> LkProvinces { get; set; }

    public virtual DbSet<LkReason> LkReasons { get; set; }

    public virtual DbSet<LkReasongroup> LkReasongroups { get; set; }

    public virtual DbSet<LkRecorddeliverymethod> LkRecorddeliverymethods { get; set; }

    public virtual DbSet<LkRequeststate> LkRequeststates { get; set; }

    public virtual DbSet<LkRequesttype> LkRequesttypes { get; set; }

    public virtual DbSet<LkReviewtype> LkReviewtypes { get; set; }

    public virtual DbSet<LkSection> LkSections { get; set; }

    public virtual DbSet<Locationitem> Locationitems { get; set; }

    public virtual DbSet<Mytask> Mytasks { get; set; }

    public virtual DbSet<Oipc> Oipcs { get; set; }

    public virtual DbSet<OipcItem> OipcItems { get; set; }

    public virtual DbSet<Pageitem> Pageitems { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Requestfee> Requestfees { get; set; }

    public virtual DbSet<Requestfile> Requestfiles { get; set; }

    public virtual DbSet<Requestpayment> Requestpayments { get; set; }

    public virtual DbSet<Summarydisclosure> Summarydisclosures { get; set; }

    public virtual DbSet<Videonote> Videonotes { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\; Database=GateKeeper;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Analyst>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__analyst__3213E83FAF4FEE79");

            entity.ToTable("analyst", "gkp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Createuser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("createuser");
            entity.Property(e => e.Displayname)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("displayname");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Localname)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("localname");
            entity.Property(e => e.Moddate)
                .HasColumnType("datetime")
                .HasColumnName("moddate");
            entity.Property(e => e.Moduser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("moduser");
            entity.Property(e => e.Regno)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("regno");
            entity.Property(e => e.Role)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("role");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Analystnote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__analystn__3213E83FE4DFFC72");

            entity.ToTable("analystnote", "gkp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Analystid).HasColumnName("analystid");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Createuser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("createuser");
            entity.Property(e => e.Enterdate)
                .HasColumnType("datetime")
                .HasColumnName("enterdate");
            entity.Property(e => e.Moddate)
                .HasColumnType("datetime")
                .HasColumnName("moddate");
            entity.Property(e => e.Moduser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("moduser");
            entity.Property(e => e.Notes)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Requestid).HasColumnName("requestid");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Supervisorapproved).HasColumnName("supervisorapproved");
            entity.Property(e => e.Supervisornotes)
                .IsUnicode(false)
                .HasColumnName("supervisornotes");
            entity.Property(e => e.Timetaken)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("timetaken");
        });

        modelBuilder.Entity<AuditLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AuditLog__3214EC271696DFF0");

            entity.ToTable("AuditLog", "gkp");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccessDate).HasColumnType("datetime");
            entity.Property(e => e.AccessNiche)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AccessSystem)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Activity).IsUnicode(false);
            entity.Property(e => e.ActivityXml)
                .HasColumnType("xml")
                .HasColumnName("ActivityXML");
            entity.Property(e => e.OccurrenceNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.RegNo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Sdate).HasColumnType("datetime");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Discloseditem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__disclose__3213E83F5306D05E");

            entity.ToTable("discloseditems", "gkp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Createuser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("createuser");
            entity.Property(e => e.Othertext)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("othertext");
            entity.Property(e => e.Requestid).HasColumnName("requestid");
            entity.Property(e => e.Sectionid).HasColumnName("sectionid");
            entity.Property(e => e.Sectiontype)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("sectiontype");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Extension>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__extensio__3213E83FDA871001");

            entity.ToTable("extensions", "gkp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Createuser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("createuser");
            entity.Property(e => e.Dayamount).HasColumnName("dayamount");
            entity.Property(e => e.Extensiondate)
                .HasColumnType("datetime")
                .HasColumnName("extensiondate");
            entity.Property(e => e.Extensionid).HasColumnName("extensionid");
            entity.Property(e => e.Moddate)
                .HasColumnType("datetime")
                .HasColumnName("moddate");
            entity.Property(e => e.Moduser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("moduser");
            entity.Property(e => e.Requestid).HasColumnName("requestid");
            entity.Property(e => e.Section)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("section");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Holiday>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__holidays__3213E83FABA83286");

            entity.ToTable("holidays", "gkp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Createuser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("createuser");
            entity.Property(e => e.Holidaydate)
                .HasColumnType("datetime")
                .HasColumnName("holidaydate");
            entity.Property(e => e.Holidayname)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("holidayname");
            entity.Property(e => e.Moddate)
                .HasColumnType("datetime")
                .HasColumnName("moddate");
            entity.Property(e => e.Moduser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("moduser");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<LkCity>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__lk_city__3213E83F29D467CD");

            entity.ToTable("lk_city", "gkp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Createuser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("createuser");
            entity.Property(e => e.Detail)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("detail");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<LkExtension>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__lk_exten__3213E83FF14ED2EC");

            entity.ToTable("lk_extensions", "gkp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Createuser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("createuser");
            entity.Property(e => e.Detail)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("detail");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<LkLocationsearch>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__lk_locat__3213E83F15FA8826");

            entity.ToTable("lk_locationsearch", "gkp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Createuser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("createuser");
            entity.Property(e => e.Detail)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("detail");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<LkMytaskstatus>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__lk_mytas__3213E83F07756DCE");

            entity.ToTable("lk_mytaskstatus", "gkp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Createuser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("createuser");
            entity.Property(e => e.Detail)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("detail");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<LkNametype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__lk_namet__3213E83F2F03F15E");

            entity.ToTable("lk_nametype", "gkp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Createuser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("createuser");
            entity.Property(e => e.Detail)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("detail");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<LkPage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__lk_pages__3213E83F02DDC1DC");

            entity.ToTable("lk_pages", "gkp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Createuser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("createuser");
            entity.Property(e => e.Detail)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("detail");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<LkProcessingdeficiency>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__lk_proce__3213E83FE5F1D7E2");

            entity.ToTable("lk_processingdeficiency", "gkp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Createuser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("createuser");
            entity.Property(e => e.Detail)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("detail");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<LkProvince>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__lk_provi__3213E83FD16675D6");

            entity.ToTable("lk_province", "gkp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Createuser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("createuser");
            entity.Property(e => e.Detail)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("detail");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<LkReason>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__lk_reaso__3213E83FCD68F751");

            entity.ToTable("lk_reason", "gkp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Createuser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("createuser");
            entity.Property(e => e.Detail)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("detail");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<LkReasongroup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__lk_reaso__3213E83F7043585F");

            entity.ToTable("lk_reasongroup", "gkp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Createuser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("createuser");
            entity.Property(e => e.Detail)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("detail");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<LkRecorddeliverymethod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__lk_recor__3213E83F01F2C5BD");

            entity.ToTable("lk_recorddeliverymethod", "gkp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Createuser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("createuser");
            entity.Property(e => e.Detail)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("detail");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<LkRequeststate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__lk_reque__3213E83FA1A02713");

            entity.ToTable("lk_requeststate", "gkp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Createuser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("createuser");
            entity.Property(e => e.Detail)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("detail");
            entity.Property(e => e.Sortby).HasColumnName("sortby");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<LkRequesttype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__lk_reque__3213E83F0AD8D63F");

            entity.ToTable("lk_requesttypes", "gkp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Createuser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("createuser");
            entity.Property(e => e.Detail)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("detail");
            entity.Property(e => e.Refertype)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("refertype");
            entity.Property(e => e.Sortby).HasColumnName("sortby");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<LkReviewtype>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__lk_revie__3213E83FDBF3BB77");

            entity.ToTable("lk_reviewtypes", "gkp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Createuser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("createuser");
            entity.Property(e => e.Detail)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("detail");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<LkSection>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__lk_secti__3213E83FD90F3B71");

            entity.ToTable("lk_sections", "gkp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Createuser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("createuser");
            entity.Property(e => e.Section)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("section");
            entity.Property(e => e.Sectiontype)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("sectiontype");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Locationitem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__location__3213E83FFF25F5F5");

            entity.ToTable("locationitems", "gkp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Createuser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("createuser");
            entity.Property(e => e.Locationid).HasColumnName("locationid");
            entity.Property(e => e.Othertext)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("othertext");
            entity.Property(e => e.Requestid).HasColumnName("requestid");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Mytask>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mytasks__3213E83F670898E0");

            entity.ToTable("mytasks", "gkp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Approveby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("approveby");
            entity.Property(e => e.Approvedate)
                .HasColumnType("datetime")
                .HasColumnName("approvedate");
            entity.Property(e => e.Assignby)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("assignby");
            entity.Property(e => e.Assigndate)
                .HasColumnType("datetime")
                .HasColumnName("assigndate");
            entity.Property(e => e.Closedate)
                .HasColumnType("datetime")
                .HasColumnName("closedate");
            entity.Property(e => e.Createtime)
                .HasColumnType("datetime")
                .HasColumnName("createtime");
            entity.Property(e => e.Createuser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createuser");
            entity.Property(e => e.Fileid).HasColumnName("fileid");
            entity.Property(e => e.Moddate)
                .HasColumnType("datetime")
                .HasColumnName("moddate");
            entity.Property(e => e.Moduser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("moduser");
            entity.Property(e => e.Mytaskstatus)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("mytaskstatus");
            entity.Property(e => e.Notes)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Remarks)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Taskid).HasColumnName("taskid");
            entity.Property(e => e.Taskstatusid).HasColumnName("taskstatusid");
        });

        modelBuilder.Entity<Oipc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__oipc__3213E83FA41A4D89");

            entity.ToTable("oipc", "gkp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApplicantInitialSubmissionDate)
                .HasColumnType("datetime")
                .HasColumnName("applicant_initial_submission_date");
            entity.Property(e => e.ApplicantRebuttalSubmissionDate)
                .HasColumnType("datetime")
                .HasColumnName("applicant_rebuttal_submission_date");
            entity.Property(e => e.Cpsfilenumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("cpsfilenumber");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Createuser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("createuser");
            entity.Property(e => e.DateOfComplianceToOrder)
                .HasColumnType("datetime")
                .HasColumnName("date_of_compliance_to_order");
            entity.Property(e => e.DateOrderReceived)
                .HasColumnType("datetime")
                .HasColumnName("date_order_received");
            entity.Property(e => e.DateReceived)
                .HasColumnType("datetime")
                .HasColumnName("date_received");
            entity.Property(e => e.DateToBeCompletedBy)
                .HasColumnType("datetime")
                .HasColumnName("date_to_be_completed_by");
            entity.Property(e => e.DecisionNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("decision_number");
            entity.Property(e => e.JudicialDateReview)
                .HasColumnType("datetime")
                .HasColumnName("judicial_date_review");
            entity.Property(e => e.JudicialReview)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("judicial_review");
            entity.Property(e => e.Moddate)
                .HasColumnType("datetime")
                .HasColumnName("moddate");
            entity.Property(e => e.Moduser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("moduser");
            entity.Property(e => e.OipcFileNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("oipc_file_number");
            entity.Property(e => e.OipcFindings)
                .IsUnicode(false)
                .HasColumnName("oipc_findings");
            entity.Property(e => e.OrderNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("order_number");
            entity.Property(e => e.Requestid).HasColumnName("requestid");
            entity.Property(e => e.RespondentInitialSubmissionDate)
                .HasColumnType("datetime")
                .HasColumnName("respondent_initial_submission_date");
            entity.Property(e => e.RespondentRebuttalSubmissionDate)
                .HasColumnType("datetime")
                .HasColumnName("respondent_rebuttal_submission_date");
            entity.Property(e => e.ReviewClosedDate)
                .HasColumnType("datetime")
                .HasColumnName("review_closed_date");
            entity.Property(e => e.Reviewtypeid).HasColumnName("reviewtypeid");
            entity.Property(e => e.SentToInquiry)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("sent_to_inquiry");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.SubmissionJudicialReviewDate)
                .HasColumnType("datetime")
                .HasColumnName("submission_judicial_review_date");
            entity.Property(e => e.SummaryOfDecision)
                .IsUnicode(false)
                .HasColumnName("summary_of_decision");
            entity.Property(e => e.WhatIsAtInquiry)
                .IsUnicode(false)
                .HasColumnName("what_is_at_inquiry");
            entity.Property(e => e.WhatIsBeingReviewed)
                .IsUnicode(false)
                .HasColumnName("what_is_being_reviewed");
        });

        modelBuilder.Entity<OipcItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__oipc_ite__3213E83FC3E539C1");

            entity.ToTable("oipc_items", "gkp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Createuser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("createuser");
            entity.Property(e => e.Groupid).HasColumnName("groupid");
            entity.Property(e => e.Moddate)
                .HasColumnType("datetime")
                .HasColumnName("moddate");
            entity.Property(e => e.Moduser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("moduser");
            entity.Property(e => e.Oipcid).HasColumnName("oipcid");
            entity.Property(e => e.Othertext)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("othertext");
            entity.Property(e => e.Reasonid).HasColumnName("reasonid");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Pageitem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__pageitem__3213E83F05179F84");

            entity.ToTable("pageitems", "gkp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Createuser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("createuser");
            entity.Property(e => e.Othertext)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("othertext");
            entity.Property(e => e.Pageid).HasColumnName("pageid");
            entity.Property(e => e.Requestid).HasColumnName("requestid");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.ToTable("person", "gkp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Alternatephone)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("alternatephone");
            entity.Property(e => e.Birthdate)
                .HasColumnType("datetime")
                .HasColumnName("birthdate");
            entity.Property(e => e.City)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("city");
            entity.Property(e => e.Companyname)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("companyname");
            entity.Property(e => e.Country)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Createdby)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("createdby");
            entity.Property(e => e.Daytimephone)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("daytimephone");
            entity.Property(e => e.Email)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Faxphone)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("faxphone");
            entity.Property(e => e.Firstname)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("firstname");
            entity.Property(e => e.Gkpid).HasColumnName("gkpid");
            entity.Property(e => e.Lastname)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("lastname");
            entity.Property(e => e.Middlename)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("middlename");
            entity.Property(e => e.Moddate)
                .HasColumnType("datetime")
                .HasColumnName("moddate");
            entity.Property(e => e.Moduser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("moduser");
            entity.Property(e => e.Personofinterestfirstname)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("personofinterestfirstname");
            entity.Property(e => e.Personofinterestlastname)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("personofinterestlastname");
            entity.Property(e => e.Personofinterestmiddlename)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("personofinterestmiddlename");
            entity.Property(e => e.Postalcode)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("postalcode");
            entity.Property(e => e.Previousname)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("previousname");
            entity.Property(e => e.Province)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("province");
            entity.Property(e => e.Remark)
                .IsUnicode(false)
                .HasColumnName("remark");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Street)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("street");
        });

        modelBuilder.Entity<Requestfee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__requestf__3213E83FD6EF6FAC");

            entity.ToTable("requestfees", "gkp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Createuser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("createuser");
            entity.Property(e => e.Descp)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descp");
            entity.Property(e => e.Feewaived)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("feewaived");
            entity.Property(e => e.Finalcost)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("finalcost");
            entity.Property(e => e.Moddate)
                .HasColumnType("datetime")
                .HasColumnName("moddate");
            entity.Property(e => e.Moduser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("moduser");
            entity.Property(e => e.Requestid).HasColumnName("requestid");
            entity.Property(e => e.Requesting)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("requesting");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Requestfile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__requestf__3213E83F79D2D2DF");

            entity.ToTable("requestfiles", "gkp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Analystassignedid).HasColumnName("analystassignedid");
            entity.Property(e => e.Archivedate)
                .HasColumnType("datetime")
                .HasColumnName("archivedate");
            entity.Property(e => e.Closedate)
                .HasColumnType("datetime")
                .HasColumnName("closedate");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Createuser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("createuser");
            entity.Property(e => e.Filenumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("filenumber");
            entity.Property(e => e.Gkpid).HasColumnName("gkpid");
            entity.Property(e => e.Idviewed).HasColumnName("idviewed");
            entity.Property(e => e.Intakenotes)
                .IsUnicode(false)
                .HasColumnName("intakenotes");
            entity.Property(e => e.Moddate)
                .HasColumnType("datetime")
                .HasColumnName("moddate");
            entity.Property(e => e.Moduser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("moduser");
            entity.Property(e => e.Oipccomment)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("oipccomment");
            entity.Property(e => e.Personid).HasColumnName("personid");
            entity.Property(e => e.Previousrequests)
                .IsUnicode(false)
                .HasColumnName("previousrequests");
            entity.Property(e => e.Processingdeficiency).HasColumnName("processingdeficiency");
            entity.Property(e => e.Receivedate)
                .HasColumnType("datetime")
                .HasColumnName("receivedate");
            entity.Property(e => e.Recorddeliverymethodid).HasColumnName("recorddeliverymethodid");
            entity.Property(e => e.Referencenumber)
                .HasMaxLength(2000)
                .IsUnicode(false)
                .HasColumnName("referencenumber");
            entity.Property(e => e.Remarks)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Requestdate)
                .HasColumnType("datetime")
                .HasColumnName("requestdate");
            entity.Property(e => e.Requestdetails)
                .IsUnicode(false)
                .HasColumnName("requestdetails");
            entity.Property(e => e.Requestduedate)
                .HasColumnType("datetime")
                .HasColumnName("requestduedate");
            entity.Property(e => e.Requeststate).HasColumnName("requeststate");
            entity.Property(e => e.Requesttypeid).HasColumnName("requesttypeid");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Timeframe)
                .IsUnicode(false)
                .HasColumnName("timeframe");
            entity.Property(e => e.Yearid).HasColumnName("yearid");
        });

        modelBuilder.Entity<Requestpayment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__requestp__3213E83F0B947A39");

            entity.ToTable("requestpayments", "gkp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Createuser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("createuser");
            entity.Property(e => e.Descp)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("descp");
            entity.Property(e => e.Finalcost)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("finalcost");
            entity.Property(e => e.Moddate)
                .HasColumnType("datetime")
                .HasColumnName("moddate");
            entity.Property(e => e.Moduser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("moduser");
            entity.Property(e => e.Payamount)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("payamount");
            entity.Property(e => e.Paydate)
                .HasColumnType("datetime")
                .HasColumnName("paydate");
            entity.Property(e => e.Paytype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("paytype");
            entity.Property(e => e.Requestid).HasColumnName("requestid");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("status");
        });

        modelBuilder.Entity<Summarydisclosure>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__summaryd__3213E83FD4519D67");

            entity.ToTable("summarydisclosure", "gkp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Audiodisclosed)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("audiodisclosed");
            entity.Property(e => e.Audiodisclosedate)
                .HasColumnType("datetime")
                .HasColumnName("audiodisclosedate");
            entity.Property(e => e.Audioidentified)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("audioidentified");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Createuser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("createuser");
            entity.Property(e => e.Fileclosedate)
                .HasColumnType("datetime")
                .HasColumnName("fileclosedate");
            entity.Property(e => e.Moddate)
                .HasColumnType("datetime")
                .HasColumnName("moddate");
            entity.Property(e => e.Moduser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("moduser");
            entity.Property(e => e.Pagedisclosedate)
                .HasColumnType("datetime")
                .HasColumnName("pagedisclosedate");
            entity.Property(e => e.Pagesdisclosed)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pagesdisclosed");
            entity.Property(e => e.Pagesidentified)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("pagesidentified");
            entity.Property(e => e.Remarks)
                .IsUnicode(false)
                .HasColumnName("remarks");
            entity.Property(e => e.Requestid).HasColumnName("requestid");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Videodisclosed)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("videodisclosed");
            entity.Property(e => e.Videodisclosedate)
                .HasColumnType("datetime")
                .HasColumnName("videodisclosedate");
            entity.Property(e => e.Videoidentified)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("videoidentified");
        });

        modelBuilder.Entity<Videonote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__videonot__3213E83F4658DEA1");

            entity.ToTable("videonotes", "gkp");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Analyst)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("analyst");
            entity.Property(e => e.Createdate)
                .HasColumnType("datetime")
                .HasColumnName("createdate");
            entity.Property(e => e.Createuser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("createuser");
            entity.Property(e => e.Enterdate)
                .HasColumnType("datetime")
                .HasColumnName("enterdate");
            entity.Property(e => e.Moddate)
                .HasColumnType("datetime")
                .HasColumnName("moddate");
            entity.Property(e => e.Moduser)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasColumnName("moduser");
            entity.Property(e => e.Notes)
                .IsUnicode(false)
                .HasColumnName("notes");
            entity.Property(e => e.Requestid).HasColumnName("requestid");
            entity.Property(e => e.Status)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.Timetaken)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("timetaken");
        });

   

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
