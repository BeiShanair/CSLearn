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
            string str = "";
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
                        bool isFight = false;

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

                        int cX = 24;
                        int cY = 5;
                        string cIco = "C";
                        ConsoleColor cColor = ConsoleColor.Blue;

                        bool isOver = false;

                        while (true)
                        {
                            if (bHp > 0)
                            {
                                Console.ForegroundColor = bColor;
                                Console.SetCursorPosition(BossX, BossY);
                                Console.Write(bIco);
                            }
                            else
                            {
                                Console.SetCursorPosition(cX, cY);
                                Console.ForegroundColor = cColor;
                                Console.Write(cIco);

                            }

                            Console.ForegroundColor = pColor;
                            Console.SetCursorPosition(pX, pY);
                            Console.Write("P");

                            char input2 = Console.ReadKey(true).KeyChar;
                            Console.SetCursorPosition(pX, pY);
                            Console.Write(" ");

                            if (isFight)
                            {
                                if (input2 == 'j' || input2 == 'J')
                                {
                                    if (pHp <= 0)
                                    {
                                        nowScreenId = 3;
                                        break;
                                    }
                                    else if (bHp <= 0)
                                    {
                                        Console.SetCursorPosition(BossX, BossY);
                                        Console.Write("  ");
                                        isFight = false;
                                    }
                                    else
                                    {
                                        #region 玩家攻击
                                        Random r = new Random();
                                        int pAtk = r.Next(pAtkMin, pAtkMax + 1);
                                        bHp -= pAtk;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(2, height - 4);
                                        Console.Write("                                       ");
                                        Console.SetCursorPosition(2, height - 4);
                                        Console.Write("你对boss造成了{0}伤害，boss剩余血量：{1}", pAtk, bHp);
                                        #endregion

                                        #region boss攻击
                                        if (bHp > 0)
                                        {
                                            int bAtk = r.Next(bAtkMin, bAtkMax + 1);
                                            pHp -= bAtk;
                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.SetCursorPosition(2, height - 3);
                                            Console.Write("                                       ");

                                            if (pHp <= 0)
                                            {
                                                Console.SetCursorPosition(2, height - 3);
                                                Console.Write("很遗憾~ 玩家卒~");
                                                str = "你输了！";
                                            }
                                            else
                                            {
                                                Console.SetCursorPosition(2, height - 3);
                                                Console.Write("boss对你造成{0}伤害，玩家剩余血量：{1}", bAtk, pHp);
                                            }
                                        }
                                        #endregion

                                        #region 胜利
                                        else
                                        {
                                            Console.SetCursorPosition(2, height - 5);
                                            Console.Write("                                       ");
                                            Console.SetCursorPosition(2, height - 4);
                                            Console.Write("                                       ");
                                            Console.SetCursorPosition(2, height - 3);
                                            Console.Write("                                       ");
                                            Console.SetCursorPosition(2, height - 5);
                                            Console.Write("恭喜你！胜利了！");
                                        }
                                        #endregion
                                    }  
                                }
                            }
                            else
                            {
                                switch (input2)
                                {
                                    #region 玩家移动
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
                                        else if (pY == cY && pX == cX && bHp <= 0)
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
                                        else if (pY == cY && pX == cX && bHp <= 0)
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
                                        else if (pY == cY && pX == cX && bHp <= 0)
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
                                        else if (pY == cY && pX == cX && bHp <= 0)
                                        {
                                            pX--;
                                        }
                                            break;
                                    #endregion

                                    #region 玩家战斗
                                    case 'j':
                                    case 'J':
                                        if ((pX == BossX && pY == BossY - 1 ||
                                            pX == BossX && pY == BossY + 1 ||
                                            pY == BossY && pX == BossX - 1 ||
                                            pY == BossY && pX == BossX + 1) && bHp > 0)
                                        {
                                            isFight = true;
                                            Console.SetCursorPosition(2, height - 5);
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.Write("开始战斗，按J继续");
                                            Console.SetCursorPosition(2, height - 4);
                                            Console.Write("玩家血量{0}", pHp);
                                            Console.SetCursorPosition(2, height - 3);
                                            Console.Write("Boss血量{0}", bHp);
                                        }
                                        else if ((pX == cX && pY == cY - 1 ||
                                            pX == cX && pY == cY + 1 ||
                                            pY == cY && pX == cX - 1 ||
                                            pY == cY && pX == cX + 1) && bHp <= 0)
                                        {
                                            nowScreenId = 3;
                                            isOver = true;
                                            str = "你赢了！";
                                        }
                                            break;
                                    #endregion

                                }
                            }
                            if (isOver)
                            {
                                break;
                            } 
                        }
                        
                        break;

                    #endregion

                    #region 结束场景

                    case 3:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(width / 2 - 4, 5);
                        Console.Write("GameOver");

                        Console.SetCursorPosition(width / 2 - 4, 7);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(str);

                        int nowSelectId2 = 1;
                        bool nowExit2 = false;
                        while (true)
                        {
                            Console.ForegroundColor = nowSelectId2 == 1 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.SetCursorPosition(width / 2 - 6, 13);
                            Console.Write("回到开始界面");
                            Console.ForegroundColor = nowSelectId2 == 2 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.SetCursorPosition(width / 2 - 4, 15);
                            Console.Write("结束游戏");

                            char input = Console.ReadKey(true).KeyChar;
                            switch (input)
                            {
                                case 'w':
                                case 'W':
                                    nowSelectId2 -= 1;
                                    if (nowSelectId2 < 1)
                                    {
                                        nowSelectId2 = 1;
                                    }
                                    break;
                                case 's':
                                case 'S':
                                    nowSelectId2 += 1;
                                    if (nowSelectId2 > 2)
                                    {
                                        nowSelectId2 = 2;
                                    }
                                    break;
                                case 'j':
                                case 'J':
                                    switch (nowSelectId2)
                                    {
                                        case 1:
                                            nowScreenId = 1;
                                            nowExit2 = true;
                                            break;
                                        case 2:
                                            Console.Clear();
                                            Environment.Exit(0);
                                            break;
                                    }
                                    break;
                            }
                            if (nowExit2)
                            {
                                break;
                            }

                        }
                        break;

                    #endregion

                }
            }
            #endregion

        }
    }
}
