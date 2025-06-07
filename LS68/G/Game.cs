using LS68.GS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS68.G
{
    #region 场景类型
    enum E_ScenceType
    {
        Begin,
        Game,
        End
    }
    #endregion

    class Game
    {
        // 窗口大小
        public const int width = 80;
        public const int height = 20;

        // 当前场景
        public static IScenceUpdate nowScence;

        public Game()
        {
            // 初始化窗口
            Console.CursorVisible = false;
            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);

            ChangeScence(E_ScenceType.Begin);
        }

        public void Start()
        {
            while (true)
            {
                if (nowScence != null)
                {
                    nowScence.Update();
                }
            }
        }

        public static void ChangeScence(E_ScenceType type)
        {
            Console.Clear();
            switch (type)
            {
                case E_ScenceType.Begin:
                    nowScence = new BeginScence();
                    break;
                case E_ScenceType.Game:
                    nowScence = new GameScence();
                    break;
                case E_ScenceType.End:
                    nowScence = new EndScence();
                    break;
            }
        }
    }
}
