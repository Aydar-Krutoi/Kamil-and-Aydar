using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.ConstrainedExecution;
using Xceed.Document.NET;
using Xceed.Words.NET;

namespace Kamil_and_Aydar
{
    internal class Program

    {
        static void Main(string[] args)
        {
            //string filePath = "C:\\Users\\Айдар\\OneDrive\\Рабочий стол\\SiSharp\\word.docx";

            ////Создаем ворд документ
            //using (var document = DocX.Create(filePath))
            //{
            //    //Добавляем заголовок
            //    document.InsertParagraph("пример - ворд документ")
            //    .FontSize(20)
            //    .Bold()
            //    .Alignment = Alignment.center;

            //    document.InsertParagraph();

            //    //Добавляем текст
            //    document.InsertParagraph("Файл создан в си шарпе ")
            //        .FontSize(20)
            //        .Italic()
            //        .Font("Arial")
            //        .Alignment = Alignment.right;

            //    document.Save();
            //    Console.WriteLine("Документ создан");
            //}

            // 5 PRAKTIKA
            //string filePath = "C:\\Users\\Айдар\\OneDrive\\Рабочий стол\\SiSharp\\list.docx";

            //using (var document = DocX.Create(filePath))
            //{
            //    var list = document.AddList("Aydar", 0, ListItemType.Numbered);

            //    document.AddListItem(list, "Aydar");
            //    document.AddListItem(list, "Kamil");
            //    document.InsertList(list);

            //    document.Save();
            //    Console.WriteLine("Document sozdan");
            //}


            //string filePath2 = "C:\\Users\\Айдар\\OneDrive\\Рабочий стол\\SiSharp\\table.docx";

            //using (var document = DocX.Create(filePath2))
            //{
            //    var table = document.AddTable(2, 2);

            //    table.Rows[0].Cells[0].Paragraphs[0].Append("Aydar1");
            //    table.Rows[0].Cells[1].Paragraphs[0].Append("Aydar2");
            //    table.Rows[1].Cells[0].Paragraphs[0].Append("Aydar3");
            //    table.Rows[1].Cells[1].Paragraphs[0].Append("Aydar4");

            //    document.InsertTable(table);

            //    document.Save();
            //}

            //string filePath = "C:\\Users\\Айдар\\OneDrive\\Рабочий стол\\SiSharp\\Для себя.docx";


        }
    }
}






























































































































































//int[] numb3 = new int[] { 1, 2, 5, 4, 5, 6 };
//foreach (int i in numb3)
//{

//    Console.WriteLine(y);
//}
//    for (int i = 0; i < numb3.Length; i = i++)
//{
//    numb3[i] = numb3[i] *10;
//    Console.WriteLine(numb3[i]);
//}

//int i = 0;
//while (i < numb3.Length)
//{
//    Console.WriteLine(numb3[i]);
//    i++;
//}
//int[,] numbs = new int[,] { { 1, 2, 3, }, { 4, 5, 6, } };

//int rows = numbs.GetUpperBound(0) + 1; //строки
//int columns = numbs.GetUpperBound(1) + 1; //numbs.Lenght /rows // столбцы

//for (int i = 0; i < rows; i++) 
//{ 
//for (int j = 0; j < columns; j++) 
//    {
//        Console.Write($"{numbs[i, j]} \t");
//    }
//Console.WriteLine();
//}

//Console.ReadKey();
//Console.WriteLine(numb3[3]);
//var n = numb3[2];
//var n1 = numb3[4];
//Console.WriteLine(n1 + n);

//numb3[3] = 15;

// Cреда 09.10.24                                                                 !!!!!!!!!!!!!!!!!!!!

//обратная последов
//int a = Convert.ToInt32(Console.ReadLine());
//int b = Convert.ToInt32(Console.ReadLine());

//for (int i = b; i >= a; i--)
//{
//    //Console.WriteLine(i);
//}
//Console.ReadKey();

//квадраты
//int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= n; i++) 
// {
//     Console.WriteLine(i * i);
//     Console.ReadKey();
//}
//делетиле
//int y = Convert.ToInt32(Console.ReadLine());
//int count = 0;

//if (y <= 200000)
//{
//    for (int i = 1; i <= y; i++)
//    {
//        if (y % i == 0)
//        {
//            count++;
//        }

//    }
//    Console.WriteLine(count);

//}
//else

//    Console.WriteLine("Вышли за границу!");

// сколько раз делится 
//int h = Convert.ToInt32(Console.ReadLine());
//int count = 0;
//while(h % 3 == 0) // 66/3=22
//{
//    h /= 3;
//    count++;
//}
//Console.WriteLine(count);

