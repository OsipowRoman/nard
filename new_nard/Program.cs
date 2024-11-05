using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace long_nurd
{
    class Program
    {
        class players
        {
            byte zariki;
        }

        class player_1 : players
        {

        }

        class player_2 : players
        {



        }

        class Game
        {
            int zarik_1;
            int zarik_2;
            int[] pole;
            public void start_position()
            {
                for (int y = 0; y <= 13; y++)
                {
                    if (y == 6) continue;
                    Console.SetCursorPosition(0, y);
                    Console.WriteLine("(");
                }

                for (int y = 0; y <= 12; y++)
                {
                    if (y == 6) continue;

                    Console.SetCursorPosition(32, y);
                    Console.WriteLine(")");
                }
                for (int x = 0; x <= 14; x ++)
                {
                    Console.SetCursorPosition(x, 0);
                    Console.Write("");
                }

            }

            public void drow_zariki()
            {
                Random random = new Random();
                zarik_1 = random.Next(1, 7);
                zarik_2 = random.Next(1, 7);

                Console.SetCursorPosition(1, 15);
                Console.WriteLine("Первый зарик - " + zarik_1 + " Второй зарик - " + zarik_2);
            }

        }

        class stone
        {
            char color;
            int[] position;
            bool is_home;

        }

        static void Main(string[] args)
        {
            bool run_game = true;
            Game game = new Game();
            game.start_position();
            game.drow_zariki();
            while (run_game == true)
            {
                Console.WriteLine("Нажмите на любую клавишу для завершения");
                Console.ReadKey();
            }

        }
    }
}
