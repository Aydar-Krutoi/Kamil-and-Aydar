using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabota_s_metodami
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nДобро пожаловать в систему управления финансами!");
                Console.WriteLine("1. Добавить доход/расход");
                Console.WriteLine("2. Показать отчет");
                Console.WriteLine("3. Рассчитать баланс");
                Console.WriteLine("4. Прогноз на следующий месяц");
                Console.WriteLine("5. Статистика");
                Console.WriteLine("6. Выход");


                Console.Write("Выберите действие: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Введите категорию (Доход, Продукты, Транспорт, Развлечения): ");
                        string category = Console.ReadLine();
                        Console.Write("Введите сумму: ");
                        if (double.TryParse(Console.ReadLine(), out double amount))
                        {
                            AddTransaction(category, amount);
                        }
                        else
                        {
                            Console.WriteLine("Некорректный ввод суммы.");
                        }
                        break;
                    case "2":
                        PrintFinanceReport();
                        break;
                    case "3":
                        Console.WriteLine($"Текущий баланс: {CalculateBalance()} руб.");
                        break;
                    case "4":
                        Console.WriteLine($"Прогнозируемые расходы на следующий месяц: {PredictNextMonthExpenses()} руб.");
                        break;
                    case "5":
                        PrintStatistics();
                        break;
                    case "6":
                        Console.WriteLine("Выход из программы.");
                        return;
                    default:
                        Console.WriteLine("Некорректный выбор.");
                        break;
                }
            }
        }

        static Dictionary<string, List<double>> finances = new Dictionary<string, List<double>>();

            public static void AddTransaction(string category, double amount)
            {
                if (!finances.ContainsKey(category))
                {
                    finances[category] = new List<double>();
                }
                finances[category].Add(amount);
                Console.WriteLine("Запись добавлена.");
            }

            public static void PrintFinanceReport()
            {
                Console.WriteLine("Финансовый отчет:");
                foreach (var category in finances)
                {
                    Console.WriteLine($"{category.Key}: {category.Value.Sum()} руб. - {category.Value.Count} операций");
                }
            }

            public static double CalculateBalance()
            {
                double income = finances.Where(kv => kv.Key.ToLower().Contains("доход")).Sum(kv => kv.Value.Sum());
                double expenses = finances.Where(kv => !kv.Key.ToLower().Contains("доход")).Sum(kv => kv.Value.Sum());
                return income - expenses;
            }

            public static double GetAverageExpense(string category)
            {
                return finances.ContainsKey(category) ? finances[category].Average() : 0;
            }

            public static double PredictNextMonthExpenses()
            {
                return finances.Where(kv => !kv.Key.ToLower().Contains("доход")).Sum(kv => kv.Value.Sum());
            }

            public static void PrintStatistics()
            {
                double totalExpenses = finances.Where(kv => !kv.Key.ToLower().Contains("доход")).Sum(kv => kv.Value.Sum());
                Console.WriteLine($"Общая сумма расходов: {totalExpenses} руб.");

                var mostExpensiveCategory = finances
                    .Where(kv => !kv.Key.ToLower().Contains("доход"))
                    .OrderByDescending(kv => kv.Value.Sum())
                    .FirstOrDefault();

                if (mostExpensiveCategory.Key != null)
                {
                    Console.WriteLine($"Самая затратная категория: {mostExpensiveCategory.Key} ({mostExpensiveCategory.Value.Sum()} руб.)");
                }

                var mostFrequentCategory = finances
                   .Where(kv => !kv.Key.ToLower().Contains("доход"))
                   .OrderByDescending(kv => kv.Value.Count)
                   .FirstOrDefault();

                if (mostFrequentCategory.Key != null)
                {
                    Console.WriteLine($"Самая частая категория: {mostFrequentCategory.Key} ({mostFrequentCategory.Value.Count} операций)");
                }
                Console.WriteLine("Процентное распределение расходов:");
                foreach (var category in finances.Where(kv => !kv.Key.ToLower().Contains("доход")))
                {
                    double categoryTotal = category.Value.Sum();
                    double percentage = (categoryTotal / totalExpenses) * 100;
                    Console.WriteLine($"{category.Key}: {categoryTotal} руб. ({percentage:F2}%)");
                }

            }
       
    }
}
