using System.Collections.Generic;

namespace Credible.WebApp.Repositories
{
    public interface IRepository<T>
    {
        ICollection<T> SelectAll();
        T SelectById(int id);
        void Insert(T obj);
        void Delete(T obj);
        void Update(T obj);
        void Save();


    }
}
