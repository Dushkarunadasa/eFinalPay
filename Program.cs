using FinaPay.HRMSModels;
using FinaPay.Models;
using FinaPay.PayModels;
using FinaPay.Repositary;
using FinaPay.Services;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddHttpContextAccessor();//To get the  Client IP
builder.Services.TryAddSingleton<IActionContextAccessor, ActionContextAccessor>();//To get the  Client IP
builder.Services.Configure<ForwardedHeadersOptions>(options =>
{
    options.ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto;
});
builder.Services.AddDbContext<PaySubjectsContext>(Options=>Options.UseSqlServer (
    builder.Configuration.GetConnectionString("MyConnection")));

builder.Services.AddDbContext<Payroll_SLNavyContext>(Options => Options.UseSqlServer(
    builder.Configuration.GetConnectionString("PaySystem")));

builder.Services.AddDbContext<HRISLIVEContext>(Options => Options.UseSqlServer(
    builder.Configuration.GetConnectionString("HRConnection")));



builder.Services.AddScoped<ILoginServices,LoginServices>();
builder.Services.AddScoped<IHrmsDetails, HrmsDetails>();
builder.Services.AddScoped<IMainServices, MainServices>();
builder.Services.AddScoped<IRepositary, Repositary>(); //Rest API
builder.Services.AddScoped<IRecoveryServices, RecoveryServices>();
builder.Services.AddScoped<IPayDetails, PayDetails>();
builder.Services.AddScoped<ILoginDetails, LoginDetails>();



builder.Services.AddAuthentication("CookieAuth").AddCookie("CookieAuth", config =>
{
    config.Cookie.Name = "FinalPay.Cookie";
    config.LoginPath = "/Home/Authenticate";
    config.AccessDeniedPath= new PathString("/Home/AccessDenied");
});

builder.Services.AddAuthorization(options =>
{


    options.AddPolicy("RequiredRecSubjectClerk", policy => policy.RequireRole("RecSubClerk"));
    options.AddPolicy("RequiredRecSecretary", policy => policy.RequireRole("RecSec"));
    options.AddPolicy("RequiredRecAuthorize", policy => policy.RequireRole("RecAuthorized"));

    options.AddPolicy("RequiredSMSubjectClerk", policy => policy.RequireRole("SMSubClerk"));
    options.AddPolicy("RequiredSMSecretary", policy => policy.RequireRole("SMSec"));
    options.AddPolicy("RequiredSMAuthorize", policy => policy.RequireRole("SMAuthorized"));

    options.AddPolicy("RequiredPaySubjectClerk", policy => policy.RequireRole("PaySubClerk"));
    options.AddPolicy("RequiredPaySSailor", policy => policy.RequireRole("PaySSailor"));

    options.AddPolicy("RequiredAuditSailor", policy => policy.RequireRole("AuditSubClerk"));
    options.AddPolicy("RequiredAuditSSailor", policy => policy.RequireRole("AuditSSailor"));
    options.AddPolicy("RequiredAuditOfficer", policy => policy.RequireRole("AuditOfficer"));

    options.AddPolicy("RequiredSSOPay", policy => policy.RequireRole("SSOPay"));
    options.AddPolicy("RequiredDDNPay", policy => policy.RequireRole("DDNPay"));
    options.AddPolicy("RequiredPenSailor", policy => policy.RequireRole("PenSailor"));
    options.AddPolicy("RequiredPenSSailor", policy => policy.RequireRole("PenSSailor"));
    options.AddPolicy("RequiredPenSSO", policy => policy.RequireRole("PenSSO"));


});


builder.Services.AddRazorPages();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseForwardedHeaders();
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthentication();

app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Login}/{id?}");


app.Run();
