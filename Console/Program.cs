
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

//CarManager carManager = new CarManager(new EfCarDal());

//Car car = new Car() { BrandId = 1, ColorId = 1, DailyPrice = 100000, Description = "Klimasız", ModelYear = 1990 };
//Car car1 = new Car() { BrandId = 2, ColorId = 2, DailyPrice = 200000, Description = "Klimasız", ModelYear = 2000 };
//Car car2 = new Car() { BrandId = 2, ColorId = 3, DailyPrice = 300000, Description = "Klimalı", ModelYear = 2010 };
//Car car3 = new Car() { BrandId = 3, ColorId = 3, DailyPrice = 350000, Description = "Klimalı", ModelYear = 2020 };

//carManager.Add(car);
//carManager.Add(car1);
//carManager.Add(car2);
//carManager.Add(car3);



//User user = new User() { FirstName = "Kayra", LastName = "Akın", Email = "kayrakin11@hotmail.com",Password = "1234" };
//User user2 = new User() { FirstName = "Fatma", LastName = "Ikış", Email = "fatmaikis@gmail.com",Password = "4321" };

//UserManager userManager = new UserManager(new EfUserDal());



//Console.WriteLine(userManager.Add(user));


//Console.WriteLine(userManager.Add(user2));


//Customer customer = new Customer() { UserId = 1, CompanyName = "AKN" };
//Customer customer2 = new Customer() { UserId = 2, CompanyName = "IKS" };

//CustomerManager customerManager = new CustomerManager(new EfCustomerDal());


//Console.WriteLine(customerManager.Add(customer).Message);
//Console.WriteLine(customerManager.Add(customer2).Message);


Rental rental = new Rental() { CarId = 1 , CustomerId = 1 , RentDate = new DateTime(2023, 05, 17)};


RentalManager rentalManager = new RentalManager(new EfRentalDal());


//Console.WriteLine(rentalManager.Add(rental).Message);


foreach (var item in rentalManager.GetAll().Data)
{
    Console.WriteLine(item.RentDate);
}


//foreach (var item in customerManager.GetAll().Data)
//{
//    Console.WriteLine(item.CompanyName);
//}

