using Galeri.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.DTO
{
    public class PictureDto
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }      
        public byte[] PictureData { get; set; }
        public string PictureName { get; set; }
    }
}
