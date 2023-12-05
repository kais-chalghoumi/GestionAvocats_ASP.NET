using GA.Infrastructure;
using GA.ApplicationCore.Interfaces;
using GA.ApplicationCore.Services;
using Microsoft.EntityFrameworkCore;
using Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IAvocatService, AvocatService>();
builder.Services.AddScoped<IClientService, ClientService>();
builder.Services.AddScoped<IDossierService, DossierService>();
builder.Services.AddScoped<IUnitOfWork,UnitOfWork>();
builder.Services.AddDbContext<DbContext,Context>();
builder.Services.AddSingleton<Type>(t=>typeof(GenericRepository<>));

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
