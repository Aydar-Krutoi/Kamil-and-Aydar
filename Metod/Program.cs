using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metod
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    #region ok

        //    //int result = Add(5, 9);
        //    //Console.WriteLine(result);
        //    //Console.WriteLine(Add(1, 3));
        //    //MessageMethod();
        //    //string str = Console.ReadLine();
        //    //YourMessageMethod(str);
        //    //Console.Write("Введите первое число: ");
        //    //int a = Convert.ToInt32(Console.ReadLine());

        //    //Console.Write("Введите второе число: ");
        //    //int b = Convert.ToInt32(Console.ReadLine());

        //    //int input = Add(a, b);

        //    //Console.WriteLine("\nВывод результатов");
        //    //Console.WriteLine($"{a} + {b} = {a + b} ---- (Сумма)");
        //    //Console.WriteLine($"{a} - {b} = {a - b} ---- (Разность)");
        //    //Console.WriteLine($"{a} * {b} = {a * b} ---- (Умножения)");
        //    //Console.WriteLine($"{a} / {b} = {a / b} ---- (Деления)");
        //    #endregion
        //}

        //public static int Add(int a, int b)
        //{
        //    a = a + b;
        //    a = a - b;
        //    a = a * b;
        //    a = a / b;
        //    return a;
        //}
        static void Main()
        {
            Console.Write("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int input = FindMax(num1, num2);
            Console.WriteLine($"Максимальное число: {input} ");
            
        }
        public static int FindMax(int num1, int num2)
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
       
    }
}
