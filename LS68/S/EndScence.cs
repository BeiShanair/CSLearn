using LS68.G;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS68.GS
{
    class EndScence : BeginEndScence
    {
        public EndScence()
        {
            strTitle = "游戏结束";
            strOne = "回到开始界面";
        }
        public override void EnterJDoSomething()
        {
            if (nowSelectId == 0)
            {
                Game.ChangeScence(E_ScenceType.Begin);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
