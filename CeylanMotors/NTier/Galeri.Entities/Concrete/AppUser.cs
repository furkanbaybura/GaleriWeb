using Galeri.Common;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.Entities.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly Birthdate { get; set; }
        public Gender Gender {  get; set; }
    }
}
