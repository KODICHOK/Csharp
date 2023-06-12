using System;

class Minesweeper
{
    static void Main()
    {
        bool playAgain;

        do
        {
            playAgain = PlayGame();
        } while (playAgain);

        Console.WriteLine("Дякуємо за гру! Натисніть будь-яку клавішу, щоб вийти...");
        Console.ReadKey();
    }

    static bool PlayGame()
    {
        const int boardSize = 5; 
        const int totalMines = 5;

        char[,] board = new char[boardSize, boardSize];
        bool[,] visited = new bool[boardSize, boardSize];

        InitializeBoard(board, '.'); 
        PlaceMines(board, totalMines); 
        CalculateNumbers(board);

        bool gameOver = false;
        bool gameWon = false;

        while (!gameOver && !gameWon)
        {
            PrintBoard(board, visited); 

            Console.Write("Введіть номер рядка (0-{0}): ", boardSize - 1);
            int row = int.Parse(Console.ReadLine());

            Console.Write("Введіть номер стовпця (0-{0}): ", boardSize - 1);
            int col = int.Parse(Console.ReadLine());

            if (row < 0 || row >= boardSize || col < 0 || col >= boardSize)
            {
                Console.WriteLine("Недійсна позиція! Спробуйте ще раз.");
                continue;
            }

            if (visited[row, col])
            {
                Console.WriteLine("Цю клітинку вже перевірено! Спробуйте ще раз.");
                continue;
            }

            visited[row, col] = true;

            if (board[row, col] == 'X')
            {
                Console.WriteLine("Ви підірвали міну! Гра закінчена.");
                gameOver = true;
            }
            else if (board[row, col] == '0')
            {
                ExploreEmptyCells(board, visited, row, col); 
            }
            else
            {
                Console.WriteLine("Кількість мін навколо: {0}", board[row, col]);
            }

            gameWon = IsGameWon(board, visited, totalMines);
        }

        if (gameWon)
        {
            Console.WriteLine("Ви перемогли! Усі міни відмічені.");
        }

        Console.Write("Бажаєте зіграти ще раз? (Так/Ні): ");
        string playAgainInput = Console.ReadLine();

        return (playAgainInput.Trim().ToLower() == "так");
    }

    
    static void InitializeBoard(char[,] board, char initialValue)
    {
        for (int row = 0; row < board.GetLength(0); row++)
        {
            for (int col = 0; col < board.GetLength(1); col++)
            {
                board[row, col] = initialValue;
            }
        }
    }
    static void PlaceMines(char[,] board, int totalMines)
    {
        Random random = new Random();

        int minesPlaced = 0;

        while (minesPlaced < totalMines)
        {
            int row = random.Next(0, board.GetLength(0));
            int col = random.Next(0, board.GetLength(1));

            if (board[row, col] == '.')
            {
                board[row, col] = 'X';
                minesPlaced++;
            }
        }
    }
    static void CalculateNumbers(char[,] board)
    {
        for (int row = 0; row < board.GetLength(0); row++)
        {
            for (int col = 0; col < board.GetLength(1); col++)
            {
                if (board[row, col] == 'X')
                {
                    continue;
                }

                int count = 0;

                for (int i = row - 1; i <= row + 1; i++)
                {
                    for (int j = col - 1; j <= col + 1; j++)
                    {
                        if (i >= 0 && i < board.GetLength(0) &&
                            j >= 0 && j < board.GetLength(1) &&
                            board[i, j] == 'X')
                        {
                            count++;
                        }
                    }
                }

                if (count > 0)
                {
                    board[row, col] = count.ToString()[0];
                }
            }
        }
    }

    static void PrintBoard(char[,] board, bool[,] visited)
    {
        Console.WriteLine("   О 1 2 3 4 5 6 7 8 9");

        for (int row = 0; row < board.GetLength(0); row++)
        {
            Console.Write("{0}  ", row);

            for (int col = 0; col < board.GetLength(1); col++)
            {
                if (visited[row, col])
                {
                    Console.Write("{0} ", board[row, col]);
                }
                else
                {
                    Console.Write("0 ");
                }
            }

            Console.WriteLine();
        }
    }
    static void ExploreEmptyCells(char[,] board, bool[,] visited, int row, int col)
    {
        if (row < 0 || row >= board.GetLength(0) || col < 0 || col >= board.GetLength(1))
        {
            return;
        }

        if (visited[row, col])
        {
            return;
        }

        visited[row, col] = true;

        if (board[row, col] == '0')
        {
            for (int i = row - 1; i <= row + 1; i++)
            {
                for (int j = col - 1; j <= col + 1; j++)
                {
                    ExploreEmptyCells(board, visited, i, j);
                }
            }
        }
    }
    static bool IsGameWon(char[,] board, bool[,] visited, int totalMines)
    {
        int count = 0;

        for (int row = 0; row < board.GetLength(0); row++)
        {
            for (int col = 0; col < board.GetLength(1); col++)
            {
                if (visited[row, col])
                {
                    count++;
                }
            }
        }

        return count == (board.GetLength(0) * board.GetLength(1)) - totalMines;
    }
}