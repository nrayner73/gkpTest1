using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gatekeeper.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "gkp");

            migrationBuilder.CreateTable(
                name: "analyst",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Regno = table.Column<string>(type: "varchar(150)", nullable: true),
                    Localname = table.Column<string>(type: "varchar(150)", nullable: true),
                    Displayname = table.Column<string>(type: "varchar(150)", nullable: true),
                    Email = table.Column<string>(type: "varchar(150)", nullable: true),
                    Role = table.Column<string>(type: "varchar(150)", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", nullable: true),
                    Moddate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Moduser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(45)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_analyst", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "analystnote",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Requestid = table.Column<int>(type: "int", nullable: true),
                    Enterdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Analystid = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "varchar(max)", nullable: true),
                    Timetaken = table.Column<string>(type: "varchar(150)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: true),
                    Supervisornotes = table.Column<string>(type: "varchar(max)", nullable: true),
                    Supervisorapproved = table.Column<int>(type: "int", nullable: true),
                    Moddate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Moduser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(45)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_analystnote", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AuditLog",
                schema: "gkp",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccessDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "varchar(50)", nullable: true),
                    AccessSystem = table.Column<string>(type: "varchar(50)", nullable: true),
                    Activity = table.Column<string>(type: "varchar(max)", nullable: true),
                    AccessNiche = table.Column<string>(type: "varchar(50)", nullable: true),
                    ActivityXml = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OccurrenceNo = table.Column<string>(type: "varchar(50)", nullable: true),
                    RegNo = table.Column<string>(type: "varchar(50)", nullable: true),
                    Sdate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditLog", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "discloseditems",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Requestid = table.Column<int>(type: "int", nullable: false),
                    Sectionid = table.Column<int>(type: "int", nullable: false),
                    Sectiontype = table.Column<string>(type: "varchar(45)", nullable: true),
                    Othertext = table.Column<string>(type: "varchar(255)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_discloseditems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "extensions",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Requestid = table.Column<int>(type: "int", nullable: true),
                    Extensionid = table.Column<int>(type: "int", nullable: true),
                    Sectionid = table.Column<int>(type: "int", nullable: true),
                    Extensiondate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Dayamount = table.Column<int>(type: "int", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Moddate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Moduser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_extensions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "holidays",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Holidayname = table.Column<string>(type: "varchar(150)", nullable: true),
                    Holidaydate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Moddate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Moduser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_holidays", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lk_city",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detail = table.Column<string>(type: "varchar(255)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lk_city", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lk_extensions",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detail = table.Column<string>(type: "varchar(255)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lk_extensions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lk_locationsearch",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detail = table.Column<string>(type: "varchar(255)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lk_locationsearch", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lk_mytaskstatus",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detail = table.Column<string>(type: "varchar(255)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lk_mytaskstatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lk_pages",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detail = table.Column<string>(type: "varchar(255)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lk_pages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lk_paymenttype",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detail = table.Column<string>(type: "varchar(255)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", nullable: true),
                    Sortby = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lk_paymenttype", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lk_processingdeficiency",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detail = table.Column<string>(type: "varchar(255)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lk_processingdeficiency", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lk_province",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detail = table.Column<string>(type: "varchar(255)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lk_province", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lk_reason",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Groupid = table.Column<int>(type: "int", nullable: true),
                    Detail = table.Column<string>(type: "varchar(255)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lk_reason", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lk_reasongroup",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detail = table.Column<string>(type: "varchar(255)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lk_reasongroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lk_recorddeliverymethod",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detail = table.Column<string>(type: "varchar(255)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lk_recorddeliverymethod", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lk_requeststate",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detail = table.Column<string>(type: "varchar(255)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Sortby = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lk_requeststate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lk_requesttypes",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detail = table.Column<string>(type: "varchar(255)", nullable: true),
                    Refertype = table.Column<string>(type: "varchar(10)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Sortby = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lk_requesttypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lk_reviewtypes",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Detail = table.Column<string>(type: "varchar(255)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lk_reviewtypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "lk_sections",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sectiontype = table.Column<string>(type: "varchar(255)", nullable: true),
                    Section = table.Column<string>(type: "varchar(255)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", nullable: true),
                    Sortby = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lk_sections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "locationitems",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Requestid = table.Column<int>(type: "int", nullable: true),
                    Locationid = table.Column<int>(type: "int", nullable: true),
                    Othertext = table.Column<string>(type: "varchar(255)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_locationitems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mytasks",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fileid = table.Column<int>(type: "int", nullable: true),
                    Taskid = table.Column<int>(type: "int", nullable: true),
                    Assignby = table.Column<string>(type: "varchar(50)", nullable: true),
                    Assigndate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Taskstatusid = table.Column<int>(type: "int", nullable: true),
                    Closedate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "varchar(2000)", nullable: true),
                    Mytaskstatus = table.Column<string>(type: "varchar(50)", nullable: true),
                    Approveby = table.Column<string>(type: "varchar(50)", nullable: true),
                    Approvedate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Moddate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Moduser = table.Column<string>(type: "varchar(50)", nullable: true),
                    Createtime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(50)", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", nullable: true),
                    Remarks = table.Column<string>(type: "varchar(1000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mytasks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "odata",
                schema: "gkp",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NewFileNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileNumber = table.Column<string>(type: "varchar(50)", nullable: true),
                    RequestDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReceivedDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestDueDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReferenceNumber = table.Column<string>(type: "varchar(max)", nullable: true),
                    Idviewed = table.Column<int>(type: "int", nullable: true),
                    Requesttypeid = table.Column<int>(type: "int", nullable: true),
                    RequestType = table.Column<string>(type: "varchar(150)", nullable: true),
                    Recorddeliverymethodid = table.Column<int>(type: "int", nullable: true),
                    RecordDeliveryMethod = table.Column<string>(type: "varchar(150)", nullable: true),
                    Processingdeficiencyid = table.Column<int>(type: "int", nullable: true),
                    ProcessingDeficiency = table.Column<string>(type: "varchar(max)", nullable: true),
                    Personid = table.Column<int>(type: "int", nullable: true),
                    Analystassignedid = table.Column<int>(type: "int", nullable: true),
                    AnalystAssigned = table.Column<string>(type: "varchar(max)", nullable: true),
                    RequestDetails = table.Column<string>(type: "varchar(max)", nullable: true),
                    PreviousRequests = table.Column<string>(type: "varchar(max)", nullable: true),
                    IntakeNotes = table.Column<string>(type: "varchar(max)", nullable: true),
                    TimeFrame = table.Column<string>(type: "varchar(max)", nullable: true),
                    RequestStateid = table.Column<int>(type: "int", nullable: true),
                    RequestState = table.Column<string>(type: "varchar(max)", nullable: true),
                    ClosedDate = table.Column<string>(type: "varchar(max)", nullable: true),
                    Moddate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Moduser = table.Column<string>(type: "varchar(5)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_odata", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "oipc",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Requestid = table.Column<int>(type: "int", nullable: true),
                    Reviewtypeid = table.Column<int>(type: "int", nullable: true),
                    Date_received = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Oipc_file_number = table.Column<string>(type: "varchar(50)", nullable: true),
                    Date_to_be_completed_by = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Review_closed_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    What_is_being_reviewed = table.Column<string>(type: "varchar(max)", nullable: true),
                    Sent_to_inquiry = table.Column<string>(type: "varchar(5)", nullable: true),
                    What_is_at_inquiry = table.Column<string>(type: "varchar(max)", nullable: true),
                    Applicant_initial_submission_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Respondent_initial_submission_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Applicant_rebuttal_submission_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Respondent_rebuttal_submission_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Order_number = table.Column<string>(type: "varchar(50)", nullable: true),
                    Date_order_received = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Date_of_compliance_to_order = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Oipc_findings = table.Column<string>(type: "varchar(max)", nullable: true),
                    Judicial_review = table.Column<string>(type: "varchar(50)", nullable: true),
                    Judicial_date_review = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Submission_judicial_review_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Decision_number = table.Column<string>(type: "varchar(50)", nullable: true),
                    Summary_of_decision = table.Column<string>(type: "varchar(max)", nullable: true),
                    Cpsfilenumber = table.Column<string>(type: "varchar(50)", nullable: true),
                    Moddate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Moduser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oipc", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "oipc_items",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Oipcid = table.Column<int>(type: "int", nullable: true),
                    Reasonid = table.Column<int>(type: "int", nullable: true),
                    Groupid = table.Column<int>(type: "int", nullable: true),
                    Othertext = table.Column<string>(type: "varchar(250)", nullable: true),
                    Moddate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Moduser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oipc_items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "pageitems",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Requestid = table.Column<int>(type: "int", nullable: true),
                    Pageid = table.Column<int>(type: "int", nullable: true),
                    Othertext = table.Column<string>(type: "varchar(255)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pageitems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "payments",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Requestid = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "varchar(250)", nullable: true),
                    Authorization = table.Column<string>(type: "varchar(250)", nullable: true),
                    Paytypeid = table.Column<int>(type: "int", nullable: true),
                    Paymentdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Payamount = table.Column<int>(type: "int", nullable: true),
                    Finalcost = table.Column<int>(type: "int", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Moddate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Moduser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "person",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(type: "varchar(1000)", nullable: true),
                    Lastname = table.Column<string>(type: "varchar(1000)", nullable: true),
                    Middlename = table.Column<string>(type: "varchar(1000)", nullable: true),
                    Previousname = table.Column<string>(type: "varchar(1000)", nullable: true),
                    Companyname = table.Column<string>(type: "varchar(1000)", nullable: true),
                    Birthdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Daytimephone = table.Column<string>(type: "varchar(500)", nullable: true),
                    Alternatephone = table.Column<string>(type: "varchar(500)", nullable: true),
                    Faxphone = table.Column<string>(type: "varchar(500)", nullable: true),
                    Email = table.Column<string>(type: "varchar(500)", nullable: true),
                    Street = table.Column<string>(type: "varchar(1000)", nullable: true),
                    City = table.Column<string>(type: "varchar(1000)", nullable: true),
                    Province = table.Column<string>(type: "varchar(1000)", nullable: true),
                    Postalcode = table.Column<string>(type: "varchar(45)", nullable: true),
                    Country = table.Column<string>(type: "varchar(500)", nullable: true),
                    Personofinterestfirstname = table.Column<string>(type: "varchar(1000)", nullable: true),
                    Personofinterestmiddlename = table.Column<string>(type: "varchar(1000)", nullable: true),
                    Personofinterestlastname = table.Column<string>(type: "varchar(1000)", nullable: true),
                    Remark = table.Column<string>(type: "varchar(max)", nullable: true),
                    Moddate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Moduser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createdby = table.Column<string>(type: "varchar(45)", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", nullable: true),
                    Gkpid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "requestfees",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Requestid = table.Column<int>(type: "int", nullable: true),
                    Paytypeid = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "varchar(250)", nullable: true),
                    Estimatedcost = table.Column<int>(type: "int", nullable: true),
                    Requested = table.Column<string>(type: "varchar(5)", nullable: true),
                    Feewaived = table.Column<string>(type: "varchar(5)", nullable: true),
                    Finalcost = table.Column<int>(type: "int", nullable: true),
                    Moddate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Moduser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_requestfees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "requestfiles",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Yearid = table.Column<int>(type: "int", nullable: true),
                    Filenumber = table.Column<string>(type: "varchar(50)", nullable: true),
                    Requestdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Receivedate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Requestduedate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Referencenumber = table.Column<string>(type: "varchar(2000)", nullable: true),
                    Idviewed = table.Column<int>(type: "int", nullable: true),
                    Requesttypeid = table.Column<int>(type: "int", nullable: true),
                    Recorddeliverymethodid = table.Column<int>(type: "int", nullable: true),
                    Processingdeficiency = table.Column<int>(type: "int", nullable: true),
                    Personid = table.Column<int>(type: "int", nullable: true),
                    Analystassignedid = table.Column<int>(type: "int", nullable: true),
                    Requestdetails = table.Column<string>(type: "varchar(max)", nullable: true),
                    Previousrequests = table.Column<string>(type: "varchar(max)", nullable: true),
                    Intakenotes = table.Column<string>(type: "varchar(max)", nullable: true),
                    Timeframe = table.Column<string>(type: "varchar(max)", nullable: true),
                    Requeststate = table.Column<int>(type: "int", nullable: true),
                    Closedate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Archivedate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Oipccomment = table.Column<string>(type: "varchar(2000)", nullable: true),
                    Feepayment = table.Column<string>(type: "varchar(1000)", nullable: true),
                    Remarks = table.Column<string>(type: "varchar(max)", nullable: true),
                    Moddate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Moduser = table.Column<string>(type: "varchar(50)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(50)", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", nullable: true),
                    Gkpid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_requestfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "sectionuseditems",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Requestid = table.Column<int>(type: "int", nullable: true),
                    Sectionid = table.Column<int>(type: "int", nullable: true),
                    Sectiontype = table.Column<string>(type: "varchar(45)", nullable: true),
                    Othertext = table.Column<string>(type: "varchar(255)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sectionuseditems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "summarydisclosure",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Requestid = table.Column<int>(type: "int", nullable: true),
                    Fileclosedate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Pagesidentified = table.Column<string>(type: "varchar(50)", nullable: true),
                    Pagesdisclosed = table.Column<string>(type: "varchar(50)", nullable: true),
                    Pagedisclosedate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Videoidentified = table.Column<string>(type: "varchar(50)", nullable: true),
                    Videodisclosed = table.Column<string>(type: "varchar(50)", nullable: true),
                    Videodisclosedate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Audioidentified = table.Column<string>(type: "varchar(50)", nullable: true),
                    Audiodisclosed = table.Column<string>(type: "varchar(50)", nullable: true),
                    Audiodisclosedate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Remarks = table.Column<string>(type: "varchar(max)", nullable: true),
                    Moddate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Moduser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_summarydisclosure", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "videonotes",
                schema: "gkp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Requestid = table.Column<int>(type: "int", nullable: true),
                    Enterdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Analystid = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "varchar(max)", nullable: true),
                    Timetaken = table.Column<string>(type: "varchar(150)", nullable: true),
                    Status = table.Column<string>(type: "varchar(5)", nullable: true),
                    Moddate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Moduser = table.Column<string>(type: "varchar(45)", nullable: true),
                    Createdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Createuser = table.Column<string>(type: "varchar(45)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_videonotes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "analyst",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "analystnote",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "AuditLog",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "discloseditems",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "extensions",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "holidays",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "lk_city",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "lk_extensions",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "lk_locationsearch",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "lk_mytaskstatus",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "lk_pages",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "lk_paymenttype",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "lk_processingdeficiency",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "lk_province",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "lk_reason",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "lk_reasongroup",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "lk_recorddeliverymethod",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "lk_requeststate",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "lk_requesttypes",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "lk_reviewtypes",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "lk_sections",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "locationitems",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "mytasks",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "odata",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "oipc",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "oipc_items",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "pageitems",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "payments",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "person",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "requestfees",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "requestfiles",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "sectionuseditems",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "summarydisclosure",
                schema: "gkp");

            migrationBuilder.DropTable(
                name: "videonotes",
                schema: "gkp");
        }
    }
}
