﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal=carDal;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice>0 && car.Description.Length>2)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Lütfen geçerli değerler giriniz. ");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllByBrandId(int id)
        {
            return _carDal.GetAll(p=>p.BrandId==id).ToList();
        }

        public List<Car> GetAllByColorId(int id)
        {
            return _carDal.GetAll(p=>p.ColorId==id).ToList();
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
    }
}
