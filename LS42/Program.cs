namespace LS42
{
    internal class Program
    {
        #region 控制台基础设置
        static void ConsoleInit(int width, int height)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);
        }
        #endregion

        #region 场景选择
        enum E_ScenceType
        {
            Begin,
            Game,
            End
        }
        #endregion

        #region 开始场景内容
        static void BeginScreen(int width, int height, ref E_ScenceType scenceType)
        {
            Console.SetCursorPosition(width / 2 - 3, 8);
            Console.Write("飞行棋");

            int nowSelectId = 0;
            bool nowExit = false;
            while (true)
            {
                Console.SetCursorPosition(width / 2 - 4, 13);
                Console.ForegroundColor = nowSelectId == 0 ? ConsoleColor.Red : ConsoleColor.White;
                Console.Write("开始游戏");
                Console.SetCursorPosition(width / 2 - 4, 15);
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
                        if (nowSelectId == 0)
                        {
                            scenceType = E_ScenceType.Game;
                            nowExit = true;
                        }
                        else
                        {
                            Console.Clear();
                            Environment.Exit(0);
                        }
                        break;
                }
                if (nowExit)
                {
                    break;
                }
            }
        }
        #endregion

        #region 游戏场景内容

        #region 边界
        static void DrawWall(int width, int height)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < width - 1; i += 2)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("■");
                Console.SetCursorPosition(i, height - 1);
                Console.Write("■");
                Console.SetCursorPosition(i, height - 6);
                Console.Write("■");
                Console.SetCursorPosition(i, height - 11);
                Console.Write("■");
            }

            for (int i = 0; i < height - 1; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("■");
                Console.SetCursorPosition(width - 2, i);
                Console.Write("■");
            }

            // 文字信息
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, height - 10);
            Console.Write("B: 普通格子");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(2, height - 9);
            Console.Write("S: 暂停一回合");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(26, height - 9);
            Console.Write("T: 炸弹，退5格");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(2, height - 8);
            Console.Write("Q: 时空隧道，随机倒退、暂停、换位置");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(2, height - 7);
            Console.Write("P: 玩家");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(12, height - 7);
            Console.Write("C: 电脑");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(22, height - 7);
            Console.Write("R: 玩家和电脑重合");

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, height - 5);
            Console.Write("按任意键开始扔骰子");
        }
        #endregion

        static void GameScreen(int width, int height, ref E_ScenceType scenceType)
        {
            DrawWall(width, height);
            while (true)
            {

            }
        }

        
        #endregion
        static void Main(string[] args)
        {
            #region 控制台初始化
            int w = 50;
            int h = 30;
            ConsoleInit(w, h);
            #endregion

            #region 场景选择
            E_ScenceType nowScenceType = E_ScenceType.Begin;
            while (true)
            {
                switch (nowScenceType)
                {
                    #region 开始场景
                    case E_ScenceType.Begin:
                        Console.Clear();
                        BeginScreen(w, h, ref nowScenceType);
                        break;
                    #endregion

                    #region 游戏场景
                    case E_ScenceType.Game:
                        Console.Clear();
                        GameScreen(w, h, ref nowScenceType);
                        break;
                    #endregion

                    #region 结束场景
                    case E_ScenceType.End:
                        Console.Clear();
                        break;
                    #endregion
                }
            }
            #endregion
        }
    }
}
