using Microsoft.EntityFrameworkCore;
using WebApp.Services;
using WebApp.Data; 

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Registrar tu DbContext con LocalDB
builder.Services.AddDbContext<AppDbContext>(
    options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("Connection"))
    );

builder.Services.AddTransient<IProyectoresService, ProyectoresService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();