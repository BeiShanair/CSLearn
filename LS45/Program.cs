namespace LS45
{
    internal class Program
    {
        #region 成员方法
        class Person
        {
            public string name;
            public int age;

            // 成员方法
            public void Speak()
            {
                Console.WriteLine("我叫{0}，今年{1}岁", name, age);
            }
        }
        #endregion
        static void Main(string[] args)
        {
            Person person = new Person();
            person.name = "张三";
            person.age = 20;
            person.Speak();
        }
    }
}
