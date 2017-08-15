using Arch.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arch.Repository
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        void Persist(T entity);
        void Delete(T entity);
        IEnumerable<T> GetAll();
        T Get(int id);
        void Save();
    }
}
