using Core.DataAccess.EntityFramework;
using Entities.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, CarRentalSystemContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (CarRentalSystemContext contex = new CarRentalSystemContext())
            {


                var result = from customers in contex.Customers
                             join users in contex.Users
                             on customers.UserId equals users.Id
                             join rentals in contex.Rentals
                             on customers.Id equals rentals.Id
                             join car in contex.Car
                             on rentals.CarId equals car.Id

                             

                             select new RentalDetailDto
                             {
                                 Id = rentals.Id,
                                 ModelYear = car.ModelYear,
                                 DailyPrice = car.DailyPrice,
                                 Description = car.Description,
                                 BrandName = car.BrandId,
                                 ColorName = car.ColorId,
                                 RentDate = rentals.RentDate,
                                 ReturnDate = rentals.ReturnDate,
                                 FirstName = users.FirstName,
                                 LastName = users.LastName,
                                                                 
                             };
                return result.ToList();

            }
        }
    }
}
