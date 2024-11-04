using Galeri.BLL.Managers.Concrete;
using Galeri.DAL.DataContext;
using Galeri.DAL.Repositories.Concrete;
using Galeri.DAL.Services.Concrete;
using Galeri.Entities.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(o =>
{
    o.Cookie.Name = "galeri";
    o.Cookie.MaxAge = TimeSpan.FromSeconds(1000);
    o.LoginPath = "/Account/Login";
    o.LogoutPath = "/Account/Logout";
    o.SlidingExpiration = true;
});
builder.Services.AddSession(o =>
{
    o.Cookie.Name = "galeri";
    o.IdleTimeout = TimeSpan.FromSeconds(297);
    o.Cookie.IsEssential = true;
});
builder.Services.AddDbContext<GaleriDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("GaleriConStrRemote"));
}, ServiceLifetime.Scoped);

builder.Services.AddIdentity<AppUser, IdentityRole<int>>()
    .AddEntityFrameworkStores<GaleriDbContext>()
    .AddDefaultTokenProviders();
//builder.Services.AddIdentityCore<AppUser>()
//                .AddDefaultTokenProviders()
//                .AddEntityFrameworkStores<GaleriDbContext>();

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
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
