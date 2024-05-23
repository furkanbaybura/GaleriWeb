using Galeri.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.DAL.Repositories.Abstract
{
    public interface IRepo<Tentity> where Tentity : BaseEntity
    {
        int Add(Tentity entity);
        int Update(Tentity entity);
        int Delete(Tentity entity);
        IEnumerable<Tentity> GetAll();
        //List<Tentity> GetAll();
        Tentity Get(int id);
    }
}
