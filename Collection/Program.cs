using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, int> ages = new Dictionary<string, int>
            //{
            //    {"Mike", 80 },
            //    {"Radik", 17 }
            //};
            ////Добавление элмента в словарь
            //ages["Aydar"] = 89;

            ////Проверка наличие ключа и вывод значение
            //if (ages.ContainsKey("Aydar"))
            //{
            //    Console.WriteLine($"Возраст Айдара: {ages["Mike"]}");
            //}
            ////Перебор словаря
            //foreach (var age in ages)
            //{
            //    Console.WriteLine($"{age.Key}:{age.Value}"); //Value- значение
            //}

            ////Очереди
            //Queue<string> queue = new Queue<string>();
            ////Добавление
            //queue.Enqueue("Первый");
            //queue.Enqueue("Второй");
            //queue.Enqueue("Третий");

            ////Извлечение
            //Console.WriteLine(queue.Dequeue());
            ////Просмотр первого элемента
            //Console.WriteLine(queue.Peek());


            ////Стэк
            //Stack<int> stack = new Stack<int>();
            ////Добавление
            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);

            ////Извлечение
            //Console.WriteLine(stack.Pop());
            ////Просмотр первого элемента
            //Console.WriteLine(stack.Peek());

            //Фильтрация через Where
            //List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            //var numbers = list.Where(n => n % 2 == 0);// => лямбада функция
            //Console.WriteLine(string.Join(", ", numbers)); //Соединяет join

            ////Группировка
            //var groups = list.GroupBy(n => n % 2 == 0 ? "Четные" : "Нечетные"); // ? - это условие , GroupBy группирует по условию
            //foreach (var group in groups)
            //{
            //    Console.WriteLine($"{group.Key}:{string.Join(",", group)}");
            //}

            //1 zadanie
            //List<int> lists = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            //var number = lists.RemoveAll(n => n % 2 == 0);
            //Console.WriteLine(string.Join(", ", lists));

            //2 zadanie
            //Console.WriteLine("Журнал телефонных номеров");
            //Dictionary<string, int> dictionary = new Dictionary<string, int>
            //{
            //    {"Aydar", 892744324 },
            //    {"Kamil", 762332992 },
            //    {"Redik", 324234234 }
            //};
            //foreach(var age in dictionary)
            //{
            //    Console.WriteLine($"{age.Key}:{age.Value}");
            //}
        }
    }
}
