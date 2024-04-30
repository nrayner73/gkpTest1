using System;
using System.Net.Http;

using Gatekeeper.Components;
using Gatekeeper.Interfaces;
using Gatekeeper.Models;
using Gatekeeper.Services;
using Microsoft.EntityFrameworkCore;
using Gatekeeper.DataServices.Lookups;
using Gatekeeper.Interfaces.Lookups;
using Gatekeeper.Models.Lookups;
using System.Net.NetworkInformation;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Authentication.Negotiate;
using Gatekeeper.Interfaces.Audit;
using Gatekeeper.DataServices.Audit;
using Gatekeeper.DataServices;
using Gatekeeper.Classes;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Configuration.AddJsonFile("DbConn.json",
        optional: true,
        reloadOnChange: true);

// Add session 
builder.Services.AddBlazoredSessionStorage();

string conStr = string.Empty;

if (System.Environment.MachineName.ToLower() == "cps-dev-03")
{
    conStr = builder.Configuration.GetConnectionString("gkConnectionStringDev");
}
else if (System.Environment.MachineName.ToLower() == "cps-test-03")
{
    conStr = builder.Configuration.GetConnectionString("gkConnectionStringDev");
}
else if (System.Environment.MachineName.ToLower() == "cps-stage-03")
{
    conStr = builder.Configuration.GetConnectionString("gkConnectionStringDev");
}
else if (System.Environment.MachineName.ToLower() == "cps-prod-03")
{
    conStr = builder.Configuration.GetConnectionString("gkConnectionStringDev");
}
else
{
    //Local
    conStr = builder.Configuration.GetConnectionString("gkConnectionStringDev");
}


builder.Services.AddDbContextFactory<AppDbContext>(options =>
options.UseSqlServer(conStr),
          ServiceLifetime.Scoped); // This is the default lifetime if not specified.



//// Gatekeeper Services
//builder.Services.AddDbContextFactory<AppDbContext>(options =>
//{
//    options.UseSqlServer(conStr);
//    options.EnableSensitiveDataLogging();

//}
//);


builder.Services.AddDbContextFactory<LookupDbContext>(options =>
    options.UseSqlServer(conStr));


////SqlConnectionStringBuilder Sqlbuilder = new SqlConnectionStringBuilder();
////Sqlbuilder.ConnectionString = builder.Configuration.GetConnectionString("gkConnectionString");

//builder.Services.AddDbContextFactory<LookupDbContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("gkConnectionString")));

builder.Services.AddBlazorBootstrap();

builder.Services.AddScoped<IAnalystnoteService, AnalystnoteService>();
builder.Services.AddScoped<IDiscloseditemsService, DiscloseditemsService>();
builder.Services.AddScoped<IExtensionsService, ExtensionsService>();
builder.Services.AddScoped<IHolidayService, HolidayService>();
builder.Services.AddScoped<ILocationitemsService, LocationitemsService>();
builder.Services.AddScoped<IPaymentService, PaymentService>();
builder.Services.AddScoped<IPersonService, PersonService>();
builder.Services.AddScoped<IRequestfeeService, RequestfeeService>();
builder.Services.AddScoped<IRequestfileService, RequestfileService>();
builder.Services.AddScoped<ISummarydisclosureService, SummarydisclosureService>();
builder.Services.AddScoped<IVideonoteService, VideonoteService>();

//Lookup
builder.Services.AddScoped<ILookupService, LookupDataService>();

builder.Services.AddScoped<IAnalystsService, AnalystsService>();
builder.Services.AddScoped<IDisclosureViewService, DisclosureViewService>();
builder.Services.AddScoped<ILkExtensionsService, LkExtensionsService>();
builder.Services.AddScoped<ILkLocationService, LkLocationService>();
builder.Services.AddScoped<ILkPaymenttypeService, LkPaymenttypeService>();
builder.Services.AddScoped<ILkProcessingdeficiencyService, LkProcessingdeficiencyService>();
builder.Services.AddScoped<ILkRecordDeliveryMethodService, LkRecordDeliveryMethodService>();
builder.Services.AddScoped<ILkRequesttypeService, LkRequesttypeService>();
builder.Services.AddScoped<ILkRequestStateService, LkRequestStateService>();
builder.Services.AddScoped<ISearchRequestfeeService, SearchRequestfeeService>();
builder.Services.AddScoped<ILkSectionService, LkSectionService>();
builder.Services.AddScoped<ISearchExtensionService, SearchExtensionService>();

//Audit
builder.Services.AddScoped<IAuditlogService, AuditlogService>();


//View
builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<IContactService, ContactService>();
builder.Services.AddScoped<IPersonnameService, PersonnameService>();
builder.Services.AddScoped<ISearchAnalystnoteService, SearchAnalystnoteService>();
builder.Services.AddScoped<ISearchLkLocationService, SearchLkLocationService>();
builder.Services.AddScoped<ISearchLkPaymentTypeService, SearchLkPaymentTypeService>();
builder.Services.AddScoped<ISearchLkRecordDeliveryMethodService, SearchLkRecordDeliveryMethodService>();
builder.Services.AddScoped<ISearchLkRequestStateService, SearchLkRequestStateService>();
builder.Services.AddScoped<ISearchLkSectionService, SearchLkSectionService>();
builder.Services.AddScoped<ISearchmytaskService, SearchmytaskService>();
builder.Services.AddScoped<ISearchPaymentService, SearchPaymentService>();
builder.Services.AddScoped<ISearchrequestfileService, SearchrequestfileService>();
builder.Services.AddScoped<ISearchVideonoteService, SearchVideonoteService>();
builder.Services.AddScoped<IViewHolidayService, ViewHolidayService>();
builder.Services.AddScoped<IViewProcessingDeficiencyService, ViewProcessingDeficiencyService>();

builder.Services.AddScoped<AppState>();
builder.Services.AddScoped<LoginState>();


builder.Services.AddAuthentication(NegotiateDefaults.AuthenticationScheme)
    .AddNegotiate();

builder.Services.AddAuthorization(options =>
{
    options.FallbackPolicy = options.DefaultPolicy;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
