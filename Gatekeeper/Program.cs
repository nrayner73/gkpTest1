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

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();


// Add session 
builder.Services.AddBlazoredSessionStorage();

// Gatekeeper Services
builder.Services.AddDbContextFactory<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("gkConnectionString")));

builder.Services.AddDbContextFactory<LookupDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("gkConnectionString")));

builder.Services.AddBlazorBootstrap();

builder.Services.AddScoped<IRequestfileService, RequestfileService>();
builder.Services.AddScoped<IPersonService, PersonService>();
builder.Services.AddScoped <IAnalystnoteService, AnalystnoteService>();

//Lookup
builder.Services.AddScoped<ILkRequesttypeService, LkRequesttypeService>();
builder.Services.AddScoped<ILkRequestStateService, LkRequestStateService>();
builder.Services.AddScoped<ILkProcessingdeficiencyService, LkProcessingdeficiencyService>();
builder.Services.AddScoped<ILkRecorddeliverymethodService, LkRecorddeliverymethodService>();
builder.Services.AddScoped<IAnalystsService, AnalystsService>();
builder.Services.AddScoped<ISearchrequestfileService, SearchrequestfileService>();
builder.Services.AddScoped<ISearchmytaskService, SearchmytaskService>();
builder.Services.AddScoped<ISearchAnalystnoteService, SearchAnalystnoteService>();

//Audit
builder.Services.AddScoped<IAuditlogService, AuditlogService>();


//View
builder.Services.AddScoped<IPersonnameService,PersonnameService>();
builder.Services.AddScoped<IAddressService, AddressService>();
builder.Services.AddScoped<IContactService, ContactService>();

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
