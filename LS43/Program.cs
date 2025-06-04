namespace LS43
{
    internal class Program
    {
        #region 类
        class Person
        {
            public string name;
            public int age;
            // 构造函数
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }
        #endregion
        static void Main(string[] args)
        {
            #region 实例化对象

            Person p1 = new Person("张三", 18);
            Console.WriteLine("我叫{0}，今年{1}岁", p1.name, p1.age);

            #endregion
        }
    }
}
