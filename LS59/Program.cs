namespace LS59
{
    #region 多态
    //多态：同一个行为具有多个不同表现形式
    #endregion

    #region 解决的问题
    class Father
    {
        public void Speak()
        {
            Console.WriteLine("父亲说话");
        }
    }
    class Son : Father
    {
        public new void Speak()
        {
            Console.WriteLine("儿子说话");
        }
    }
    #endregion

    #region 实现
    class GameObject
    {
        public string name;
        public GameObject(string name)
        {
            this.name = name;
        }
        // 虚函数
        public virtual void Speak()
        {
            Console.WriteLine("对象说话");
        }
    }
    class Player : GameObject
    {
        public Player(string name) : base(name)
        {

        }
        // 重写父类的虚函数
        public override void Speak()
        {
            // 用base调用父类的函数
            base.Speak();
            Console.WriteLine("玩家说话");
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Father f = new Son();
            f.Speak();// 调用的是Father中的Speak方法

            GameObject g = new Player("123");
            g.Speak();// 调用的是Player中的Speak方法
        }
    }
}
