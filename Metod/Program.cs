using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Add(5, 9);
            Console.WriteLine(result);
            Console.WriteLine(Add(1, 3));
            MessageMethod();
            string str = Console.ReadLine();
            YourMessageMethod(str);
        }
        public static int Add(int a, int b)
        {
            a = a * a;
            return a + b;
        }
        public static void MessageMethod() 
        {
            Console.WriteLine("Hello");
        }
        public static void YourMessageMethod(string mess)
        {
            Console.WriteLine($"Вы ввели: {mess}");
        }
    }
}
