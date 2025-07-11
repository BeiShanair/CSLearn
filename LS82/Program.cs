namespace LS82
{
    class Test
    {
        public Action a;
        // 作为参数传递
        public void Do(int a, Action fun)
        {
            Console.WriteLine(a);
            fun();
        }

        // 作为返回值
        public Action GetFun()
        {
            return delegate()
            {
                Console.WriteLine("匿名函数");
            };
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 匿名函数
            // 匿名函数是没有名称的函数
            // 使用上主要配合委托和事件
            #endregion

            #region 基本语法
            // delegate (参数列表) {函数体}
            // 什么时候使用？
            // 函数中传递委托参数时、委托或事件赋值时
            #endregion

            #region 使用
            // 无参无返
            Action a = delegate ()
            {
                Console.WriteLine("匿名函数");
            };
            a();

            // 有参无返
            Action<string> b = delegate (string str)
            {
                Console.WriteLine(str); 
            };
            b("匿名函数");

            // 有参有返
            Func<int, int, int> c = delegate (int a, int b)
            {
                return a + b; 
            };
            Console.WriteLine(c(1, 2));

            // 无参有返
            Func<int> d = delegate ()
            {
                return 1; 
            };
            Console.WriteLine(d());


            // 作为参数传递
            Test t = new Test();
            t.Do(1, delegate ()
            {
                Console.WriteLine("匿名函数");
            });

            // 作为返回值
            t.GetFun()();
            #endregion

            #region 匿名函数的缺点
            // 添加的到委托或者事件中后，没有名字记录，无法单独以此
            #endregion
        }
    }
}
