using Galeri.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.Entities.Concrete
{
    public class Yakinda : BaseEntity
    {


        public string? YakindaAd { get; set; }       
        public string? YakindaAciklama { get; set; }
        public string? YakindaBaslik { get; set; }
        public string? YakindaImageName { get; set; }
    }
}
