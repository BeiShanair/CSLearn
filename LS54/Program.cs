namespace LS54
{
    #region 继承
    // 子类继承父类，子类只能继承一个父类，子类可以继承父类的父类
    class Person
    {
        public string name;
        public string sex;
    }
    class Stuedent : Person
    {
        public int num;
        public void Speak()
        {
            Console.WriteLine("我是{0}，{1}，我的学号是{2}", name, sex, num);
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Stuedent s = new Stuedent();
            s.name = "张三";
            s.sex = "男";
            s.num = 1001;
            s.Speak();
        }
    }
}
