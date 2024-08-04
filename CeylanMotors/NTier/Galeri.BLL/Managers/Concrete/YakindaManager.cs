using Galeri.BLL.Managers.Abstract;
using Galeri.DAL.Services.Abstract;
using Galeri.DAL.Services.Concrete;
using Galeri.DTO;
using Galeri.Entities.Concrete;
using Galeri.ViewModel.Yakinda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.BLL.Managers.Concrete
{
    public class YakindaManager : Manager<YakindaDto, YakindaViewModel, Yakinda>
    {
        public YakindaManager(YakindaService service) : base(service)
        {
        }
    }
}
