using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string FailPath = @"C:\Users\Айдар\OneDrive\Рабочий стол\info\example.txt"; 

            //string contentDesktop = "Барселона - самая лучшая команда";

            //File.WriteAllText(FailPath, contentDesktop);
            //                 //Путь-------Текст

            //string newData = "\nЭто новые данные";

            ////Метод добавления новых данных
            //File.AppendAllText(FailPath, newData);
            ////Добавление к тексту (Append) 

            //string newСhange = "\nНет, Реал Мадрид лучше";

            //File.AppendAllText(FailPath, newСhange);

            ////Чтение данных из файла
            //string content2 = File.ReadAllText(FailPath);

            ////Чтение файла построчно
            //foreach(string line in File.ReadLines(FailPath))
            //{
            //    Console.WriteLine(line);
            //}
            //Console.WriteLine("Данные в файл записаны");
            //Console.WriteLine("Данные, хранящиеся в файле: " + content2);
            //Console.ReadKey(); 



            // 21.01.2025 ОАИП ЛЕКЦИЯ

            string filePath = "C:\\Users\\Айдар\\OneDrive\\Рабочий стол\\exampleEEE.txt";

            //Используем StreamWriter для записи в файл
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("first string");
                writer.WriteLine("second string");
            }
            Console.WriteLine("Данные записаны в файл: ");




            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }

            }
            
            //узнаем текущую директорию
            string currentDirectory = Directory.GetCurrentDirectory();
            Console.WriteLine("Файл сохранится в папке: ");
            Console.WriteLine(currentDirectory);





            //Указываем путь к файлу
            string folderPath = @"C:\MyFilesAydar";
            string filePath2 = Path.Combine(folderPath, "example.txt");

            //Проверяем, существует ли папка, и создаем ее, если нужно
            if (!Directory.Exists(folderPath)) 
            { 
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("Папка создана: " + folderPath);
            }
            //Записываем данные в файл
            File.WriteAllText(filePath2, "Текст записан в файл внутри новой папки!");
            Console.ReadKey();
        }

    }
}
