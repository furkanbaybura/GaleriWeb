using Galeri.Common;
using Galeri.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.Entities.Concrete
{
    public class Category : BaseEntity
    {
        //public int CategoryId { get; set; }
        public string? Marka { get; set; }
        public string? Modeli { get; set; }
        public string? Paket { get; set; }
        public Kategori? Kategori { get; set; }
        public double? MotorHacmi { get; set; }
        public Vites? Vites { get; set; }
        public int? Tork { get; set; }
        public int? Beygir { get; set; }
        public string? Renk { get; set; }
        public string? Km { get; set; }
        public string? Description { get; set; }
        public int? Yil { get; set; }
        public int? Fiyat { get; set; }

    }
}
