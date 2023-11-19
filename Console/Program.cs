
using Business.Concrete;
using DataAccess.Concrete.InMemory;


CarManager carManager = new CarManager(new InMemoryProdactDal());

foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.DailyPrice);
}
