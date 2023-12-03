using Core.DataAccess.EntityFramework;
using Entities.Abstract;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalSystemContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetail()
        {
            using (CarRentalSystemContext context = new CarRentalSystemContext())
            {
                var result = from car in context.Car
                             join c in context.Color
                             on car.ColorId equals c.ColorId
                             join b in context.Brand
                             on car.BrandId equals b.BrandId
                             select new CarDetailDto
                             {
                                 Id = car.Id,
                                 ColorName = c.Name,
                                 Name = b.Name,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                                 ModelYear = car.ModelYear
                             };
                return result.ToList();
            }
        }
    }
}
