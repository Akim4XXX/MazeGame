class Game
{
    static void Main(string[] args)
    {
        Console.CursorVisible = false;
        int moveX = 1, moveY = 0;

        char[,] Maze =
                {
                    {'█','▓','█','█','█','█','█','█','█','█','█','█','█','█','█'},
                    {'█','▓','█','▓','▓','▓','▓','█','▓','▓','▓','▓','▓','▓','█'},
                    {'█','▓','█','█','█','▓','█','█','█','█','█','█','█','▓','█'},
                    {'█','▓','▓','▓','▓','▓','▓','▓','▓','▓','▓','█','▓','▓','█'},
                    {'█','▓','█','█','█','▓','█','█','█','█','▓','█','█','▓','█'},
                    {'█','▓','▓','▓','█','▓','▓','▓','█','█','▓','█','▓','▓','█'},
                    {'█','▓','█','█','█','█','█','▓','▓','█','▓','█','█','▓','█'},
                    {'█','▓','▓','▓','█','▓','█','█','▓','█','▓','▓','▓','▓','█'},
                    {'█','▓','█','▓','█','▓','▓','█','▓','█','█','█','█','▓','█'},
                    {'█','▓','█','█','█','█','▓','█','▓','▓','▓','▓','█','█','█'},
                    {'█','▓','█','▓','▓','▓','▓','█','▓','█','█','▓','█','▓','█'},
                    {'█','▓','▓','▓','█','▓','█','█','▓','█','█','▓','▓','▓','█'},
                    {'█','▓','█','▓','█','▓','█','▓','▓','▓','█','▓','█','▓','█'},
                    {'█','▓','█','▓','█','▓','█','▓','█','▓','█','▓','█','▓','█'},
                    {'█','█','█','█','█','█','█','█','█','█','█','$','█','█','█'}
                };

        while (true)
        {
            for (int i = 0; i < Maze.GetLength(0); i++)
            {
                for (int j = 0; j < Maze.GetLength(1); j++)
                {
                    Console.Write(Maze[i, j]);
                }
                Console.WriteLine();
            }

            Console.SetCursorPosition(moveX, moveY);
            Console.Write('@');
            ConsoleKeyInfo charKey = Console.ReadKey();

            switch (charKey.Key)
            {
                case ConsoleKey.UpArrow:
                    if (Maze[moveY - 1, moveX] != '█')
                    {
                        moveY--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (Maze[moveY + 1, moveX] != '█')
                    {
                        moveY++;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (Maze[moveY, moveX - 1] != '█')
                    {
                        moveX--;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (Maze[moveY, moveX + 1] != '█')
                    {
                        moveX++;
                    }
                    break;
            }

            if (Maze[moveY, moveX] == '$')
            {
                Console.Clear();
                break;
            }

            Console.Clear();
        }
        Console.WriteLine("Congratulation!");
        Console.ReadKey();
    }
}