using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace praktika_nomer2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 zadanie
            //string change = "C:\\Users\\Айдар\\OneDrive\\Рабочий стол\\SiSharp\\text.txt";

            //using (StreamWriter writer = new StreamWriter(change))
            //{
            //    writer.WriteLine("Привет, как дела?");
            //    writer.WriteLine("Я изучаю работу с файлами.");
            //    writer.WriteLine("Это интересно!");
            //}

            //using (StreamReader reader = new StreamReader(change))
            //{
            //    string line;
            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}

            //int lineCount = 0;
            //int wordCount = 0;
            //int charCount = 0;

            //using (StreamReader reader = new StreamReader(change))
            //{
            //    string line;
            //    while ((line = reader.ReadLine()) != null)
            //    {

            //        lineCount++;


            //        charCount += line.Length;


            //        string[] words = line.Split(new char[] { ' ', '\t' });
            //        wordCount += words.Length;
            //    }
            //}

            //Console.WriteLine("Количество строк: " + lineCount);
            //Console.WriteLine("Количество слов: " + wordCount);
            //Console.WriteLine("Количество символов: " + charCount);


            //Console.ReadKey();

            // 2 zadanie
            //string change = "C:\\Users\\Айдар\\OneDrive\\Рабочий стол\\SiSharp\\text2.txt";

            //using (StreamWriter sw = new StreamWriter(change))
            //{
            //    sw.WriteLine("Привет, мир! Мир прекрасен. ");
            //    sw.WriteLine("Я люблю изучать программирование и мир технологий.");
            //}

            //using (StreamReader sr = new StreamReader(change))
            //{
            //    string line;
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}

            //Console.WriteLine("\nВведите слово которое хотите заменить: ");
            //string desctopWord = Console.ReadLine();
            //Console.WriteLine("Введите новое слово: ");
            //string replaceWord = Console.ReadLine();
            //string[] allLines = File.ReadAllLines(change);
            //for (int i = 0; i < allLines.Length; i++)
            //{
            //    string pattern = $@"\b{Regex.Escape(desctopWord)}\b";
            //    allLines[i] = Regex.Replace(allLines[i], pattern, replaceWord, RegexOptions.IgnoreCase);
            //}
            //File.WriteAllLines(change, allLines);

            //using (StreamReader sr = new StreamReader(change))
            //{
            //    string line;
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}
            // zadanie 3

            //string change = "C:\\Users\\Айдар\\OneDrive\\Рабочий стол\\SiSharp\\text3.txt";
            //using (StreamWriter writer = new StreamWriter(change))
            //{
            //    writer.WriteLine("Привет, мир!");
            //    writer.WriteLine("Как дела?");
            //    writer.WriteLine("Погода сегодня прекрасна.");
            //    writer.WriteLine("Хорошего дня!");
            //}
            //using (StreamReader reader = new StreamReader(change))
            //{
            //    string line;
            //    while ((line = reader.ReadLine()) != null)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}
            //Console.WriteLine("\nВведите символ для поиска строк: ");
            //string desctopWord = Console.ReadLine();
            //string[] allLines = File.ReadAllLines(change);
            //for (int i = 0; i < allLines.Length; i++)
            //{
            //    if (allLines[i].StartsWith(desctopWord))
            //    {
            //        Console.WriteLine(allLines[i]);
            //    }
            //}





        }
    }
}
