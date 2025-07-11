namespace LS83
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region lambda表达式
            // lambda表达式可以理解为匿名函数的简写
            // 基本语法
            // (参数列表) => {函数体}

            #endregion

            #region 使用
            // 无参无返
            Action action = () => 
            { 
                Console.WriteLine("hello"); 
            };
            action();

            // 无参有返
            Func<int> func = () =>
            {
                Console.WriteLine("hello");
                return 0;
            };
            func();

            // 有参无返
            Action<int> action2 = (int a) =>
            {
                Console.WriteLine("hello,{0}", a);
            };
            action2(1);

            // 有参有返
            Func<int, int, int> func2 = (int a, int b) =>
            {
                Console.WriteLine("hello");
                return a + b;
            };
            Console.WriteLine(func2(1, 2));

            // 缺点与匿名函数一样
            #endregion

            
        }
    }
    #region 闭包
    // 闭包是指一个函数能够访问并操作其词法作用域外部的变量
    // 即内层函数可以引用外层函数的局部变量，即便外层函数执行完后，这些变量依然可以被内层函数访问
    // 但是该变量不是变量创建时的值，而是最终经过一系列操作后形成的最终值

    class Test
    {
        public event Action a;
        public Test()
        {
            int value = 10;
            // 闭包
            a = () =>
            {
                Console.WriteLine(value);
            };
        }
    }
    #endregion
}
