using Galeri.BLL.Managers.Concrete;
using Galeri.DAL.DataContext;
using Galeri.DAL.Repositories.Concrete;
using Galeri.DAL.Services.Concrete;
using Galeri.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<GaleriDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("GaleriConStr"));
}, ServiceLifetime.Scoped);

builder.Services.AddIdentityCore<AppUser>()
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<GaleriDbContext>();

builder.Services.AddScoped<CategoryRepo>();
builder.Services.AddScoped<CategoryService>();
builder.Services.AddScoped<CategoryManager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
