using Game2;

#region 命名空间
namespace Game
{
    class GameObject
    {

    }
}

namespace Game2
{
    class Game123
    {

    }
}
#endregion
namespace LS63
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 其他命名空间的类要指明出处，或者直接使用using
            Game.GameObject o = new Game.GameObject();
            Game123 g = new Game123();
        }
    }
}
