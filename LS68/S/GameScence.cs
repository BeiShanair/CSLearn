using LS68.G;
using LS68.M;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS68.GS
{
    class GameScence : IScenceUpdate
    {
        Map map;
        Snake snake;
        Food food;

        int updateIndex = 0;
        public GameScence()
        {
            map = new Map();
            snake = new Snake(40, 10);
            food = new Food(snake);
        }
        public void Update()
        {
            updateIndex++;
            if (updateIndex % 10000 == 0)
            {
                map.Draw();
                food.Draw();
                snake.Move();
                snake.Draw();

                if (snake.CheckEnd(map))
                {
                    Game.ChangeScence(E_ScenceType.End);
                }

                snake.CheckEatFood(food);
                updateIndex = 0;
            }
            // 控制台检测玩家输入，让程序继续执行
            if (Console.KeyAvailable)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        snake.ChangeDir(EMoveDir.Up);
                        break;
                    case ConsoleKey.S:
                        snake.ChangeDir(EMoveDir.Down);
                        break;
                    case ConsoleKey.A:
                        snake.ChangeDir(EMoveDir.Left);
                        break;
                    case ConsoleKey.D:
                        snake.ChangeDir(EMoveDir.Right);
                        break;
                }
            }
        }
    }
}
