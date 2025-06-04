namespace LS47
{
    internal class Program
    {
        class Person
        {
            #region 成员属性
            // 保护成员变量
            // 为成员属性的获取和赋值添加逻辑处理
            private int age;
            private string name;
            private int money;

            public string Name
            {
                get
                {
                    // 可以获取的内容
                    return name;
                }
                set
                {
                    // value关键字，表示传入的值
                    name = value;
                }
            }

            public int Money
            {
                get
                {
                    // 可以进行加密解密
                    return money - 5;
                }
                set
                {
                    if (value < 0)
                    {
                        Console.WriteLine("钱不能为负数");
                        Console.WriteLine("已设置为0");
                        money = 0;
                    }
                    else
                    {
                        money = value + 5;
                    }
                }
            }

            // get和set可以加访问修饰符
            public int Age
            {
                get { return age; }
                private set { age = value; }  // 私有set，外部无法修改
            }

            // 自动属性
            // 可以不声明成员变量，直接用属性来代表某个成员变量
            public string Address 
            { get; private set; }

            #endregion
        }
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "张三"; // 执行set
            Console.WriteLine(person.Name); // 执行get

            Person person1 = new Person();
            person1.Money = 100; // 执行set
            Console.WriteLine(person1.Money); // 执行get
        }
    }
}
