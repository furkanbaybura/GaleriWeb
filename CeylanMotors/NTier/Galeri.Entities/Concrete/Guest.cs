using Galeri.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.Entities.Concrete
{
    public class Guest 
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }
        [DataType(DataType.EmailAddress)]     
        public string? Description { get; set; }

        public string? Message { get; set; }

    }
}
