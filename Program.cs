// See https://aka.ms/new-console-template for more information

using Intro.Entities;
using Intro.Business;
using Intro;

Console.WriteLine("Hello, World!");

// string message1 = "Krediler";
// int term = 12;
// double amount = 100000;

//variables --> camelCase
bool isAuthenticated = false;

//condition
if (isAuthenticated == true) //(isAuthenticated)
    Console.WriteLine("hosgeldin");
else
    Console.WriteLine("Sisteme giris yap.");


string[] loans = {"kredi1", "kredi2", "kredi3", "kredi4", "kredi5"}; //dbden gelecek

//döngüler bir işlemi istediğimiz kadar belli bi şarda göre tekrarlamamızı sağlar.


//OOP temeli


// Course course1 = new Course();
// course1.Id = 1;

// Course course2 = new Course();
// course2.Id = 2;

// Course course3 = new Course();
// course3.Id = 3;

//dongu olusturmak icin array:
// Course[] courses = {course1, course2, course3};//bunlar database'den dinamik gelecekler.

// for (int i = 0; i < courses.Length; i++)
// {
//     Console.WriteLine("Kurs ID'si: " + courses[i].Id );
// }

CourseManager courseManager = new(new CourseDal());
//courseManager.GetAll();

List<courseManager> kurslar= courseManager.GetAll();

for (int i = 0; i < kurslar.Count; i++)
{
    Console.WriteLine("Kurs ID'si: " + kurslar[i].Id );
}


Console.WriteLine("kod bitti");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678910";
customer1.FirstName = "Elif";
customer1.LastName = "Ozun";
customer1.CustomerNumber = "123456";


IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 2;
customer2.NationalIdentity = "12305678910";
customer2.FirstName = "Merve";
customer2.LastName = "Celik";
customer2.CustomerNumber = "123456";


CoorporateCustomer customer3 = new CoorporateCustomer();
customer3.Id = 3;
customer3.Name = "kodlamaio";
customer3.CustomerNumber = "123456";
customer3.TaxNumber = "1928450173";

CoorporateCustomer customer4 = new CoorporateCustomer();
customer4.Id = 3;
customer4.Name = "abc";
customer4.CustomerNumber = "123459";
customer4.TaxNumber = "1928450175";

BaseCustomer[] customers = {customer1, customer2, customer3, customer4};

foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}


