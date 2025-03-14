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
                        try
                        {
                            double amount = Convert.ToDouble(Console.ReadLine());
                            AddTransaction(category, amount);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Некорректный ввод суммы.");
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("Введено слишком большое или маленькое число.");
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
                double sum = 0;
                foreach (var amount in category.Value)
                {
                    sum += amount;
                }
                Console.WriteLine($"{category.Key}: {sum} руб. - {category.Value.Count} операций");
            }
        }

        public static double CalculateBalance()
        {
            double income = 0;
            double expenses = 0;

            foreach (var category in finances)
            {
                if (category.Key.ToLower().Contains("доход"))
                {
                    foreach (var amount in category.Value)
                    {
                        income += amount;
                    }
                }
                else
                {
                    foreach (var amount in category.Value)
                    {
                        expenses += amount;
                    }
                }
            }

            return income - expenses;
        }

        public static double GetAverageExpense(string category)
        {
            if (finances.ContainsKey(category))
            {
                double sum = 0;
                foreach (var amount in finances[category])
                {
                    sum += amount;
                }
                return sum / finances[category].Count;
            }
            return 0;
        }

        public static double PredictNextMonthExpenses()
        {
            double totalExpenses = 0;

            foreach (var category in finances)
            {
                if (!category.Key.ToLower().Contains("доход"))
                {
                    foreach (var amount in category.Value)
                    {
                        totalExpenses += amount;
                    }
                }
            }

            return totalExpenses;
        }

        public static void PrintStatistics()
        {
            double totalExpenses = 0;

            foreach (var category in finances)
            {
                if (!category.Key.ToLower().Contains("доход"))
                {
                    foreach (var amount in category.Value)
                    {
                        totalExpenses += amount;
                    }
                }
            }

            Console.WriteLine($"Общая сумма расходов: {totalExpenses} руб.");

            string mostExpensiveCategory = null;
            double maxExpense = 0;

            foreach (var category in finances)
            {
                if (!category.Key.ToLower().Contains("доход"))
                {
                    double categorySum = 0;
                    foreach (var amount in category.Value)
                    {
                        categorySum += amount;
                    }

                    if (categorySum > maxExpense)
                    {
                        maxExpense = categorySum;
                        mostExpensiveCategory = category.Key;
                    }
                }
            }

            if (mostExpensiveCategory != null)
            {
                Console.WriteLine($"Самая затратная категория: {mostExpensiveCategory} ({maxExpense} руб.)");
            }

            string mostFrequentCategory = null;
            int maxOperations = 0;

            foreach (var category in finances)
            {
                if (!category.Key.ToLower().Contains("доход"))
                {
                    if (category.Value.Count > maxOperations)
                    {
                        maxOperations = category.Value.Count;
                        mostFrequentCategory = category.Key;
                    }
                }
            }

            if (mostFrequentCategory != null)
            {
                Console.WriteLine($"Самая частая категория: {mostFrequentCategory} ({maxOperations} операций)");
            }

            Console.WriteLine("Процентное распределение расходов:");
            foreach (var category in finances)
            {
                if (!category.Key.ToLower().Contains("доход"))
                {
                    double categoryTotal = 0;
                    foreach (var amount in category.Value)
                    {
                        categoryTotal += amount;
                    }

                    double percentage = (categoryTotal / totalExpenses) * 100;
                    Console.WriteLine($"{category.Key}: {categoryTotal} руб. ({percentage:F2}%)");
                }
            }
        }
    }
}