//Поиск 1
//int n = Convert.ToInt32(Console.ReadLine());//количесвто элементов
//string s = Console.ReadLine(); // строка для ввода значений массива
//string[] massiv = s.Split(' '); // "3 5 7 8" => [3, 5, 7, 8] преобразование строки в массив с помощью метода сплит
//int[] numbers = new int[n];//объявляем новый пустой массив для целых чисел
//for (int i = 0; i < n; i++)
//{
//    numbers[i] = Convert.ToInt32(massiv[i]);//заполняем целочисленный массив
//}
//for (int i = 0; i < n; i++)
//{
//    if (i % 3 == 0)//проверяем кратность индекса
//    {
//        Console.Write(numbers[i] + " ");//получаем элемент массива
//    }
//}
//Console.ReadKey();

//                                                                                 21.20.24
//палиндрон = симметрическое число
//Console.Write("Напишите число: ");
//int n = Convert.ToInt32(Console.ReadLine());//исход число 3225
//int d = n; //Дублер для изменения 
//int p = 0; //Создали перевертиш
//while (d > 0)
//{
//    p = p * 10 + d % 10; //5 => 52 => 522 => 5223 
//    d = d / 10; // 3 полностью удаляем из числа
//}
//if (n == p) // 3225 == 5223 не равно 
//    Console.WriteLine("Yes");
//else
//    Console.WriteLine("No");
//Console.ReadKey();

// удалить 5 и 7
//int n = Convert.ToInt32(Console.ReadLine());// 234567
//int p = 1; // проебразователь для разряда цифры (единицы , дестые)
//int k = 0;
//while (n != 0)
//{
//    if (n % 10 != 5 && n % 10 != 7)   // 6
//    {
//        k += n % 10 * p; //6 => 46
//        p *= 10; // 10
//    }
//}
//n /= 10; //n = n /10; // 23456 => 2345 => 234
//Console.WriteLine(k);
//Console.ReadKey();

// замечательное число
//int n = Convert.ToInt32(Console.ReadLine());// 12
//int m = n; //12
//int sum = 0;
//while (m > 0)
//{
//    int d = m % 10; // 2 => 1
//    sum += d; // 2 => 2+1 = 3
//    m /= 10; // 2 => 1
//}
//if (n % sum == 0)
//{
//    Console.WriteLine("Yes");
//}
//else Console.WriteLine("No");
//Console.ReadKey();

// 23 октября 2024 год. Y teby poluchitsy
//int n = Convert.ToInt32(Console.ReadLine());
//int k = 0;
//string[] s = Console.ReadLine().Split();
//for(int i = 0; i < s.Length / 2; i++)
//{
//    if (s[1] != s[s.Length - i - 1])
//    {
//        Console.WriteLine("No");
//        k++;
//        break;
//    }
//}
//if(k == 0)
//    Console.WriteLine("Yes");
//Console.ReadKey();

//string[] s = Console.ReadLine().Split();
//int n = Convert.ToInt32(s[0]);
//int m = Convert.ToInt32(s[0]);
//int[,] a = new int[n, m];

//for (int i = 0; i < n; i++)
//{
//   for(int j = 0; j < m; j++)
//    {
//        a[i, j] = (i+1) * (j+1);
//        Console.Write(a[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//Console.ReadKey();


//int n = Convert.ToInt32(Console.ReadLine());
//int[,] num = new int[n, n];

//for (int i = n - 1; i >= 0; i--)
//{
//    for (int j = 0; j <= n - 1; j++)
//    {
//        if (i + j == n - 1)
//            num[i, j] = 1;
//        else if (i + j < n - 1)
//            num[i, j] = 0;
//        else if (i + j > n - 1)
//            num[i, j] = 2;
//    }
//}

//// Вынесение вывода массива за пределы первого цикла
//for (int i = 0; i < n; i++)
//{
//    for (int j = 0; j < n; j++)
//    {
//        Console.Write(num[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//Console.ReadKey();




//ПРАКТИКА 
// Nomer 1
//if (number > 99 && number <= 999)
//{
//    Console.WriteLine("Yes");
//}
//else Console.WriteLine("Вы ввели не трехзначное число");
//Console.ReadKey();

// Nomer 2
//Console.Write("Введите число: ");
//int number = Convert.ToInt32(Console.ReadLine());
//if (number % 2 == 0)
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("No");
//}
//Console.ReadKey();  
// Nomer 3
//Console.Write("Введите число a: ");
//int a = Convert.ToInt32(Console.ReadLine());
//Console.Write("Введите число b: ");
//int b = Convert.ToInt32(Console.ReadLine());

//if (a > b)
//{
//    Console.WriteLine("b не должно превышать a");
//}
//else
//{
//    for (int i = a; i < b; i++)
//    {
//        if (i % 2 == 0)
//        {
//            Console.WriteLine(i);
//        }
//    }

