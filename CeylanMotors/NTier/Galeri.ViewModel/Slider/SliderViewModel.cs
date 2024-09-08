using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.ViewModel.Slider
{
    public class SliderViewModel : BaseViewModel
    {
        public int? Id { get; set; }
        public int? RowNum { get; set; }
        public int? AppUserId { get; set; }
        public string? Sliderad { get; set; }
        public string? SliderAciklama { get; set; }
        public string? SliderBaslik { get; set; }
        public string? SliderImageName { get; set; }
        [NotMapped]
        public IFormFile? SliderImageUpload { get; set; }
    }
}
