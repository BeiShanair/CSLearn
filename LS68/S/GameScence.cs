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
        public GameScence()
        {
            map = new Map();
        }
        public void Update()
        {
            map.Draw();

        }
    }
}
