using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello World!");

string message1 = "Krediler";

int term = 12;

double amount = 10.000;

bool isAuthenicated = true;

if (isAuthenicated)
{
    Console.WriteLine("Button-->Hoşgeldin Engin");
}
else
{
    Console.WriteLine("Button-->Sisteme Giriş Yap");
}

string[] loans = {"Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4" };

for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

CourseManager courseManager = new CourseManager();
Course[] courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Length; i++)
{
    Console.WriteLine(courses2[i].Name + " / " + courses2[i].Price);

}

Console.WriteLine("Kod Bitti");