using Galeri.BLL.Managers.Abstract;
using Galeri.DAL.Services.Concrete;
using Galeri.DTO;
using Galeri.Entities.Concrete;
using Galeri.ViewModel.Picture;
using Galeri.ViewModel.Slider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.BLL.Managers.Concrete
{
    public class ImageManager : Manager<ImageDto, ImageViewModel, CategoryImage>
    {
        public ImageManager(ImageService service) : base(service)
        {

        }

        public IEnumerable<object> GetImagesByCategoryId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
