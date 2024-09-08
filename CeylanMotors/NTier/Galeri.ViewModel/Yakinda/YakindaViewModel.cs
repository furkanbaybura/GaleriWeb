using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.ViewModel.Yakinda
{
    public class YakindaViewModel : BaseViewModel
    {
        public int? Id { get; set; }
        public int? RowNum { get; set; }
        public int? AppUserId { get; set; }
        public string? YakindaAd { get; set; }        
        public string? YakindaAciklama { get; set; }
        public string? YakindaBaslik { get; set; }
        public string? YakindaImageName { get; set; }
        [NotMapped]
        public IFormFile? YakindaImageUpload { get; set; }
    }
}
