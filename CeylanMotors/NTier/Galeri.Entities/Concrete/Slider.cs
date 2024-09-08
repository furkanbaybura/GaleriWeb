using Galeri.Entities.Abstract;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.Entities.Concrete
{
    public class Slider : BaseEntity
    {

        public string? Sliderad {  get; set; }        
        public string? SliderAciklama { get; set; }
        public string? SliderBaslik { get; set; }
        public string? SliderImageName { get; set; }
        
    }
}
