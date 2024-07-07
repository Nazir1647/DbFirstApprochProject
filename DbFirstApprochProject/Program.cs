using DbFirstApprochProject.Abstractions.Implementation;
using DbFirstApprochProject.Abstractions.Interfaces;
using DbFirstApprochProject.Data.Models;
using DbFirstApprochProject.Services.IRepositories;
using DbFirstApprochProject.Services.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<CodingNoteContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("dbcs"));
}, ServiceLifetime.Scoped);
ConfigureServices(builder.Services);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

static void ConfigureServices(IServiceCollection services)
{
    // Register AutoMapper
    services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
    services.AddTransient<IHeaderMenuRepo, HeaderMenuRepo>();
    services.AddTransient<IUnitOfWork, UnitOfWork>();
    services.AddMemoryCache();
}