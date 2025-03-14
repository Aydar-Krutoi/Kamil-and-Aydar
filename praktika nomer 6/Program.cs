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
        static void Main(string[] args)
        {
            //Zadanie 1
            Calculator();

            // Zadanie 2
            Console.WriteLine("Введите первое число: ");
            int num1 = (Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Введите второе число: ");
            int num2 = (Convert.ToInt32(Console.ReadLine()));

            int max = Max(num1, num2);
            if (Max(num1, num2) == 0)
            {
                Console.WriteLine("Они равны");
            }
            int min = Min(num1, num2);
            if (Min(num1, num2) == 0)
            {
                Console.WriteLine("Они равны");
            }
            

            Console.WriteLine($"Максимальное:  {max}, минимальное:  {min} ");

            // Zadanie 3
            string[] testStrings = { "level", "hello", "radar", "world", "madam" };
            foreach (var str in testStrings)
            {
                bool isPalindrome = IsPalindrome(str);
                Console.WriteLine($"Строка {str} является палиндромом: {isPalindrome}");
            }

            // Zadanie 4
            Console.WriteLine("Введите число для вычисления факториала:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Факториал отрицательного числа не определен.");
            }
            else
            {
                int result = Factorial(n);
                Console.WriteLine($"Факториал {n} равен {result}.");
            }

            // Zadanie 5
            Console.WriteLine("Введите три числа для вычисления среднего арифметического:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            double average = Average(a, b, c);
            Console.WriteLine($"Среднее арифметическое: {average}");

            // Zadanie 6
            Console.WriteLine(FindChar("hello", 'o'));
            Console.WriteLine(FindChar("hello", 'a'));

            // Zadanie 7
            string password = GeneratePassword(6);
            Console.WriteLine(password);

            // Zadanie 8
            double celsius = 0;
            double fahrenheit = CelsiusToFahrenheit(celsius);
            Console.WriteLine($"{celsius} C = {fahrenheit} F");

            double fahrenheit2 = 32;
            double celsius2 = FahrenheitToCelsius(fahrenheit2);
            Console.WriteLine($"{fahrenheit2} F = {celsius2} C");

            // Zadanie 9
            string sentence = "Hello world!";
            string reversedSentence = ReverseWords(sentence);
            Console.WriteLine(reversedSentence);

            // Zadanie 10
            int num = 5;
            MultiplicationTable(num);
        }

        // Zadanie 1
        public static void Calculator()
        {
            bool ar = true;
            double a, b;
            Console.WriteLine("Введите два числа: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double x = Convert.ToDouble(Console.ReadLine());
            a = y; b = x;
            while (ar)
            {
                Console.WriteLine("Выберите действие: (1 - Сложение, 2 - Вычитание, 3 - Умножение, 4 - Деление, 0 - Выход) ");
                double p = Convert.ToDouble(Console.ReadLine());
                if (p == 1)
                {
                    a = a + b;
                    Console.WriteLine("Ответ: " + a);
                }
                else if (p == 2)
                {
                    a = a - b;
                    Console.WriteLine("Ответ: " + a);
                }
                else if (p == 3)
                {
                    a = a * b;
                    Console.WriteLine("Ответ: " + a);
                }
                else if (p == 4)
                {
                    if (b != 0)
                    {
                        a = a / b;
                        Console.WriteLine("Ответ: " + a);
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: деление на ноль.");
                    }
                }
                else if (p == 0)
                {
                    ar = false;
                }
                else
                {
                    Console.WriteLine("Неверный выбор.");
                }
            }
        }

        // Zadanie 2
        public static int Max(int num1, int num2)
        {
            if (num1 > num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }

        public static int Min(int num1, int num2)
        {
            if (num1 < num2)
            {
                return num1;
            }
            else if (num2 < num1)
            {
                return num2;
            }
            else
            {
                return 0;
            }
        }

        // Zadanie 3
        public static bool IsPalindrome(string str)
        {
            str = str.ToLower().Replace(" ", string.Empty);
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string reversedStr = new string(charArray);
            return str == reversedStr;
        }

        // Zadanie 4
        public static int Factorial(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        // Zadanie 5
        public static double Average(int a, int b, int c)
        {
            return (a + b + c) / 3.0;
        }

        // Zadanie 6
        public static int FindChar(string text, char c)
        {
            return text.IndexOf(c);
        }

        // Zadanie 7
        public static string GeneratePassword(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] password = new char[length];

            for (int i = 0; i < length; i++)
            {
                password[i] = chars[random.Next(chars.Length)];
            }

            return new string(password);
        }

        // Zadanie 8
        public static double CelsiusToFahrenheit(double c)
        {
            return c * 9 / 5 + 32;
        }

        public static double FahrenheitToCelsius(double f)
        {
            return (f - 32) * 5 / 9;
        }

        // Zadanie 9
        public static string ReverseWords(string sentence)
        {
            string[] words = sentence.Split(' ');

            for (int i = 0; i < words.Length / 2; i++)
            {
                string temp = words[i];
                words[i] = words[words.Length - 1 - i];
                words[words.Length - 1 - i] = temp;
            }

            return string.Join(" ", words);
        }

        // Zadanie 10
        public static void MultiplicationTable(int n)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }

    }
}  
