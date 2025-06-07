using LS68.M;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS68.GS
{
    enum EMoveDir
    {
        Up, Down, Left, Right
    }
    class Snake : IDraw
    {
        SnackBody[] bodys;
        int nowLength = 0;
        EMoveDir dir;

        public Snake(int x, int y)
        {
            bodys = new SnackBody[200];
            bodys[0] = new SnackBody(ESnakeBodyType.Head, x, y);
            nowLength = 1;

            dir = EMoveDir.Right;
        }
        public void Draw()
        {
            for (int i = 0; i < nowLength; i++)
            {
                bodys[i].Draw();
            }
        }

        public void Move()
        {
            SnackBody lastBody = bodys[nowLength - 1];
            Console.SetCursorPosition(lastBody.pos.x, lastBody.pos.y);
            Console.Write("  ");

            for (int i = nowLength - 1; i > 0; i--)
            {
                bodys[i].pos = bodys[i - 1].pos;
            }

            switch (dir)
            {
                case EMoveDir.Up:
                    bodys[0].pos.y--;
                    break;
                case EMoveDir.Down:
                    bodys[0].pos.y++;
                    break;
                case EMoveDir.Left:
                    bodys[0].pos.x-=2;
                    break;
                case EMoveDir.Right:
                    bodys[0].pos.x+=2;
                    break;
            }
        }

        public void ChangeDir(EMoveDir dir)
        {
            if (dir == this.dir ||
                nowLength > 1 &&
                (this.dir == EMoveDir.Left && dir == EMoveDir.Right ||
                 this.dir == EMoveDir.Right && dir == EMoveDir.Left ||
                 this.dir == EMoveDir.Up && dir == EMoveDir.Down ||
                 this.dir == EMoveDir.Down && dir == EMoveDir.Up))
            {
                return;
            }
            this.dir = dir;
        }

        public bool CheckEnd(Map map)
        {
            for (int i = 0; i < map.walls.Length; i++)
            {
                if (bodys[0].pos == map.walls[i].pos)
                {
                    return true;
                }
            }

            for (int i = 1; i < nowLength; i++)
            {
                if (bodys[0].pos == bodys[i].pos)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckSamePos(Postition p)
        {
            for (int i = 0; i < nowLength; i++)
            {
                if (bodys[i].pos == p)
                {
                    return true;
                }
            }
            return false;
        }

        public void CheckEatFood(Food food)
        {
            if (bodys[0].pos == food.pos)
            {
                food.RandomPos(this);
                Grow();
            }
        }

        private void Grow()
        {
            SnackBody frontBody = bodys[nowLength - 1];
            bodys[nowLength] = new SnackBody(ESnakeBodyType.Body, frontBody.pos.x, frontBody.pos.y);
            nowLength++;
        }
    }
}
