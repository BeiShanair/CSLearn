using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LS68.GS
{
    abstract class GameObject : IDraw
    {
        public Postition pos;
        // 可以继承接口后，把接口中的行为进行抽象
        public abstract void Draw();
    }
}
