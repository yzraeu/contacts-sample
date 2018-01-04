using System.Collections.Generic;
using ContactsSample.API.Models;

namespace ContactsSample.API.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        void Add(T entity);
        void Update(T entity);
        void Remove(int id);
        T Get(int id);
        IEnumerable<T> GetAll();
    }
}