using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Galeri.ViewModel.Picture;

namespace Galeri.ViewModel.Category
{
    public class CategoryViewModel : BaseViewModel
    {
        public int? Id { get; set; }
        public int? RowNum { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? Yil { get; set; }
        public int? AppUserId { get; set; }
        public string? Marka { get; set; }
        public string? Modeli { get; set; }
        public string? Paket { get; set; }
        public string? Kategori { get; set; }
        public double? MotorHacmi { get; set; }
        public bool? Vites { get; set; }
        public int? Tork { get; set; }
        public int? Beygir { get; set; }
        public string? Renk { get; set; }
        public string? Km { get; set; }
        public int? Fiyat { get; set; }
        [NotMapped]
        public IFormFile[] FormFile { get; set; }

        public List<ImageViewModel>? Images { get; set; }

    }
    

    
   

}
