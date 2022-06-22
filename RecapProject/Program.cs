using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace RecapProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carmanager = new CarManager(new EfCarDal());
            //carmanager.Add(new Car { BrandId=3,ColorId=4,DailyPrice=100,ModelYear=1981,Description="Honda"});
            foreach (var car in carmanager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
