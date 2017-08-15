using Arch.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch.Repository
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        protected DbContext _context;
        protected readonly IDbSet<T> _dbset;

        public GenericRepository(DbContext context)
        {
            _context = context;
            _dbset = context.Set<T>();
        }

        public virtual void Persist(T entity)
        {
            if (entity.Id > 0)
            {
                _context.Entry(entity).State = EntityState.Modified;
            }
            else
            {
                _dbset.Add(entity);
            }
        }

        public virtual void Delete(T entity)
        {
            _dbset.Remove(entity);
        }

        public virtual T Get(int id)
        {
            return _dbset.Where(x => x.Id == id).FirstOrDefault();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return _dbset.AsEnumerable();
        }

        public virtual void Save()
        {
            _context.SaveChanges();
        }
    }
}
