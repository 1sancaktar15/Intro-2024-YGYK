﻿// See https://aka.ms/new-console-template for more information

using Intro.Entities;
using Intro.Business;

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

CourseManager courseManager = new();
//courseManager.GetAll();

Course[] kurslar= courseManager.GetAll();

for (int i = 0; i < kurslar.Length; i++)
{
    Console.WriteLine("Kurs ID'si: " + kurslar[i].Id );
}

Console.WriteLine("kod bitti");
