namespace LS80
{
    #region 委托
    // 委托是函数的容器，可以理解为表示函数方法的变量类型
    // 用来储存、传递函数方法

    // 基本语法
    // 访问修饰符 delegate 返回类型 委托名称(参数列表);
    #endregion

    #region 定义委托
    // 访问修饰符可以省略，默认为public
    // 这里只是定义了规则，没有使用
    public delegate void MyDelegate(string str);
    // 委托不能重名

    // 返回值为int，参数为int的委托
    public delegate int MyDelegate2(int a, int b);

    public delegate void MyDelegate3();

    class Test
    {
        // 委托可以在类中使用
        public MyDelegate myDelegate;
        public MyDelegate2 myDelegate2;

        public void TestMethod(MyDelegate myDelegate, MyDelegate2 myDelegate2)
        {
            // 可以先处理一些逻辑
            // 再调用委托
            int i = 1;
            i *= 2;
            i += 3;
            // myDelegate2(i, 2);
        }
    }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 使用委托
            MyDelegate myDelegate = new MyDelegate(SayHello);
            myDelegate("Hello World");

            // 也可以直接指向函数，但不要写括号
            MyDelegate2 add = Add;
            Console.WriteLine(add(1, 2));
            #endregion

            #region 委托可以存多个函数
            MyDelegate3 myDelegate3 = Say;
            myDelegate3 += Say;
            myDelegate3(); // 调用两次函数

            #endregion

            #region 系统定义好的委托
            // Action<T> 委托，无返回值，参数为T
            Action action = Say;
            action();

            // Func<T, TResult> 委托，有返回值，参数为T，返回值为TResult
            // Func<>有17个重载，可以指定参数个数和返回值类型
            Func<int, int, int> func = Add;
            #endregion
        }
        static void SayHello(string str)
        {
            Console.WriteLine(str);
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static void Say()
        {
            Console.WriteLine("Hello World");
        }
    }
}
