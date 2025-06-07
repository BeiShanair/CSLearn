using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS68.GS
{
    enum ESnakeBodyType
    {
        Head,
        Body
    }
    class SnackBody : GameObject
    {
        private ESnakeBodyType type;
        public SnackBody(ESnakeBodyType type, int x, int y)
        {
            this.type = type;
            this.pos = new Postition(x, y);
        }
        public override void Draw()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.ForegroundColor = type == ESnakeBodyType.Head ? ConsoleColor.Yellow : ConsoleColor.Green;
            Console.Write(type == ESnakeBodyType.Head ? "●" : "○");
        }
    }
}
