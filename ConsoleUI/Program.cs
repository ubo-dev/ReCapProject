using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car1 = new Car { Id = 6, BrandId = 6, ColorId = 3, DailyPrice = 134000,Description = "Scoda SuperB",ModelYear = 2017};
            Car car2 = new Car { Id = 7, BrandId = 3, ColorId = 1, DailyPrice = 120000, Description = "Ford Ranger", ModelYear = 2016 };

            carManager.Add(car1);
            carManager.Add(car2);
            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand() { Id = 1, Name = "Maserati"});

            //brandManager.GetAll();

            PrintAll(carManager);




        }

        static void PrintAll(CarManager carManager)
        {
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }

    }
}
