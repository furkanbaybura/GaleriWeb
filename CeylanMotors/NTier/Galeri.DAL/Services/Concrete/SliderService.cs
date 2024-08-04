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
    public class SliderService : Service<Slider, SliderDto>
    {
        public SliderService(SliderRepo repo) : base(repo)
        {
        }
    }
}
