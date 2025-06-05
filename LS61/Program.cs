namespace LS61
{
    #region 接口
    // 接口不包含成员变量
    // 只包含方法、属性、事件、索引器
    // 成员不能被实现
    // 接口可以不写访问修饰符，不能是私有的
    // 接口继承接口

    interface IFly
    {
        // 方法
        void Fly();
        string Name
        {
            get;
            set;
        }
        int this[int index]
        {
            get;
            set;
        }
        event Action Event;
    }

    // 类继承
    class Bird : IFly
    {
        public int this[int index] 
        { 
            get
            {
                return 0;
            }
            set
            {

            }
        }

        public string Name 
        {
            get
            {
                return "Bird";
            }
            set
            {

            }
        }

        public event Action Event;

        // 可以为接口中的方法加上virtual关键字，让子类也能重写
        public virtual void Fly()
        {
            Console.WriteLine("Bird fly");
        }
    }
    #endregion

    #region 显式实现接口
    interface IAtk
    {
        void Atk();
    }
    interface ISuperAtk
    {
        void Atk();
    }

    class Player : IAtk, ISuperAtk
    {
        // 显式实现
        void IAtk.Atk()
        {
            Console.WriteLine("普通攻击");
        }
        void ISuperAtk.Atk()
        {
            Console.WriteLine("超级攻击");
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            IFly f = new Bird();
            Console.WriteLine(f.Name);

            Player p = new Player();
            (p as IAtk).Atk(); // 调用接口方法要将其进行转换
            (p as ISuperAtk).Atk();
        }
    }
}
