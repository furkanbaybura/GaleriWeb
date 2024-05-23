using Galeri.DAL.Repositories.Abstract;
using Galeri.DAL.Repositories.Concrete;
using Galeri.DAL.Services.Abstract;
using Galeri.DTO;
using Galeri.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.DAL.Services.Concrete
{
    public class CategoryService : Service<Category, CategoryDto>
    {
        public CategoryService(CategoryRepo repo) : base(repo)
        {
        }
    }
}
