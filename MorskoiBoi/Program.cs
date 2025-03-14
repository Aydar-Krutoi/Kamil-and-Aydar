using System;

namespace SeaBattle
{
    class Program
    {
        static int[,] playerField = new int[10, 10]; 
        static int[,] enemyField = new int[10, 10];  
        static Random random = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в игру Морской бой!");
            InitializeField(playerField);
            InitializeField(enemyField);

            PlaceShips(playerField);
            PlaceShips(enemyField);

            while (true)
            {
                Console.WriteLine("Ваше поле:");
                DisplayField(playerField, true);

                Console.WriteLine("Поле противника:");
                DisplayField(enemyField, false);

                PlayerTurn();
                if (CheckWin(enemyField))
                {
                    Console.WriteLine("Вы победили!");
                    break;
                }

                EnemyTurn();
                if (CheckWin(playerField))
                {
                    Console.WriteLine("Вы проиграли!");
                    break;
                }
            }
        }

        static void InitializeField(int[,] field)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    field[i, j] = 0; 
                }
            }
        }

        // Размещение кораблей
        static void PlaceShips(int[,] field)
        {
            int[] shipSizes = { 4, 3, 3, 2, 2, 2, 1, 1, 1, 1 }; 

            foreach (int size in shipSizes)
            {
                bool placed = false;
                while (!placed)
                {
                    int x = random.Next(0, 10);
                    int y = random.Next(0, 10);
                    bool horizontal = random.Next(0, 2) == 0;

                    if (CanPlaceShip(field, x, y, size, horizontal))
                    {
                        PlaceShip(field, x, y, size, horizontal);
                        placed = true;
                    }
                }
            }
        }

        static bool CanPlaceShip(int[,] field, int x, int y, int size, bool horizontal)
        {
            for (int i = 0; i < size; i++)
            {
                int newX = x + (horizontal ? i : 0);
                int newY = y + (horizontal ? 0 : i);

                if (newX >= 10 || newY >= 10 || field[newX, newY] != 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void PlaceShip(int[,] field, int x, int y, int size, bool horizontal)
        {
            for (int i = 0; i < size; i++)
            {
                int newX = x + (horizontal ? i : 0);
                int newY = y + (horizontal ? 0 : i);
                field[newX, newY] = 1; 
            }
        }

        static void DisplayField(int[,] field, bool showShips)
        {
            Console.WriteLine("  0 1 2 3 4 5 6 7 8 9");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < 10; j++)
                {
                    if (field[i, j] == 0)
                    {
                        Console.Write(". ");
                    }
                    else if (field[i, j] == 1 && showShips)
                    {
                        Console.Write("S ");
                    }
                    else if (field[i, j] == 2)
                    {
                        Console.Write("X ");
                    }
                    else if (field[i, j] == 3)
                    {
                        Console.Write("O ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }
        }

        static void PlayerTurn()
        {
            Console.WriteLine("Ваш ход! Введите координаты (x y):");
            string input = Console.ReadLine();
            string[] coordinates = input.Split(' ');
            int x = int.Parse(coordinates[0]);
            int y = int.Parse(coordinates[1]);

            if (enemyField[x, y] == 1)
            {
                Console.WriteLine("Попадание!");
                enemyField[x, y] = 2; 
            }
            else
            {
                Console.WriteLine("Промах!");
                enemyField[x, y] = 3; 
            }
        }

        static void EnemyTurn()
        {
            Console.WriteLine("Ход противника...");
            int x = random.Next(0, 10);
            int y = random.Next(0, 10);

            if (playerField[x, y] == 1)
            {
                Console.WriteLine("Противник попал!");
                playerField[x, y] = 2;
            }
            else
            {
                Console.WriteLine("Противник промахнулся!");
                playerField[x, y] = 3; 
            }
        }

        static bool CheckWin(int[,] field)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (field[i, j] == 1)
                    {
                        return false; 
                    }
                }
            }
            return true; 
        }
    }
}
