using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1,ColorId=11,DailyPrice=1500,ModelYear=2011},
                new Car{Id = 2, BrandId = 3,ColorId=22,DailyPrice=1900,ModelYear=2012},
                new Car{Id = 3, BrandId = 3,ColorId=33,DailyPrice=1200,ModelYear=2013}

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete;
            carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate;
            carToUpdate = _cars.SingleOrDefault(c=>c.Id==car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
        }

        List<Car> ICarDal.GetById(int id)
        {
            return _cars.Where(c=>c.BrandId==id).ToList();
        }
    }
}
