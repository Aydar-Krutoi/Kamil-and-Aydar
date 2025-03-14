using System;
using System.ComponentModel;
using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        int sum = CalcutAddition(2, 5);
        int sub = CalcutSubstraction(5, 3);
        int mult = CalcutMultiplication(5, 3);
        int div = CalcutDivision(15, 5);
        int max = Max(5, 8);
        int min = Min(5, 8);
        Console.WriteLine(sum + " " + sub + " " + div + " " + mult);
        Console.WriteLine(max + " " + min);
        string level = "level";
        Console.WriteLine(IsPalindrome(level));
        int a = 10;
        int b = 5;
        int factorial = Factorial(3);
        Console.WriteLine(factorial);
        double average = Average(1, 2, 5);
        Console.WriteLine(average);
        Console.WriteLine(GeneratePassword(6));
        string myString = "Hello, world!";
        char charToFind = 'o';
        int index = FindChar(myString, charToFind);
        Console.WriteLine(CelsiusToFahrenheit(0));
        Console.WriteLine(FahrenheitToCelsius(32));
        Console.WriteLine(ReverseWords("Hello world!"));
        MultiplicationTable(5);


    }
    //Первое задание
    public static int CalcutAddition(int a, int b)
    {
        return a + b;
    }
    public static int CalcutSubstraction(int a, int b)
    {
        return a - b;
    }
    public static int CalcutMultiplication(int a, int b)
    {
        return a * b;
    }
    public static int CalcutDivision(int a, int b)
    {
        return a / b;
    }
    //Второе задание
    public static int Max(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
    public static int Min(int a, int b)
    {
        if (a < b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
    //Третье задание
    public static bool IsPalindrome(string str)
    {
        if (string.IsNullOrEmpty(str)) return true;

        str = str.ToLower();

        for (int i = 0; i < str.Length / 2; i++)
        {
            if (str[i] != str[str.Length - i - 1])
            {
                return false;
            }
        }

        return true;
    }
    //Четвертое задание
    public static int Factorial(int n)
    {
        int i = 1;
        while (n != 0)
        {
            i *= n;
            n--;
        }
        return i;
    }
    //5 задание
    public static double Average(int a, int b, int c)
    {
        return (double)(a + b + c) / 3;
    }
    //6 задание
    public static int FindChar(string text, char c)
    {
        if (string.IsNullOrEmpty(text))
        {
            return -1;
        }

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == c)
            {
                return i;
            }
        }

        return -1;
    }

    //7 задание
    public static string GeneratePassword(int length)
    {
        if (length <= 0)
        {
            return "";
        }

        Random random = new Random();
        StringBuilder password = new StringBuilder();

        for (int i = 0; i < length; i++)
        {
            int digit = random.Next(0, 10);
            password.Append(digit);
        }

        return password.ToString();
    }
    //8 задание
    public static double CelsiusToFahrenheit(double c)
    {
        return c * 9 / 5 + 32;
    }
    public static double FahrenheitToCelsius(double f)
    {
        return (f - 32) * 5 / 9;
    }
    //9 задание
    public static string ReverseWords(string sentence)
    {
        string[] words = sentence.Trim().Split(' ');

        if (words.Length == 0 || (words.Length == 1 && string.IsNullOrEmpty(words[0])))
        {
            return "";
        }

        Array.Reverse(words);

        return string.Join(" ", words);
    }
    //10 задание
    public static void MultiplicationTable(int n)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
        }
    }
}
