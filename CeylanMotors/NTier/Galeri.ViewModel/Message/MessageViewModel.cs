using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.ViewModel.Message
{
    public class MessageViewModel : BaseViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Description { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }

    }
}
