using AutoMapper;
using Galeri.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.DAL.Services.Abstract
{
    public interface IService<TDto> where TDto : BaseDto
    {
        IMapper Mapper { set; }
        int Add(TDto dto, bool isEntityId = false);
        int Update(TDto dto);
        int Delete(TDto dto);
        int Delete(int id);
        IEnumerable<TDto> GetAll();
        TDto? Get(int id);
    }
}
