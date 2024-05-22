using Galeri.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.Entities.Abstract
{
    public abstract class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
