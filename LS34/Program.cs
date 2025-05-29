namespace LS34
{
    internal class Program
    {
        #region 函数
        #region 基本概念
        // 函数：一段可重复使用的代码块，用于执行特定的任务
        // 函数的声明：访问修饰符 返回类型 函数名(参数列表)
        // 函数写在class语句块中，或者是struct语句块中
        #endregion

        #region 语法
        static int Add(int a, int b)
        {
            return a + b;
        }
        // 函数分为有参有返、无参有返、有参无返、无参无返
        #endregion
        #endregion
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int c = Add(a, b);
            Console.WriteLine("a + b = " + c);
        }
    }
}
