using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int health = 100;
            int potions = 3;
            int gold = 0;
            int arrows = 5;
            bool hasSword = true;
            bool hasBow = true;
            string[] inventory = new string[5];
            int inventoryCount = 0;

            string[] dungeonMap = new string[10];
            Random random = new Random();

            for (int i = 0; i < 9; i++)
            {
                int eventType = random.Next(5);
                switch (eventType)
                {
                    case 0: dungeonMap[i] = "Монстр"; break;
                    case 1: dungeonMap[i] = "Ловушка"; break;
                    case 2: dungeonMap[i] = "Сундук"; break;
                    case 3: dungeonMap[i] = "Торговец"; break;
                    case 4: dungeonMap[i] = "Пустая комната"; break;
                }
            }
            dungeonMap[9] = "Босс"; 

            for (int roomNumber = 0; roomNumber < 10; roomNumber++)
            {
                Console.WriteLine($"\nВы вошли в комнату {roomNumber + 1}.");
                string currentRoomEvent = dungeonMap[roomNumber];
                Console.WriteLine($"В комнате вас ждет: {currentRoomEvent}.");

                switch (currentRoomEvent)
                {
                    case "Монстр":
    
                        int monsterHealth = random.Next(20, 51);
                        Console.WriteLine($"Вы столкнулись с монстром! У него {monsterHealth} здоровья.");

                        while (health > 0 && monsterHealth > 0)
                        {
                            Console.WriteLine("\nВаши действия:");
                            Console.WriteLine("1. Атаковать мечом");
                            if (hasBow && arrows > 0) Console.WriteLine("2. Атаковать луком");
                            Console.WriteLine("3. Использовать зелье (восстанавливает 30 здоровья)");
                            Console.Write("Выберите действие: ");
                            string choice = Console.ReadLine();

                            switch (choice)
                            {
                                case "1":
                             
                                    int swordDamage = random.Next(10, 21);
                                    monsterHealth -= swordDamage;
                                    Console.WriteLine($"Вы нанесли монстру {swordDamage} урона.");
                                    break;
                                case "2":
                                  
                                    if (hasBow && arrows > 0)
                                    {
                                        int bowDamage = random.Next(5, 16);
                                        monsterHealth -= bowDamage;
                                        arrows--;
                                        Console.WriteLine($"Вы нанесли монстру {bowDamage} урона. У вас осталось {arrows} стрел.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("У вас нет стрел или лука!");
                                        continue; 
                                    }
                                    break;
                                case "3":
                                
                                    if (potions > 0)
                                    {
                                        health += 30;
                                        potions--;
                                        Console.WriteLine($"Вы использовали зелье. Ваше здоровье: {health}. У вас осталось {potions} зелий.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("У вас нет зелий!");
                                        continue; 
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Неверный выбор.");
                                    continue; 
                            }

                            if (monsterHealth <= 0)
                            {
                                Console.WriteLine("Вы победили монстра!");
                                break;
                            }
                    
                            int monsterDamage = random.Next(5, 16);
                            health -= monsterDamage;
                            Console.WriteLine($"Монстр нанес вам {monsterDamage} урона. Ваше здоровье: {health}.");

                            if (health <= 0)
                            {
                                Console.WriteLine("Вы погибли...");
                                return; 
                            }
                        }
                        break;

                    case "Ловушка":

                        int trapDamage = random.Next(10, 21);
                        health -= trapDamage;
                        Console.WriteLine($"Вы попали в ловушку и потеряли {trapDamage} здоровья. Ваше здоровье: {health}.");
                        if (health <= 0)
                        {
                            Console.WriteLine("Вы погибли...");
                            return; 
                        }
                        break;

                    case "Сундук":
             
                        Console.WriteLine("Вы нашли сундук! Чтобы открыть его, решите загадку.");
                        int num1 = random.Next(1, 20);
                        int num2 = random.Next(1, 20);
                        int correctAnswer = num1 + num2;
                        Console.Write($"Сколько будет {num1} + {num2}? ");
                        string answer = Console.ReadLine();

                        if (int.TryParse(answer, out int playerAnswer) && playerAnswer == correctAnswer)
                        {
                            Console.WriteLine("Вы открыли сундук!");
                            int rewardType = random.Next(3);
                            switch (rewardType)
                            {
                                case 0:

                                    if (inventoryCount < 5)
                                    {
                                        inventory[inventoryCount] = "Зелье";
                                        inventoryCount++;
                                        Console.WriteLine("Вы нашли зелье и добавили его в инвентарь!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("В инвентаре нет места!");
                                    }
                                    break;
                                case 1:
                                 
                                    int foundGold = random.Next(20, 51);
                                    gold += foundGold;
                                    Console.WriteLine($"Вы нашли {foundGold} золота. Теперь у вас {gold} золота.");
                                    break;
                                case 2:
        
                                    int foundArrows = random.Next(3, 8);
                                    arrows += foundArrows;
                                    Console.WriteLine($"Вы нашли {foundArrows} стрел. Теперь у вас {arrows} стрел.");
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Неправильный ответ. Сундук остался закрытым.");
                        }
                        break;

                    case "Торговец":

                        Console.WriteLine("Вы встретили торговца.");
                        Console.WriteLine($"У вас {gold} золота.");
                        Console.WriteLine("Вы можете купить зелье за 30 золота (восстанавливает 30 здоровья).");
                        Console.Write("Купить зелье? (да/нет): ");
                        string buyChoice = Console.ReadLine();

                        if (buyChoice.ToLower() == "да")
                        {
                            if (gold >= 30)
                            {
                                gold -= 30;
                                potions++;
                                Console.WriteLine($"Вы купили зелье. У вас осталось {gold} золота и {potions} зелий.");
                            }
                            else
                            {
                                Console.WriteLine("Недостаточно золота!");
                            }
                        }
                        break;

                    case "Пустая комната":

                        Console.WriteLine("Комната пуста. Ничего не происходит.");
                        break;

                    case "Босс":
          
                        Console.WriteLine("Вы добрались до босса! Готовьтесь к финальной битве!");
                        int bossHealth = 100;
                        Console.WriteLine($"У босса {bossHealth} здоровья.");

                        while (health > 0 && bossHealth > 0)
                        {
                            Console.WriteLine("\nВаши действия:");
                            Console.WriteLine("1. Атаковать мечом");
                            if (hasBow && arrows > 0) Console.WriteLine("2. Атаковать луком");
                            Console.WriteLine("3. Использовать зелье (восстанавливает 30 здоровья)");
                            Console.Write("Выберите действие: ");
                            string choice = Console.ReadLine();

                            switch (choice)
                            {
                                case "1":
                            
                                    int swordDamage = random.Next(10, 21);
                                    bossHealth -= swordDamage;
                                    Console.WriteLine($"Вы нанесли боссу {swordDamage} урона.");
                                    break;
                                case "2":
                              
                                    if (hasBow && arrows > 0)
                                    {
                                        int bowDamage = random.Next(5, 16);
                                        bossHealth -= bowDamage;
                                        arrows--;
                                        Console.WriteLine($"Вы нанесли боссу {bowDamage} урона. У вас осталось {arrows} стрел.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("У вас нет стрел или лука!");
                                        continue;
                                    }
                                    break;
                                case "3":
                          
                                    if (potions > 0)
                                    {
                                        health += 30;
                                        potions--;
                                        Console.WriteLine($"Вы использовали зелье. Ваше здоровье: {health}. У вас осталось {potions} зелий.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("У вас нет зелий!");
                                        continue; 
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Неверный выбор.");
                                    continue;
                            }

                            if (bossHealth <= 0)
                            {
                                Console.WriteLine("Вы победили босса и выиграли игру!");
                                return; 
                            }

                            int bossDamage = random.Next(15, 26);
                            health -= bossDamage;
                            Console.WriteLine($"Босс нанес вам {bossDamage} урона. Ваше здоровье: {health}.");

                            if (health <= 0)
                            {
                                Console.WriteLine("Вы погибли...");
                                return; 
                            }
                        }
                        break;
                }
            }
        }
    }
}
