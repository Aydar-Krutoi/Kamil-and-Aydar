using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ОИАП ЛЕКЦИЯ 17.01.2025
            //указываем путь к файлу
            string filePath = "example.txt";

            // Указываем полный путь
            string newFailPath = @"C:\Users\Айдар\OneDrive\Рабочий стол\newAydar\newExample.txt";

            //Данные для записи в файл
            string content = "Текст для файла ";


            //Данные для записи в файл на рабочем столе
            string contentDesktop = "Текст для файла на рабочем столе";            


            // Запись данных в файл
            File.WriteAllText(filePath, content);


            //Запись в файл на рабочем столе
            File.WriteAllText(newFailPath, contentDesktop);


            //Данные для добавления в файл
            string newData = "\nЭто новые данные";

            //Метод добавления новых данных
            File.AppendAllText(filePath, newData);

            //Чтение данных из файла
            string content2 = File.ReadAllText(filePath);

            //Чтение файла построчно 
            foreach (string line in File.ReadLines(newFailPath)) 
            {
                Console.WriteLine(line);
            }

            Console.WriteLine("Данные в файл записаны");
            Console.WriteLine("Данные, хранящие в файле: " + content2 );
        }

    }
}
