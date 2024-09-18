using Galeri.BLL.Managers.Concrete;
using Galeri.DAL.DataContext;
using Galeri.DAL.Repositories.Concrete;
using Galeri.DAL.Services.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<GaleriDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("GaleriConStr"));
}, ServiceLifetime.Scoped);

builder.Services.AddScoped<CategoryRepo>();
builder.Services.AddScoped<CategoryService>();
builder.Services.AddScoped<CategoryManager>();
builder.Services.AddScoped<SliderRepo>();
builder.Services.AddScoped<SliderService>();
builder.Services.AddScoped<SliderManager>();
builder.Services.AddScoped<YakindaRepo>();
builder.Services.AddScoped<YakindaService>();
builder.Services.AddScoped<YakindaManager>();
builder.Services.AddScoped<ImageRepo>();
builder.Services.AddScoped<ImageService>();
builder.Services.AddScoped<ImageManager>();

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
