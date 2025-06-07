using LS68.G;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS68.GS
{
    class BeginScence : BeginEndScence
    {
        public BeginScence()
        {
            strTitle = "贪吃蛇";
            strOne = "开始游戏";
        }
        public override void EnterJDoSomething()
        {
            if (nowSelectId == 0)
            {
                Game.ChangeScence(E_ScenceType.Game);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
