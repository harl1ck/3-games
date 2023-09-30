using System;

namespace threegames
{
    internal class Program
    {
        static Random random = new Random();

        static void Game1()
        {
            var randomint = random.Next(1, 100);
            while (true)
            {
                Console.WriteLine("Число: ");
                var input = Convert.ToInt32(Console.ReadLine());
                if (input < randomint)
                {
                    Console.WriteLine("Число больше!");
                }
                else if (input == randomint)
                {
                    Console.WriteLine("Вы угадали число!");
                    break;
                }
                else if (input > randomint)
                {
                    Console.WriteLine("Число меньше!");
                }
            }
        }

        static void Game2()
        {
            int[,] i1 = new int[10, 10];
            for (int i = 1; i < 10; ++i)
            {
                for (int j = 1; j < 10; ++j)
                {
                    i1[i, j] = i * j;
                }
            }

            for (int i = 1; i < 10; ++i)
            {
                for (int j = 1; j < 10; ++j)
                {
                    Console.Write(i1[i, j] + "\t");
                }
                Console.WriteLine("");
            }
        }

        static void Game3()
        {
            Console.WriteLine("Введите число: ");
            int input = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= input; i++)
            {
                if ((input % i == 0) == true)
                {
                    Console.Write(i + "\n");
                }
            }
        }


        public static void Main(string[] args)
        {

            Console.WriteLine("Выберите одну из трёх игр ");
            while (true)
            {
                
                Console.WriteLine("1. Угадай число");
                Console.WriteLine("2. Таблица умножения");
                Console.WriteLine("3. Вывод делителей числа");
                Console.WriteLine("4. Выход из программы...");

                string a = Console.ReadLine();

                switch (a)
                {
                    case "1":
                        Game1();
                        break;
                    case "2":
                        Game2();
                        break;
                    case "3":
                        Game3();
                        break;
                    case "4":
                        Console.WriteLine("Чтобы выйти нажмите ENTER");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}