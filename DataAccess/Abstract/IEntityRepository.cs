using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null);//filtre vermeyebilirisin -- tüm data
        T GetT(Expression<Func<T,bool>>filter);
        void Add(T Entity);
        void Update(T Entity);
        void Delete(T Entity);
    }
}
