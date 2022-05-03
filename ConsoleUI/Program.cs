using Business.Concrete;
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
            CarManager carManager = new CarManager(new InMemoryCarDal());
            Car car1 = new Car { Id = 6, BrandId = 6, ColorId = 3, DailyPrice = 134000,Description = "Scoda SuperB",ModelYear = 2017};
            Car car2 = new Car { Id = 7, BrandId = 3, ColorId = 1, DailyPrice = 120000, Description = "Ford Ranger", ModelYear = 2016 };

            PrintAll(carManager);
            Console.WriteLine("----------------------------------");

            carManager.Add(car1);
            carManager.Add(car2);
            PrintAll(carManager);

            Console.WriteLine("----------------------------------");
            carManager.Delete(car2);
            PrintAll(carManager);

            Console.WriteLine("----------------------------------");
            carManager.Update(new Car { Id = 1, BrandId = 6, ColorId = 4, DailyPrice = 105000,Description = "Scoda Octavia", ModelYear = 2020});
            PrintAll(carManager);

            Console.WriteLine("----------------------------------");
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description + ": " + car.DailyPrice );
            }

            Console.WriteLine("----------------------------------");

            foreach (var car in carManager.GetByBrandId(6))
            {
                Console.WriteLine(car.Description);
            }




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
