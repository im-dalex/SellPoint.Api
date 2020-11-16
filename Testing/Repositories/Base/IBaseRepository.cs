using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Testing.Models.Base;

namespace Testing.Repositories.Base
{
    public interface IBaseRepository<T> where T : class, IBaseEntity, new()
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T model);
        void Update(T model);
        void Remove(T model);
        bool SaveChanges();
    }
}
