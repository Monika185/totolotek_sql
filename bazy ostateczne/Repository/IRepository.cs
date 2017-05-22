
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace bazy_ostateczne.Repository
{
    public interface IRepository<T> where T : class, IIdentity
    {
        int Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T FindById(int id, params Expression<Func<T, object>>[] includeItems);
        List<T> Find(Func<T, bool> filter, params Expression<Func<T, object>>[] includeItems);
        bool Any(Func<T, bool> filter, params Expression<Func<T, object>>[] includeItems);
        List<T> FindAll(params Expression<Func<T, object>>[] includeItems);
        //PagedData<T> FindAll(Func<T, bool> filter, Func<T, object> order, bool? desc, int page, int perPage, params Expression<Func<T, object>>[] includeItems);
    }
}
