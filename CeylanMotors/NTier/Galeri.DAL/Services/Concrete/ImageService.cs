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
    public class ImageService : Service<CategoryImage, ImageDto>
    {
        public ImageService(ImageRepo repo) : base(repo)
        {
        }
    }
}
