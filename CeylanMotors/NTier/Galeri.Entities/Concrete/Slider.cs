using Galeri.Entities.Abstract;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.Entities.Concrete
{
    public class Slider : BaseEntity
    {

        public string? Sliderad {  get; set; }
        public string? SliderFileName { get; set; }
        public string? SliderAciklama { get; set; }
        public string? SliderBaslik { get; set; }
    }
}
