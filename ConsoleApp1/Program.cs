using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            string input = Console.ReadLine();
            try
            {
                int number = Convert.ToInt32(input);
                Console.WriteLine("Вы ввели число: " +  number);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }   
    }
}
