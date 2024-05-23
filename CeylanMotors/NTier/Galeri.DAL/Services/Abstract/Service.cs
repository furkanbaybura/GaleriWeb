using AutoMapper;
using AutoMapper.EquivalencyExpression;
using AutoMapper.Extensions.ExpressionMapping;
using Galeri.DAL.Repositories.Abstract;
using Galeri.DTO;
using Galeri.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.DAL.Services.Abstract
{
    public abstract class Service<TEntity, TDto> : IService<TDto>

        where TEntity : BaseEntity
        where TDto : BaseDto
    {
        protected IMapper _mapper;
        public Repo<TEntity> _repo;

        public Service(Repo<TEntity> repo)
        {

            MapperConfiguration _config = new MapperConfiguration(cfg =>
            {
                 cfg.AddExpressionMapping().AddCollectionMappers();
                cfg.CreateMap<TDto, TEntity>().ReverseMap();

             });
            _mapper = _config.CreateMapper();
        }
        
        public IMapper Mapper 
        {
            set{ _mapper = value; }
        }

        public int Add(TDto dto)
        {
            TEntity entity = _mapper.Map<TEntity>(dto);
            return _repo.Add(entity);
        }

        public int Delete(TDto dto)
        {
            TEntity entity = _mapper.Map<TEntity>(dto);
            return _repo.Delete(entity);
        }
        public int Delete(int id)
        {
            TEntity entity = _mapper.Map<TEntity>(id);
            return _repo.Delete(entity);
        }
        public IEnumerable<TDto> GetAll()
        {
            IEnumerable<TEntity> entities = _repo.GetAll();
            IEnumerable<TDto> dtos = _mapper.Map<IEnumerable<TDto>>(entities.ToList());
            return dtos;
        }

        public TDto? Get(int id)
        {
            TEntity? entity = _repo.Get(id);
            TDto? dto = _mapper.Map<TDto>(entity);
            return dto;
        }

        public int Update(TDto dto)
        {
           TEntity entity = _mapper.Map<TEntity>(dto);
            return _repo.Update(entity);
        }
    }
}
