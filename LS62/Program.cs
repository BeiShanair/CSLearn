namespace LS62
{
    #region 密封方法
    // 让方法不能再被重写
    abstract class Animal
    {
        public string name;
        public abstract void Eat();
        public virtual void Speak()
        {
            Console.WriteLine("动物在说话");
        }
    }
    class Person : Animal
    {
        // 用sealed方法修饰的方法不能被重写
        public sealed override void Eat()
        {
            
        }
        public override void Speak()
        {
            Console.WriteLine("人在说话");
        }
    }

    class OtherPerson : Person
    {
        // 不能重写
        //public override void Eat()
        //{

        //}
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Person();
            a.Speak();
        }
    }
}
