using Entities.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car {Id = 1, BrandId= 1 , ColorId= 1, DailyPrice=100,Description="Klimasız", ModelYear=1995},
                new Car {Id = 2, BrandId= 1 , ColorId= 1, DailyPrice=150,Description="Klimasız", ModelYear=2000},
                new Car {Id = 3, BrandId= 2 , ColorId= 2, DailyPrice=200,Description="Klimalı", ModelYear=2005},
                new Car {Id = 4, BrandId= 3 , ColorId= 3, DailyPrice=300,Description="Klimalı", ModelYear=2010},
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _car.SingleOrDefault(p=>p.Id == car.Id);
            _car.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetByID(int id)
        {
           return _car.Where(p=>p.Id == id).ToList();
        }

        public List<CarDetailDto> GetCarDetail()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(p => p.Id == car.Id);

            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
