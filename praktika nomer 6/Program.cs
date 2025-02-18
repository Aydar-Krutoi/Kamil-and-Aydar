using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktika_nomer_6
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    var prog = new Program();
        //    Add();

        //}
        ////zadanie 1
        //public static void Add()
        //{
        //    bool ar = true;
        //    double a, b;
        //    Console.WriteLine("Числа: ");
        //    double y = Convert.ToInt32(Console.ReadLine());
        //    double x = Convert.ToInt32(Console.ReadLine());
        //    a = y; b = x;
        //    while (ar)
        //    {
        //        Console.WriteLine("Выберите действие: (1 - Сложение, 2 - Вычитание, 3 - Умножение, 4 - Деление, 0 - Выход) ");
        //        double p = Convert.ToInt32(Console.ReadLine());
        //        if (p == 1)
        //        {
        //            a = a + b;
        //            Console.WriteLine("Ответ: " + a);
        //            a = y;
        //        }
        //        else if (p == 2)
        //        {
        //            a = a - b;
        //            Console.WriteLine("Ответ: " + a);
        //            a = y;
        //        }
        //        else if (p == 3)
        //        {
        //            a = a * b;
        //            Console.WriteLine("Ответ: " + a);
        //            a = y;
        //        }
        //        else if (p == 4)
        //        {
        //            a = a / b;
        //            Console.WriteLine("Ответ: " + a);
        //            a = y;
        //        }
        //        else if (p == 0)
        //        {
        //            ar = false;
        //        }
        //    }

        //}


        ////zadanie nomer 2
        //static void Main(string[] args)
        //{
        //    var result = Add();
        //    Console.WriteLine($"Минимальное значение: {result.min}, Максимальное значение: {result.max}");
        //}

        //public static (int min, int max) Add()
        //{
        //    int[] numbers = new int[] { 1, 3, 9, 30, 22, 15 };
        //    int min = numbers.Min();
        //    int max = numbers.Max();

        //    return (min, max);
        //}
        ////zadanie nomer 3
        //static void Main(string[] args)
        //{
        //    string[] testStrings = { "level", "hello", "radar", "world", "madam" };

        //    foreach (var str in testStrings)
        //    {
        //        bool isPalindrome = IsPalindrome(str);
        //        Console.WriteLine($"Строка {str} является палиндромом: {isPalindrome}");
        //    }
        //}

        //public static bool IsPalindrome(string str)
        //{
        //    str = str.ToLower().Replace(" ", string.Empty);////Убирает запятую

        //    char[] charArray = str.ToCharArray();
        //    Array.Reverse(charArray);//переварачивает слово
        //    string reversedStr = new string(charArray);

        //    return str == reversedStr;
        //}

        //// zadanie nomer 4
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Введите число для вычисления факториала:");
        //    int n = Convert.ToInt32(Console.ReadLine());

        //    if (n < 0)
        //    {
        //        Console.WriteLine("Факториал отрицательного числа не определен.");
        //    }
        //    else
        //    {
        //        int result = Factorial(n);
        //        Console.WriteLine($"Факториал {n} равен {result}.");
        //    }
        //}

        //public static int Factorial(int n)
        //{
        //    int result = 1;
        //    for (int i = 1; i <= n; i++)
        //    {
        //        result *= i;
        //    }
        //    return result;
        //}

        //zadanie nomer 5
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Введите три числа для вычисления среднего арифметического:");

        //    Console.Write("Первое число: ");
        //    int a = Convert.ToInt32(Console.ReadLine());

        //    Console.Write("Второе число: ");
        //    int b = Convert.ToInt32(Console.ReadLine());

        //    Console.Write("Третье число: ");
        //    int c = Convert.ToInt32(Console.ReadLine());

        //    double average = Average(a, b, c);//Average метод который считает средн ариф знач 
        //    Console.WriteLine($"Среднее арифметическое: {average}");
        //}

        //public static double Average(int a, int b, int c)
        //{
        //    return (a + b + c) / 3.0;
        //}

        //zadanie nomer 6
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(FindChar("hello", 'o')); 
        //    Console.WriteLine(FindChar("hello", 'a')); 
        //}

        //public static int FindChar(string text, char c)
        //{
        //    return text.IndexOf(c);
        //}

        // zadanie 7
        //static void Main(string[] args)
        //{
        //    string password = GeneratePassword(6);
        //    Console.WriteLine(password);
        //}

        //public static string GeneratePassword(int length)
        //{
        //    Random random = new Random();

        //    char[] password = new char[length];

        //    for (int i = 0; i < length; i++)
        //    {
        //        password[i] = (char)('0' + random.Next(0, 10));
        //    }

        //    return new string(password);
        //}

        //zadanie 8
        //static void Main(string[] args)
        //{
        //    double celsius = 0;
        //    double fahrenheit = CelsiusToFahrenheit(celsius);
        //    Console.WriteLine($"{celsius} C = {fahrenheit} F"); 

        //    double fahrenheit2 = 32;
        //    double celsius2 = FahrenheitToCelsius(fahrenheit2);
        //    Console.WriteLine($"{fahrenheit2} F = {celsius2} C"); 
        //}

        //public static double CelsiusToFahrenheit(double c)
        //{
        //    return c * 9 / 5 + 32;
        //}

        //public static double FahrenheitToCelsius(double f)
        //{
        //    return (f - 32) * 5 / 9;
        //}

        //zadanie 9
        //static void Main(string[] args)
        //{
        //    string sentence = "Hello world!";
        //    string reversedSentence = ReverseWords(sentence);
        //    Console.WriteLine(reversedSentence);
        //}

        //public static string ReverseWords(string sentence)
        //{
        //    string[] words = sentence.Split(' ');

        //    Array.Reverse(words);

        //    return string.Join(" ", words);
        //}

        // zadanie 10
        //static void Main(string[] args)
        //{
        //    int n = 5;
        //    MultiplicationTable(n);
        //}

        //public static void MultiplicationTable(int n)
        //{
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine($"{n} x {i} = {n * i}");
        //    }
        //}

    }
}  
