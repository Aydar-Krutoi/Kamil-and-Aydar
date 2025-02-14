using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Dly_seby
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string word = "Hello";
            //word += "!!!!";

            //Console.WriteLine(word.Length);

            //Добавление элемента
            //word = String.Concat(word, "??");

            //Приравнивание
            //Console.WriteLine(String.Compare(word, "Hello!!!!!!"));

            //Разделяем на новые строки с помощью split
            //string people = "Alex,Bob,john";
            //string[] names = people.Split(',');
            //foreach (string el in names)
            //{
            //    Console.WriteLine(el);
            //}

            ////Разеделение через пробел
            //string people = "Alex,Bob,john";
            //string[] names = people.Split(',');
            //people = String.Join(" ", names);
            //Console.WriteLine(people);

            //Удаляет пробелы до и после строки
            //Console.WriteLine(word.Trim());

            //Обрезает строку с начало или с конца
            //Console.WriteLine(word.Substring(0, word.Length - 2));


            //Try catch
            //try
            //{
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(num);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Вы ввели не тот формат!");
            //}

            //try
            //{
            //    int a, b , res;
            //    Console.Write("Введите первое число:");
            //    a = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Введите второе число:");
            //    b = Convert.ToInt32(Console.ReadLine());
            //    res = a / b;
            //    Console.WriteLine("Результат: " + res);
            //} catch (DivideByZeroException) {
            //    Console.WriteLine("Деление на ноль");
            //}catch (FormatException)
            //{
            //    Console.WriteLine("Вы ввели не тот формат!");
            //} finally 
            //{
            //    Console.WriteLine();   
            //}

            //Console.ReadKey();

            //if-else(условное конструкция) -----------------------------------------------------------

            //int a = 5;
            //bool isHasCar = true;

            //if (a > 7)
            //{
            //    Console.WriteLine("Number is 7");

            //} else if (a < 5)
            //    Console.WriteLine("Number is < 5 ");
            //else if(a == 5 || !isHasCar)
            //    Console.WriteLine("Number is 5");
            ////if(isHasCar)
            //    //Console.WriteLine("User has car");
            //else 
            //    Console.WriteLine("Number is not 5 ");

            //Console.Write("enter name: ");
            //string role = Console.ReadLine();

            //if(role == "Admin")
            //{
            //    Console.Write("Enter user name");
            //    string user_name = Console.ReadLine();
            //    Console.Write("Enter {0} age", user_name);
            //    int age = Convert.ToInt32(Console.ReadLine());

            //    if(age <= 0 || age > 99)
            //    {
            //        Console.Write("Enter {0} age", user_name);
            //        age = Convert.ToInt32(Console.ReadLine());
            //    }

            //    if (age <= 0 || age > 99)
            //    {
            //        Console.WriteLine("error");
            //        age = 0;
            //    }
            //    else
            //        Console.WriteLine("user s age is " + age);
            //}else
            //    Console.WriteLine("Your not admin");

            //Console.Write("Напишите целое число: ");
            //int number = Convert.ToInt32(Console.ReadLine());  

            //if(number % 2 == 0)
            //{
            //    Console.WriteLine("Число четное");
            //}
            //else if(number % 2 == 1)
            //{
            //    Console.WriteLine("Число не четное");
            //}

            //TRY CATCH AND IF ELSE
            //try
            //{
            //    Console.Write("Напишите ваш возраст: ");
            //    int age = Convert.ToInt32(Console.ReadLine());


            //    if (age < 18)
            //    {
            //        Console.WriteLine("Вы еще подросток");
            //    }
            //    else if (age <= 65)
            //    {
            //        Console.WriteLine("Вы взрослый человек");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Вы пенсионер");
            //    }
            //}catch (Exception ex)
            //{
            //    Console.WriteLine("вы вели не число");
            //}


            //   IF ELSE
            //Console.Write("Ведите свой возраст: ");
            //int ages = Convert.ToInt32(Console.ReadLine());
            //if (ages == 0)
            //{
            //    Console.WriteLine("Вы ввели некоретный возраст");
            //}
            //if (ages <= 12)
            //{
            //    Console.WriteLine("Вы ребенок");
            //}
            //else if (ages >= 12 && ages <= 19) запомни условие в скобке !!!------------------
            //{
            //    Console.WriteLine("Вы подросток");
            //}


            //МЕТОД Remove
            //string original = "Hello, World!";
            //string modified = original.Remove(5, 7); // "Hello!"
            //Console.WriteLine(modified);

        }
    }
}
