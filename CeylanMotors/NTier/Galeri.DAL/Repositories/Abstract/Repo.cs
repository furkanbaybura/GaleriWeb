using Galeri.DAL.DataContext;
using Galeri.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Galeri.DAL.Repositories.Abstract
{
    public abstract class Repo<TEntity> : IRepo<TEntity> where TEntity : BaseEntity
    {
        protected GaleriDbContext _dbcContext;
        protected Repo(GaleriDbContext dbContext)
        {
            _dbcContext = dbContext;

            _dbcContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTrackingWithIdentityResolution;
        }

        public int Add(TEntity entity)
        {
           entity.CreatedDate = DateTime.Now;
            _dbcContext.Add(entity);
            return _dbcContext.SaveChanges();
        }

        public int Delete(TEntity entity)
        {
           _dbcContext.Remove(entity);
            return _dbcContext.SaveChanges();
        }

        public virtual TEntity? Get(int id)
        {
            return _dbcContext.Set<TEntity>().AsNoTracking().SingleOrDefault(e=>e.Id==id);
            
        }

        public virtual IEnumerable<TEntity> GetAll()
        
        {
            return _dbcContext.Set<TEntity>().AsNoTracking().ToList();
        }

        public int Update(TEntity entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _dbcContext.Update(entity);
            return _dbcContext.SaveChanges();
        }
    }
}
