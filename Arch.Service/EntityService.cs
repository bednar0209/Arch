using Arch.Model;
using Arch.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch.Service
{
    public abstract class EntityService<T> : IEntityService<T> where T : BaseEntity
    {
        IUnitOfWork _unitOfWork;
        IGenericRepository<T> _repository;

        public EntityService(IUnitOfWork unitOfWork, IGenericRepository<T> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        /// <summary>
        /// (Service)Delete
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _repository.Delete(entity);
            _unitOfWork.Commit();
        }

        /// <summary>
        /// (Service)GetAll
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        /// <summary>
        /// (Service)Persist
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Persist(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _repository.Persist(entity);
            _unitOfWork.Commit();

        }
    }
}
