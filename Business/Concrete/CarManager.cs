using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
       public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if(car.CarName.Length >=2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            else { 
                Console.Write("Length of car name has to more than two chars and the daily price has to more than 0.");
            } 
        }

        public List<Car> GetAllCars()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int id)
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByColorId(int id)
        {
            return _carDal.GetAll(c => c.Id == id);
        }

        public List<Car> GetCarsByDailyPrice(decimal minPrice, decimal maxPrice)
        {
            return _carDal.GetAll(c => c.DailyPrice >= minPrice && c.DailyPrice <= maxPrice);
        }
    }
}
