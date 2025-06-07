using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS68.GS
{
    struct Postition
    {
        public int x;
        public int y;

        public Postition(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // 重载运算符
        public static bool operator ==(Postition a, Postition b)
        {
            return a.x == b.x && a.y == b.y;
        }

        public static bool operator !=(Postition a, Postition b)
        {
            return !(a.x == b.x && a.y == b.y);
        }
    }
}
