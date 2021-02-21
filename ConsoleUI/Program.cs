using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());
           foreach(var car in carManager.GetAllCars())
            {
                Console.WriteLine("CarName: " + car.CarName + " CarId: " + car.Id + " Description: " + car.Description);
            }

           foreach(var car in carManager.GetCarsByDailyPrice(100, 150))
            {
                Console.WriteLine("Car name: " + car.CarName + " Model: " + car.ModelYear);
            }
        }
    }
}
