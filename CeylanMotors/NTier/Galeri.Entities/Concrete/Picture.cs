using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.Entities.Concrete
{
    public class Picture
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // Fotoğrafın kendisi byte[] formatında tutulur
        public byte[] PictureData { get; set; }

        // Fotoğrafın adı veya uzantısı
        public string PictureName { get; set; }
    }
}
