namespace LS22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 控制台基础设置

            Console.CursorVisible = false;
            int width = 50;
            int height = 30;
            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);

            #endregion

            #region 场景设置

            int nowScreenId = 1;
            
            while (true)
            {
                switch (nowScreenId)
                {
                    #region 开始场景
                    case 1:
                        Console.Clear();
                        Console.SetCursorPosition(width / 2 - 2, 8);
                        Console.Write("给木");
                        int nowSelectId = 1;
                        bool nowExit = false;
                        while (true)
                        {
                            Console.ForegroundColor = nowSelectId == 1 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.SetCursorPosition(width / 2 - 4, 13);
                            Console.Write("开始游戏");
                            Console.ForegroundColor = nowSelectId == 2 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.SetCursorPosition(width / 2 - 4, 15);
                            Console.Write("结束游戏");

                            char input = Console.ReadKey(true).KeyChar;
                            switch (input)
                            {
                                case 'w':
                                case 'W':
                                    nowSelectId -= 1;
                                    if (nowSelectId < 1)
                                    {
                                        nowSelectId = 1;
                                    }
                                    break;
                                case 's':
                                case 'S':
                                    nowSelectId += 1;
                                    if (nowSelectId > 2)
                                    {
                                        nowSelectId = 2;
                                    }
                                    break;
                                case 'j':
                                case 'J':
                                    switch (nowSelectId)
                                    {
                                        case 1:
                                            nowScreenId = 2;
                                            nowExit = true;
                                            break;
                                        case 2:
                                            Console.Clear();
                                            Environment.Exit(0);
                                            break;
                                    }
                                    break;
                            }
                            if (nowExit)
                            {
                                break;
                            }

                        }
                        break;
                    #endregion

                    #region 游戏场景

                    case 2:
                        Console.Clear();
                        #region 绘制边界
                        Console.ForegroundColor = ConsoleColor.Red;
                        for (int i = 0; i < width; i++)
                        {
                            Console.SetCursorPosition(i, 0);
                            Console.Write("*");
                            Console.SetCursorPosition(i, height - 1);
                            Console.Write("*");
                            Console.SetCursorPosition(i, height - 6);
                            Console.Write("*");
                        }
                        for (int i = 0; i < height; i++)
                        {
                            Console.SetCursorPosition(0, i);
                            Console.Write("*");
                            Console.SetCursorPosition(width - 1, i);
                            Console.Write("*");
                        }
                        #endregion

                        #region 玩家属性

                        int pX = 3;
                        int pY = 3;
                        int pHp = 100;
                        int pAtkMin = 6;
                        int pAtkMax = 16;
                        string pIco = "P";
                        ConsoleColor pColor = ConsoleColor.Yellow;
                        
                        #endregion

                        #region boss属性

                        int BossX = 21;
                        int BossY = 15;
                        int bHp = 100;
                        int bAtkMin = 7;
                        int bAtkMax = 15;
                        string bIco = "B";
                        ConsoleColor bColor = ConsoleColor.Green;
                        
                        #endregion
                        while (true)
                        {
                            if (bHp > 0)
                            {
                                Console.ForegroundColor = bColor;
                                Console.SetCursorPosition(BossX, BossY);
                                Console.Write(bIco);
                            }

                            Console.ForegroundColor = pColor;
                            Console.SetCursorPosition(pX, pY);
                            Console.Write("P");

                            char input2 = Console.ReadKey(true).KeyChar;
                            Console.SetCursorPosition(pX, pY);
                            Console.Write(" ");
                            switch (input2)
                            {
                                case 'w':
                                case 'W':
                                    pY--;
                                    if (pY < 1)
                                    {
                                        pY++;
                                    }
                                    else if (pY == BossY && pX == BossX && bHp > 0)
                                    {
                                        pY++;
                                    }
                                        break;
                                case 's':
                                case 'S':
                                    pY++;
                                    if (pY > height - 7)
                                    {
                                        pY--;
                                    }
                                    else if (pY == BossY && pX == BossX && bHp > 0)
                                    {
                                        pY--;
                                    }
                                    break;
                                case 'a':
                                case 'A':
                                    pX--;
                                    if (pX < 1)
                                    {
                                        pX++;
                                    }
                                    else if (pY == BossY && pX == BossX && bHp > 0)
                                    {
                                        pX++;
                                    }
                                    break;
                                case 'd':
                                case 'D':
                                    pX++;
                                    if (pX > width - 2)
                                    {
                                        pX--;
                                    }
                                    else if (pY == BossY && pX == BossX && bHp > 0)
                                    {
                                        pX--;
                                    }
                                    break;
                            }
                        }
                        
                        break;

                    #endregion

                    #region 结束场景

                    case 3:
                        Console.Clear();
                        break;

                    #endregion

                }
            }
            #endregion

        }
    }
}
