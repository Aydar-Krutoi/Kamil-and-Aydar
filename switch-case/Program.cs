using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int user_input = Convert.ToInt32(Console.ReadLine());
      
            switch(user_input)
            {
                case 5:
                    Console.WriteLine("Number is 5");
                    break;
                case 15:
                    Console.WriteLine("Number is 15");
                    break;

                default:
                    Console.WriteLine("Number is error");
                    break;
            }
        }
    }
}
