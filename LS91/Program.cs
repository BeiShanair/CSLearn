namespace LS91
{
    class Person
    {
        private int money;
        public bool sex;
        public String Name
        {
            get;
            set;
        }
        public int Age
        {
            get; 
            set;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 特殊语法

            #region var
            // 隐式类型，可以用来表示任意类型的变量
            // 不能用在类中，只能用在方法中
            // var类型必须初始化
            var a = 1;
            var b = "hello";
            Console.WriteLine(a);
            Console.WriteLine(b);
            #endregion

            #region 设置对象初始值
            // 在声明对象时，直接用大括号的形式初始化公共成员变量和属性
            Person p = new Person { Name = "张三", Age = 18 };
            #endregion

            #region 设置集合初始值
            // 在声明集合对象是，可以用大括号初始化集合中的元素
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            List<Person> list2 = new List<Person> { 
                new Person { Name = "张三", Age = 18 }, 
                new Person { Name = "李四", Age = 19 }
            };

            Dictionary<string, int> dic = new Dictionary<string, int> { { "a", 1 }, { "b", 2 } };
            #endregion

            #region 匿名类型
            // var 变量可以声明为自定义的匿名类型
            var v = new { Name = "张三", Age = 18 };
            Console.WriteLine(v.Name);
            Console.WriteLine(v.Age);
            #endregion

            #region 可空类型
            // 值类型不能赋值为空
            // 但可以在类型后面加上?来表示可空类型
            int? i = null;
            // 判断是否为空
            if (i.HasValue)
            {
                Console.WriteLine(i.Value);
            }

            // 安全获取可空类型的值
            Console.WriteLine(i.GetValueOrDefault()); // 不填会返回这个类型的默认值
            Console.WriteLine(i.GetValueOrDefault(1)); // 填了会返回填的值
            
            object o = null;
            if (o != null)
            {
                Console.WriteLine(o.ToString());
            }
            o?.ToString(); // 安全调用，如果o为空，则不执行后面的代码
            #endregion

            #region 空合并操作符
            // 左边值 ?? 右边值
            // 如果左边值为空，则返回右边值
            // 如果左边值不为空，则返回左边值
            int? j = null;
            Console.WriteLine(j ?? 1);
            #endregion

            #region 内插字符串
            // $""
            string str = "hello";
            Console.WriteLine($"hello {str}");
            #endregion

            #region 单句逻辑简略写法
            if (true) Console.WriteLine("hello");
            for (int k = 0; k < 10; k++) Console.WriteLine(k);

            // 方法中可以用 => 来代替 return
            #endregion

            #endregion
        }
    }
}
