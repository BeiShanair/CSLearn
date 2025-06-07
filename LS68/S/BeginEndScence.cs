using LS68.G;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS68.GS
{
    abstract class BeginEndScence : IScenceUpdate
    {
        protected string strTitle;
        protected string strOne;
        protected int nowSelectId = 0;

        public abstract void EnterJDoSomething();

        public void Update()
        {
            // 显示标题
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(Game.width / 2 - strTitle.Length, 5);
            Console.Write(strTitle);

            // 选项
            Console.SetCursorPosition(Game.width / 2 - strOne.Length, 8);
            Console.ForegroundColor = nowSelectId == 0 ? ConsoleColor.Red : ConsoleColor.White;
            Console.Write(strOne);

            Console.SetCursorPosition(Game.width / 2 - 4, 10);
            Console.ForegroundColor = nowSelectId == 1 ? ConsoleColor.Red : ConsoleColor.White;
            Console.Write("结束游戏");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.W:
                    nowSelectId--;
                    if (nowSelectId < 0)
                    {
                        nowSelectId = 0;
                    }
                    break;
                case ConsoleKey.S:
                    nowSelectId++;
                    if (nowSelectId > 1)
                    {
                        nowSelectId = 1;
                    }
                    break;
                case ConsoleKey.J:
                    EnterJDoSomething();
                    break;
            }
        }
    }
}
