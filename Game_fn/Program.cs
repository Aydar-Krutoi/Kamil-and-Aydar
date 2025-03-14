using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_fn
{
    internal class Program
    {
        static int health;
        static int maxHealth;
        static int gold;
        static int potions;
        static int arrows;
        static bool hasSword;
        static bool hasBow;
        static Random random = new Random();
        static string[] inventory = new string[5];  
        static int inventoryCount = 0;

        public static void Main(string[] args)
        {
            InitializeGame();
            StartGame();
        }

        static void InitializeGame()
        {
            health = 100;
            maxHealth = 100;
            gold = 10;
            potions = 2;
            arrows = 5;
            hasSword = true;
            hasBow = true;
            Console.WriteLine("Добро пожаловать в Числовой квест ULTIMATE!");
            Console.WriteLine("Вы отправляетесь в подземелье, полное опасностей.");
        }

        static void StartGame()
        {
            for (int roomNumber = 1; roomNumber <= 15; roomNumber++)
            {
                Console.WriteLine($"\nВы входите в комнату № {roomNumber}.");
                ProcessRoom(roomNumber);

                if (health <= 0)
                {
                    EndGame(false);
                    return;
                }
            }
            FightBoss();
        }

        static void ProcessRoom(int roomNumber)
        {
            int eventType = random.Next(6);
            switch (eventType)
            {
                case 0:
                    FightMonster();
                    break;
                case 1:
                    TriggerTrap();
                    break;
                case 2:
                    OpenChest();
                    break;
                case 3:
                    VisitMerchant();
                    break;
                case 4:
                    VisitAltar();
                    break;
                case 5:
                    MeetDarkMage();
                    break;
            }
        }

        static void FightMonster()
        {
            int monsterHealth = random.Next(20, 51);
            int monsterAttack = random.Next(5, 16);
            Console.WriteLine($"Вы встретили монстра! Здоровье: {monsterHealth}, Атака: {monsterAttack}");

            while (health > 0 && monsterHealth > 0)
            {
                ShowStats();
                Console.WriteLine("Выберите действие: (1) Атаковать мечом, (2) Атаковать луком");
                string choice = Console.ReadLine();
                int playerDamage = 0;

                if (choice == "1" && hasSword)
                {
                    playerDamage = random.Next(10, 21);
                }
                else if (choice == "2" && hasBow && arrows > 0)
                {
                    playerDamage = random.Next(5, 16);
                    arrows--;
                    Console.WriteLine("Вы потратили стрелу.");
                }
                else
                {
                    Console.WriteLine("Неверный выбор или недостаточно ресурсов.");
                    continue;
                }

                monsterHealth -= playerDamage;
                Console.WriteLine($"Вы нанесли {playerDamage} урона. У монстра осталось {monsterHealth} здоровья.");

                if (monsterHealth <= 0) break;

                health -= monsterAttack;
                Console.WriteLine($"Монстр нанес {monsterAttack} урона. У вас осталось {health} здоровья.");
            }

            if (health <= 0)
            {
                Console.WriteLine("Вы погибли!");
                EndGame(false);
            }
            else
            {
                Console.WriteLine("Вы победили монстра!");
            }
        }

        static void OpenChest()
        {
            Console.WriteLine("Вы нашли сундук!");
            if (random.Next(10) < 2) 
            {
                Console.WriteLine("Это проклятый сундук! Получаете золото, но теряете 10 максимального здоровья.");
                gold += 5;
                maxHealth -= 10;
                health = Math.Min(health, maxHealth); 
            }
            else
            {
                int rewardType = random.Next(3); 
                switch (rewardType)
                {
                    case 0:
                        gold += random.Next(10, 31);
                        Console.WriteLine("Вы нашли золото!");
                        break;
                    case 1:
                        potions++;
                        Console.WriteLine("Вы нашли зелье!");
                        break;
                    case 2:
                        arrows += random.Next(3, 8);
                        Console.WriteLine("Вы нашли стрелы!");
                        break;
                }
            }
        }

        static void TriggerTrap()
        {
            int damage = random.Next(5, 21);
            health -= damage;
            Console.WriteLine($"Вы попали в ловушку и потеряли {damage} здоровья.");
        }

        static void VisitMerchant()
        {
            Console.WriteLine("Вы встретили торговца.");
            Console.WriteLine("Что желаете купить? (1) Зелье (10 золота), (2) Стрелы (5 золота за 3 шт), (3) Ничего");
            string choice = Console.ReadLine();

            if (choice == "1" && gold >= 10)
            {
                gold -= 10;
                potions++;
                Console.WriteLine("Вы купили зелье.");
            }
            else if (choice == "2" && gold >= 5)
            {
                gold -= 5;
                arrows += 3;
                Console.WriteLine("Вы купили 3 стрелы.");
            }
            else
            {
                Console.WriteLine("Недостаточно золота или неверный выбор.");
            }
        }

        static void VisitAltar()
        {
            Console.WriteLine("Вы нашли алтарь.");
            Console.WriteLine("Что желаете улучшить? (1) Урон меча (+5, 10 золота), (2) Восстановить здоровье (+20 HP, 10 золота), (3) Ничего");
            string choice = Console.ReadLine();

            if (choice == "1" && gold >= 10)
            {
                gold -= 10;
        
                Console.WriteLine("Вы улучшили урон меча.");
            }
            else if (choice == "2" && gold >= 10)
            {
                gold -= 10;
                health += 20;
                health = Math.Min(health, maxHealth);
                Console.WriteLine("Вы восстановили здоровье.");
            }
            else
            {
                Console.WriteLine("Недостаточно золота или неверный выбор.");
            }
        }

        static void MeetDarkMage()
        {
            Console.WriteLine("Вы встретили таинственного мага.");
            Console.WriteLine("Он предлагает сделку: обменять 10 здоровья на 2 зелья и 5 стрел. Согласны? (да/нет)");
            string choice = Console.ReadLine();

            if (choice.ToLower() == "да" && health >= 10)
            {
                health -= 10;
                potions += 2;
                arrows += 5;
                Console.WriteLine("Вы заключили сделку с магом.");
            }
            else
            {
                Console.WriteLine("Маг исчез.");
            }
        }

        static void UsePotion()
        {
            if (potions > 0)
            {
                potions--;
                health += 30;
                health = Math.Min(health, maxHealth);
                Console.WriteLine("Вы использовали зелье и восстановили 30 здоровья.");
            }
            else
            {
                Console.WriteLine("У вас нет зелий.");
            }
        }

        static void ShowStats()
        {
            Console.WriteLine($"Здоровье: {health}/{maxHealth}, Золото: {gold}, Зелья: {potions}, Стрелы: {arrows}");
        }

        static void FightBoss()
        {
            Console.WriteLine("Вы вошли в комнату с финальным боссом!");
            int bossHealth = 100;
            int bossDamage = 0;
            while (health > 0 && bossHealth > 0)
            {
                ShowStats();
                Console.WriteLine("Выберите действие: (1) Атаковать мечом, (2) Атаковать луком, (3) Использовать зелье");
                string choice = Console.ReadLine();
                int playerDamage = 0;

                if (choice == "1" && hasSword)
                {
                    playerDamage = random.Next(10, 21);
                }
                else if (choice == "2" && hasBow && arrows > 0)
                {
                    playerDamage = random.Next(5, 16);
                    arrows--;
                    Console.WriteLine("Вы потратили стрелу.");
                }
                else if (choice == "3" && potions > 0)
                {
                    UsePotion();
                    continue;
                }
                else
                {
                    Console.WriteLine("Неверный выбор или недостаточно ресурсов.");
                    continue;
                }
                bossHealth -= playerDamage;
                Console.WriteLine($"Вы нанесли {playerDamage} урона. У босса осталось {bossHealth} здоровья.");

                if (bossHealth <= 0) break;

                bossDamage = random.Next(15, 26);
                health -= bossDamage;
                Console.WriteLine($"Босс нанес {bossDamage} урона. У вас осталось {health} здоровья.");
            }
            if (health <= 0)
            {
                Console.WriteLine("Вы погибли!");
                EndGame(false);
            }
            else
            {
                Console.WriteLine("Вы победили босса!");
                EndGame(true);
            }
        }

        static void EndGame(bool isWin)
        {
            if (isWin)
            {
                Console.WriteLine("Вы победили и прошли Числовой квест ULTIMATE!");
            }
            else
            {
                Console.WriteLine("Игра окончена.");
            }
        }
    }
}

    

