using Arch.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch.Service
{
    public interface IEntityService<T> : IService where T : BaseEntity
    {
        void Delete(T entity);
        IEnumerable<T> GetAll();
        void Persist(T entity);
    }
}
