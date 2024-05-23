using Galeri.BLL.Managers.Abstract;
using Galeri.DAL.Services.Abstract;
using Galeri.DAL.Services.Concrete;
using Galeri.DTO;
using Galeri.Entities.Concrete;
using Galeri.ViewModel.Category;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.BLL.Managers.Concrete
{
    public class CategoryManager : Manager<CategoryDto, CategoryViewModel, Category>
    {
        public CategoryManager(CategoryService service) : base(service)
        {
            
        }
       
    }
}
