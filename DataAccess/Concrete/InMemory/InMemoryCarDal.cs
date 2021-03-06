using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
                new Car { Id = 1, BrandId = 1 , ColorId = 1 , DailyPrice = 200000, Description = "BMW 320", ModelYear = 2018 },
                new Car { Id = 2, BrandId = 1 , ColorId = 2 , DailyPrice = 300000, Description = "BMW 520", ModelYear = 2021 },
                new Car { Id = 3, BrandId = 2 , ColorId = 2 , DailyPrice = 150000, Description = "Ford Focus", ModelYear = 2018 },
                new Car { Id = 4, BrandId = 3 , ColorId = 1 , DailyPrice = 250000, Description = "Wolkswagen Passat", ModelYear = 2017 },
                new Car { Id = 5, BrandId = 4 , ColorId = 3 , DailyPrice = 500000, Description = "Porche", ModelYear = 2019 },
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetCarsByColorId()
        {
            return _cars;
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _cars.Where(c=>c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=> c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }

        public int Size()
        {
            return _cars.Count;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
