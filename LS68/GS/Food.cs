using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS68.GS
{
    internal class Food : GameObject
    {
        public Food(int x, int y)
        {
            pos = new Postition(x, y);
        }
        public override void Draw()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("A");
        }
    }
}
