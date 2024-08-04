using Galeri.BLL.Managers.Abstract;
using Galeri.DAL.Services.Concrete;
using Galeri.DTO;
using Galeri.Entities.Concrete;
using Galeri.ViewModel.Category;
using Galeri.ViewModel.Slider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.BLL.Managers.Concrete
{
    public class SliderManager : Manager<SliderDto, SliderViewModel, Slider>
    {
        public SliderManager(SliderService service) : base(service)
        {

        }
    }
}
