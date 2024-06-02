using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.ViewModel.Category
{
    public class CategoryViewModel : BaseViewModel
    {
        public int? Id { get; set; }
        public int? RowNum { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Yil { get; set; }
        public int? AppUserId { get; set; }
    
    }
    

    
   

}
