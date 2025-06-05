namespace LS56
{
    #region 继承中的构造函数

    class GameObject
    {
        //public GameObject()
        //{
        //    Console.WriteLine("游戏对象构造函数");
        //}
        public GameObject(int i)
        {
            Console.WriteLine("游戏对象构造函数");
        }
    }
    class Player : GameObject
    {
        // 通过base指定子类调用父类的构造函数
        public Player(int i): base(i)
        {
            Console.WriteLine("玩家构造函数");
        }
        public void PlayerAtk()
        {
            Console.WriteLine("玩家攻击");
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            // 子类构造函数调用时，会先调用父类的构造函数（无参构造函数，若无参构造函数被有参构造函数顶替，会报错）
            // 再调用自己的构造函数
            Player player = new Player(1);

        }
    }
}
