using Galeri.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.DTO
{
    public class ImageDto : BaseDto
    {
        public string ImageName { get; set; }
        public byte[] ImageFile { get; set; }
        public int CategoryId { get; set; }
        public CategoryDto Category { get; set; }
    }
}
