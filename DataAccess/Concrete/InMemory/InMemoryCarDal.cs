using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId = 1, ModelYear = new DateTime(2012), DailyPrice = 110, Description = "Ford"},
                new Car{Id = 2, BrandId = 2, ColorId = 3, ModelYear = new DateTime(2019), DailyPrice = 250, Description = "RangeRover"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id && c.BrandId == car.BrandId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id && c.BrandId == car.BrandId);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
        }

        public List<Car> GetById(int CarId)
        {
            return _cars.Where(c => c.Id == CarId).ToList();
        }
    }
}
