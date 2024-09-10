using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.ViewModel.Guest
{
    public class GuestViewModel
    {
       
        public int Id { get; set; }
        [Required(ErrorMessage = "Zorunlu Alan")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Adınız minimum 3 maksimum 20 karakterli olabilir!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Zorunlu Alan")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Soyadınız minimum 2 maksimum 20 karakterli olabilir!")]
        public string Surname { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Telefon numarası girilmesi zorunludur")]
        public string? Phone { get; set; }       
       
        [Required(ErrorMessage = "Açıklama girilmesi zorunludur")]
        public string Description { get; set; }
        public string Message { get; set; }
    }
}
