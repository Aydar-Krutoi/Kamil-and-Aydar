using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 zadanie
           Book book = new Book("1984", "Джордж Оруэлл", 328);
            book.PrintInfo();

            //2 zadanie
            Student student = new Student("Алиса", 20, "ИС-202");
            Student student1 = new Student("Борис", 19);
            student.ShowInfo();
            student1.ShowInfo();

            //3 zadanie
            Car myCar = new Car("Toyota", 5000);
            myCar.Drive(200);
            myCar.ShowMileage();

            //4 zadanie
            Rectangle rectangle = new Rectangle(5, 10);
            rectangle.PrintInfo();

            //5 zadanie
            BankAccount bankAccount = new BankAccount(1000);
            bankAccount.ShowBalance2();
            bankAccount.Deposit(500);
            bankAccount.Withdraw(2000);
            bankAccount.ShowBalance();
            Console.ReadKey();
        }

        //1 zadanie
        class Book
        {
            static string Title;
            static string Author;
            static int Pages;

            public Book(string title, string author, int pages)
            {
                Title = title;
                Author = author;
                Pages = pages;
            }
            public void PrintInfo()
            {
                Console.WriteLine($"Книга: {Title}, Автор: {Author}, Страниц: {Pages}");
            }
        }

        //2 zadanie
        class Student
        {
            string Name;
            int Age;
            string Group = "Неизвестная группа";
            public Student(string name, int age, string group)
            {
                Name = name;
                Age = age;
                Group = group;

            }

            public Student(string name, int age)
            {
                Name = name;
                Age = age;
            }
            

            public void ShowInfo()
            {
                Console.WriteLine($"Студент: {Name}, Возраст: {Age}, Группа: {Group}");
            }
        }

        //3 zadanie
        class Car
        {
            string Brand;
            int Mileage;
            
            public Car(string brand, int mileage)
            {
                Brand = brand;
                Mileage = mileage;
            }

            public void Drive(int distance)
            {
                Mileage += distance;
            }

            public void ShowMileage()
            {
                Console.WriteLine($"Марка: {Brand}, пробег: {Mileage}");
            }
        }
        
        //4 zadanie
        class Rectangle
        {
            int Width;
            int Height;
            

            public Rectangle(int width, int height)
            {
                Width = width;
                Height = height;

            }

            public int GetArea()
            {
                return Width * Height;
                
            }

            public void PrintInfo()
            {
                Console.WriteLine($"Ширина: {Width}, высота: {Height}, площадь: {GetArea()}");
            }
        }
        
        //5 zadanie
        class BankAccount
        {
            int Balance = 0;


            public BankAccount(int balance)
            {
                Balance = balance;
               
            }
            
            public void Deposit(int amount)
            {
                Balance += amount;
                Console.WriteLine($"Добавили на баланс: {amount}");
            }

            public void Withdraw(int amount)
            {
               if (Balance > amount)
                {
                    Balance -= amount;
                    Console.WriteLine($"Сняли с баланса: {amount}");
                }
                else
                {
                    Console.WriteLine($"Невозможно снять {amount}, на балансе не хватает средств");
                }
            }
            
            public void ShowBalance()
            {
                Console.WriteLine($"Итоговый баланс: {Balance}"); 
            }

            public void ShowBalance2()
            {
                Console.WriteLine($"Текущий баланс: {Balance}");
            }
        }
    }


   
    
}
