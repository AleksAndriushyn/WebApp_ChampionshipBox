using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IRepositories
{
    public interface IGenericRepository<T> where T : class
    {
        T GetEntity(int id);
        IList<T> EntityList();
        IList<T> List(Expression<Func<T, bool>> expression);
        void EntityInsert(T entity);
        void UpdateEntity(T entity);
        void DeleteEntity(T entity);
        void DeleteEntity(int id);
    }
}
