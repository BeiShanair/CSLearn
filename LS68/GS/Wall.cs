using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS68.GS
{
    class Wall : GameObject
    {
        public Wall(int x, int y)
        {
            pos = new Postition(x, y);
        }
        public override void Draw()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("■");
        }
    }
}
