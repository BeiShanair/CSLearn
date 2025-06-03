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

        #region 开始/结束场景内容
        static void BeginEndScreen(int width, int height, ref E_ScenceType scenceType)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(scenceType == E_ScenceType.Begin ? width / 2 - 3 : width / 2 - 4, 8);
            Console.Write(scenceType == E_ScenceType.Begin ? "飞行棋" : "游戏结束");

            int nowSelectId = 0;
            bool nowExit = false;
            while (true)
            {
                Console.SetCursorPosition(scenceType == E_ScenceType.Begin ? width / 2 - 4 : width / 2 - 5, 13);
                Console.ForegroundColor = nowSelectId == 0 ? ConsoleColor.Red : ConsoleColor.White;
                Console.Write(scenceType == E_ScenceType.Begin ? "开始游戏" : "回到主菜单");
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
                            scenceType = scenceType == E_ScenceType.Begin ? E_ScenceType.Game : E_ScenceType.Begin;
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

        #region 格子
        enum E_GridType
        {
            Normal,
            Boom,
            Pause,
            Tunnel
        }

        struct Vector2
        {
            public int x;
            public int y;
            public Vector2(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        struct Grid
        {
            public E_GridType type;
            public Vector2 pos;
            public Grid(E_GridType type, int x, int y)
            {
                this.type = type;
                this.pos.x = x;
                this.pos.y = y;
            }

            // 绘制方法
            public void Draw()
            {
                Console.SetCursorPosition(pos.x, pos.y);
                switch (type)
                {
                    case E_GridType.Normal:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("B");
                        break;
                    case E_GridType.Boom:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("S");
                        break;
                    case E_GridType.Pause:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("T");
                        break;
                    case E_GridType.Tunnel:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Q");
                        break;
                }
            }
        }




        #endregion

        #region 地图
        struct Map
        {
            public Grid[] grids;
            public Map(int x, int y, int num)
            {
                grids = new Grid[num];
                int indexX = 0;
                int indexY = 0;
                int stepNum = 2;
                Random random = new Random();
                int randomNum;

                for (int i = 0; i < num; i++)
                {
                    randomNum = random.Next(0, 101);

                    if (randomNum < 85 || i == 0 || i == num - 1)
                    {
                        grids[i].type = E_GridType.Normal;
                    }
                    else if (randomNum >= 85 && randomNum < 90)
                    {
                        grids[i].type = E_GridType.Boom;
                    }
                    else if (randomNum >= 90 && randomNum < 95)
                    {
                        grids[i].type = E_GridType.Pause;
                    }
                    else
                    {
                        grids[i].type = E_GridType.Tunnel;
                    }
                    grids[i].pos = new Vector2(x, y);

                    if (indexX == 10)
                    {
                        y += 1;
                        indexY++;
                        if (indexY == 2)
                        {
                            indexX = 0;
                            indexY = 0;
                            stepNum = -stepNum;
                        }
                    }
                    else
                    {
                        x += stepNum;
                        indexX++;
                    }
                }
            }

            public void Draw()
            {
                for (int i = 0; i < grids.Length; i++)
                {
                    grids[i].Draw();
                }
            }
        }
        #endregion

        #region 玩家
        enum E_PlayerType
        {
            Player,
            Computer
        }

        struct Player
        {
            public E_PlayerType type;
            public int nowIndex;
            // 是否暂停
            public bool isPause;
            public Player(int index, E_PlayerType type)
            {
                this.type = type;
                this.nowIndex = index;
                this.isPause = false;
            }

            public void Draw(Map info)
            {
                Grid grid = info.grids[nowIndex];
                Console.SetCursorPosition(grid.pos.x, grid.pos.y);
                switch (type)
                {
                    case E_PlayerType.Player:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("P");
                        break;
                    case E_PlayerType.Computer:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("C");
                        break;
                }
            }
        }
        #endregion

        #region 绘制玩家
        static void DrawPlayer(Player player, Player computer, Map map)
        {
            if (player.nowIndex == computer.nowIndex)
            {
                Grid grid = map.grids[player.nowIndex];
                Console.SetCursorPosition(grid.pos.x, grid.pos.y);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("R");
            }
            else
            {
                player.Draw(map);
                computer.Draw(map);
            }
        }
        #endregion

        #region 擦除函数
        static void Clean(int h)
        {
            Console.SetCursorPosition(2, h - 5);
            Console.Write("                                 ");
            Console.SetCursorPosition(2, h - 4);
            Console.Write("                                 ");
            Console.SetCursorPosition(2, h - 3);
            Console.Write("                                 ");
            Console.SetCursorPosition(2, h - 2);
            Console.Write("                                 ");
        }
        #endregion

        #region 扔骰子
        static bool ThrowDice(int w, int h, ref Player player, ref Player player2, Map map)
        {
            Clean(h);
            Console.ForegroundColor = player.type == E_PlayerType.Player ? ConsoleColor.Cyan : ConsoleColor.Magenta;
            
            if (player.isPause)
            {
                player.isPause = false;
                Console.SetCursorPosition(2, h - 5);
                Console.Write("{0}暂停一回合", player.type == E_PlayerType.Player ? "你" : "电脑"); 
                return false;
            }
            Random r = new Random();
            int randomNum = r.Next(1, 7);

            Console.SetCursorPosition(2, h - 5);
            Console.Write("{0}扔出的点数为{1}", player.type == E_PlayerType.Player ? "你" : "电脑", randomNum);

            player.nowIndex += randomNum;
            if (player.nowIndex >= map.grids.Length - 1)
            {
                player.nowIndex = map.grids.Length - 1;
                Console.SetCursorPosition(2, h - 4);
                if (player.type == E_PlayerType.Player)
                {
                    Console.Write("恭喜你，你赢了！");
                }
                else
                {
                    Console.Write("很遗憾，你输了！");
                }
                Console.SetCursorPosition(2, h - 3);
                Console.Write("按任意键结束游戏");
                return true;
            }
            else
            {
                Grid grid = map.grids[player.nowIndex];

                switch (grid.type)
                {
                    case E_GridType.Normal:
                        Console.SetCursorPosition(2, h - 4);
                        Console.Write("{0}达到了安全位置", player.type == E_PlayerType.Player ? "你" : "电脑");
                        Console.SetCursorPosition(2, h - 3);
                        Console.Write("{0}开始扔骰子", player.type == E_PlayerType.Computer ? "你" : "电脑");
                        break;
                    case E_GridType.Boom:
                        player.nowIndex -= 5;
                        if (player.nowIndex < 0)
                        {
                            player.nowIndex = 0;
                        }
                        Console.SetCursorPosition(2, h - 4);
                        Console.Write("{0}踩到炸弹，退5格", player.type == E_PlayerType.Player ? "你" : "电脑");
                        Console.SetCursorPosition(2, h - 3);
                        Console.Write("{0}开始扔骰子", player.type == E_PlayerType.Computer ? "你" : "电脑");
                        break;
                    case E_GridType.Pause:
                        // 下回合暂停
                        player.isPause = true;
                        Console.SetCursorPosition(2, h - 4);
                        Console.Write("{0}踩到暂停，暂停一回合", player.type == E_PlayerType.Player ? "你" : "电脑");
                        break;
                    case E_GridType.Tunnel:
                        Console.SetCursorPosition(2, h - 4);
                        Console.Write("{0}踩到了时空隧道", player.type == E_PlayerType.Player ? "你" : "电脑");
                        randomNum = r.Next(1, 91);
                        if (randomNum <= 30)
                        {
                            player.nowIndex -= 5;
                            if (player.nowIndex < 0)
                            {
                                player.nowIndex = 0;
                            }
                            Console.SetCursorPosition(2, h - 3);
                            Console.Write("触发倒退5格");
                        }
                        else if (randomNum <= 60)
                        {
                            player.isPause = true;
                            Console.Write("触发暂停一回合");
                        }
                        else
                        {
                            int temp = player.nowIndex;
                            player.nowIndex = player2.nowIndex;
                            player2.nowIndex = temp;
                            Console.Write("触发交换位置");
                        }
                        
                        
                        break;
                }
            }
            return false;
        }
        #endregion

        #region 场景


        static void GameScreen(int width, int height, ref E_ScenceType scenceType)
        {
            // 画墙
            DrawWall(width, height);

            // 画地图
            Map map = new Map(15, 3, 90);
            map.Draw();

            // 画玩家
            Player player = new Player(0, E_PlayerType.Player);
            Player computer = new Player(0, E_PlayerType.Computer);
            DrawPlayer(player, computer, map);

            bool isGameOver = false;
            while (true)
            {
                Console.ReadKey(true);
                isGameOver = ThrowDice(width, height, ref player, ref computer, map);
                map.Draw();
                DrawPlayer(player, computer, map);
                if (isGameOver)
                {
                    Console.ReadKey(true);
                    scenceType = E_ScenceType.End;
                    break;
                }

                Console.ReadKey(true);
                isGameOver = ThrowDice(width, height, ref computer, ref player, map);
                map.Draw();
                DrawPlayer(player, computer, map);
                if (isGameOver)
                {
                    Console.ReadKey(true);
                    scenceType = E_ScenceType.End;
                    break;
                }
            }
        }
        #endregion

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
                        BeginEndScreen(w, h, ref nowScenceType);
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
                        BeginEndScreen(w, h, ref nowScenceType);
                        break;
                    #endregion
                }
            }
            #endregion
        }
    }
}