//}
//Console.ReadKey();
//////Nomer 4
//var l = Console.ReadLine();
//if (l.Contains("0")) Console.WriteLine("yes");
//else Console.WriteLine("no");

//Console.Write("Введите трехзначное число: ");
//int number = Convert.ToInt32(Console.ReadLine());
































































//урок №4
//Console.Write("Введите радиус кргуа: ");
//double radius = Convert.ToDouble(Console.ReadLine());
//double area = Math.PI * Math.Pow(radius, 2);
//Console.WriteLine("Площадь круга с радиусом {0} равна {1}", radius, area);

// ЮТУБ 5 РОЛИК 
//int a = 5;
//bool isHasCar = false;

//if (a > 7)
//{   
//    Console.WriteLine("Number > 7 ");
//}
//else if (a < 5)
//{
//    Console.WriteLine("Number < 5 ");
//}
//else if (a == 4)
//{
//    Console.WriteLine("Number is 4 ");
//}
//else if (a == 5 || isHasCar)
//{
//    Console.WriteLine("Number is 5 ");
//    //if (isHasCar)
//        Console.WriteLine("User has car!");
//}

//else
//{
//    Console.WriteLine("Number is unrecognized");
//}     
//Console.ReadKey();   


//Console.Write("Enter name: ");
//string role = Console.ReadLine();


//if (role == "admin")
//{
//    Console.Write("Enter user name: ");
//    string user_name = Console.ReadLine();
//    Console.Write("Enter {0} age: ", user_name);
//    short age = Convert.ToInt16(Console.ReadLine());

//    if(age <= 0 || age > 99)
//    {
//        Console.Write("Enter {0} age: ", user_name);
//        age = Convert.ToInt16(Console.ReadLine());


//    }
//    if (age <= 0 || age > 99)
//    {
//        Console.WriteLine("Error");
//        age = 0;
//    }
//    else Console.WriteLine("Users age is " + age);
//}
//else
//{
//    Console.WriteLine("You are not admin");
//}
//Console.ReadKey();
//УРОК НОМЕР 7 

//for(byte i = 200; i > 10; i /= 2) 
//{
//    Console.WriteLine("Element: {0}", i);            
//}
//Console.ReadKey();

//byte i = 10;
//while(i >= 1)
//{
//    Console.WriteLine("Element: {0}", i);
//    i--;
//}
//Console.ReadKey();

//bool isHasCar = true;
//while(isHasCar) 
//{
//string end = Console.ReadLine();
//    if(end == "end")
//        isHasCar = false;
//}
//Console.ReadKey();
// byte i = 100;
//do
//{
//    Console.WriteLine("Element: ", +i);
//} while (i < 10);

//for(short i = 0; i < 10; i++)
//{    //if ( i > 5)
//     //break; 

//    if (i % 2 == 0)
//        continue;
//    Console.WriteLine("El: " + i);

//}
//Console.ReadKey();

//// Вывод заголовка таблицы
//Console.WriteLine("Таблица умножения:");
//Console.WriteLine("-------------------");

//// Внешний цикл для множителей
//for (int i = 1; i <= 10; i++)
//{
//    // Внутренний цикл для умножаемых
//    for (int j = 1; j <= 10; j++)
//    {
//        // Вывод результата умножения
//        Console.Write($"{i * j,4}"); // Форматирование для выравнивания
//    }
//    Console.WriteLine(); // Переход на новую строку после каждой строки таблицы
//}
//Console.ReadKey();
// !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!МАССИВЫ!!!!!!!!!!!!!!!!!!!!!!!!!!!

//int[] nums = new int[5];
//nums[0] = 250;
//nums[1] = 50;
//nums[2] = 20;
//nums[3] = 100;
//nums[4] = 25;

////Console.WriteLine("El: {0}", nums[0]);

////string[] words = new string[] { "Aydar, Albert, Rifat" };

////words[1] = "Andrei";

//for(int i = 0; i < nums.Length; i++)
//{
//    Console.WriteLine("El: " + nums[i]);
//}
//int[] nums = new int[10];
//int summa = 0;

//Random random = new Random();
//for(short i = 0; i < nums.Length; i++)
//{    
//    nums[i] = Convert.ToInt16(random.Next(-5, 15));
//    Console.WriteLine("El: " + nums[i]);

//    summa += nums[i];

//}
//Console.WriteLine("Summa: " + summa);
//Console.ReadKey();
//char[,] s = new char[2, 3]; 
//s[0, 0] = 'a';
//Console.WriteLine(s[0, 0]);

//int[,] n =
//{
//    {4, 6, 7},
//    {5, 7, 3},
//    {3, 3, 2}

//};

//n[0, 2] = 56;
//Console.ReadKey();
















































































































































