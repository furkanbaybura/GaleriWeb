using Galeri.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.DAL.DataContext
{
    public class GaleriDbContext :IdentityDbContext<AppUser,IdentityRole<int>,int>
    {
        public GaleriDbContext(DbContextOptions<GaleriDbContext> options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }
    }
}
