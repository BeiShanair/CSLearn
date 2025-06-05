namespace LS55
{
    #region 里氏替换
    // 里氏替换原则：子类对象能够替换其父类对象，并且程序运行结果不变
    class GameObject
    {

    }
    class Player : GameObject
    {
        public void PlayerAtk()
        {
            Console.WriteLine("玩家攻击");
        }
    }

    class Monster : GameObject
    {
        public void MonsterAtk()
        {
            Console.WriteLine("怪物攻击");
        }
    }

    class Boss : GameObject
    {
        public void BossAtk()
        {
            Console.WriteLine("Boss攻击");
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            // 父类装子类
            GameObject player = new Player();

            #region is as
            // is：判断对象是否为某个类的实例
            // as：将将对象转换为某个类的实例
            if (player is Player)
            {
                Player p = player as Player;
                p.PlayerAtk();
            }
            #endregion
        }
    }
}
