using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.Entities.Concrete
{
    public class Image
    {
        public int ImageId { get; set; }
        public string ImageName { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
