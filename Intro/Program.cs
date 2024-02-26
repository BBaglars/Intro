using Intro.Business;
using Intro.DataAccess.Concretes;
using Intro.Entities;

//Console.WriteLine("Hello World!");

//string message1 = "Krediler";

//int term = 12;

//double amount = 10.000;

//bool isAuthenicated = true;

//if (isAuthenicated)
//{
//    Console.WriteLine("Button-->Hoşgeldin Engin");
//}
//else
//{
//    Console.WriteLine("Button-->Sisteme Giriş Yap");
//}

//string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4" };

//for (int i = 0; i < loans.Length; i++)
//{
//    Console.WriteLine(loans[i]);
//}

//CourseManager courseManager = new(new EfCourseDal());
//List<Course> courses2 = courseManager.GetAll();
//for (int i = 0; i < courses2.Count; i++)
//{
//    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);

//}

//Console.WriteLine("Kod Bitti");

//IndividualCustomer customer1 = new IndividualCustomer();
//customer1.Id = 1;
//customer1.NationalIdentity = "12345678922";
//customer1.FirstName = "Aslı";
//customer1.LastName = "Karayiğit";
//customer1.CustomerNumber = "123456";

//IndividualCustomer customer2 = new IndividualCustomer();
//customer2.Id = 2;
//customer2.NationalIdentity = "2589678643";
//customer2.FirstName = "Özgür";
//customer2.LastName = "Atılgan";
//customer2.CustomerNumber = "123457";

//CorporateCustomer customer3 = new CorporateCustomer();
//customer3.Id = 3;
//customer3.Name = "Özgür";
//customer3.CustomerNumber = "654778";
//customer3.TaxNumber = "12345678987";

//CorporateCustomer customer4 = new CorporateCustomer();
//customer4.Id = 3;
//customer4.Name = "Abc";
//customer4.CustomerNumber = "654779";
//customer4.TaxNumber = "12345678985";

////value types —-»int, bool, double...
////reference types —-3 array, class, interface...
//                              //101       102         103        104              
//BaseCustomer[] customers = { customer1, customer2, customer3, customer4 };

////polymorphism
//foreach (BaseCustomer customer in customers)
//{
//    Console.WriteLine(customer.CustomerNumber);
//}


CourseManager courseManager = new(new EfCourseDal());
Course course = new Course();
course.Name = "C#";
course.Description = "dgrefs";
course.Price = 100;

Course course2 = new Course();
course2.Name = "C";
course2.Description = "dgrefs";
course2.Price = 100;

courseManager.Add(course);
courseManager.Add(course2);
var list = courseManager.GetAll();
foreach (var c in list)
{
    Console.WriteLine($"{c.Id} => {c.Name}");
}
