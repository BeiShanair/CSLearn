namespace LS44
{
    internal class Program
    {
        enum E_Sex
        {
            Male,
            Female
        }
        #region 成员变量与访问修饰符
        class Person
        {
            // 成员变量
            public string name;
            public int age = 18;// 可以初始化赋值
            public E_Sex sex;
            Person friends; // 可以用这个类本身的类型（但不能实例化）
            // 访问修饰符
            // public 外部可访问
            // private （不写默认private） 外部不可访问，内部类可以访问
            // protected 外部不可访问，内部类和子类可以访问
        }
        #endregion
        static void Main(string[] args)
        {
            Person person = new Person();
            person.name = "张三";
            person.age = 18;
            person.sex = E_Sex.Male;
            Console.WriteLine("姓名：" + person.name);
        }
    }
}
