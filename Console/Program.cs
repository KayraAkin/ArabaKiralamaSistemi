
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;


CarManager carManager = new CarManager(new EfCarDal());



foreach (var car in carManager.GetCarDetail().Data)
{
    Console.WriteLine(car.Name + "/" + car.ColorName);
}
