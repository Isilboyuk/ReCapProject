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
            //BrandTest();


             CarTest();
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAllCars())
            {
                Console.WriteLine("CarName: " + car.CarName + " CarId: " + car.Id + " Description: " + car.Description);
            }

            foreach (var car in carManager.GetCarDetails())
            {
                Console.WriteLine("Car name: " + car.CarName + " Model: " + car.BrandId);
            }
        }
    }
}
