using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KoalaShopLib
{
    public interface IRepository<T>
    {
        //T GetByID(object id);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
