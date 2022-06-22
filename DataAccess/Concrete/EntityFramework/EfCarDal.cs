using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car Entity)
        {
            using (RecapProjectContext context = new RecapProjectContext())
            {
                var addedEntity = context.Entry(Entity);
                addedEntity.State =EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Car Entity)
        {
            using (RecapProjectContext context = new RecapProjectContext())
            {
                var removedEntity = context.Entry(Entity);
                removedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (RecapProjectContext context = new RecapProjectContext())
            {
                return filter==null?context.Set<Car>().ToList():
                    context.Set<Car>().Where(filter).ToList();
            }
        }

        public Car GetT(Expression<Func<Car, bool>> filter)
        {
            using (RecapProjectContext context = new RecapProjectContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public void Update(Car Entity)
        {
            using (RecapProjectContext context = new RecapProjectContext())
            {
                var updateEntity=context.Entry(Entity);
                updateEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
