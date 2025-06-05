namespace LS60
{
    #region 抽象类和抽象方法
    // 抽象类，不能被实例化
    // 抽象类中可以包含抽象方法，也可以包含普通方法
    // 继承抽象类，子类必须实现抽象类中的所有抽象方法，否则子类也必须声明为抽象类
    abstract class Thing
    {
        public string name;
        // 抽象方法，没有方法体
        public abstract void Show();
    }

    class Water : Thing
    {
        // 实现抽象方法
        public override void Show()
        {
            Console.WriteLine("我是水");
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Thing t = new Water();
            t.Show();
        }
    }
}
