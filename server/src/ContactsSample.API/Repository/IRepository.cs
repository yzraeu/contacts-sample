using System.Collections.Generic;
using ContactsSample.API.Models;

namespace ContactsSample.API.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        int Add(T entity);
        void Update(int id, T entity);
        void Remove(int id);
        T Get(int id);
        bool Exists(int id);
        IEnumerable<T> GetAll();
    }
}