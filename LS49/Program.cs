namespace LS49
{
    internal class Program
    {
        class Test
        {
            #region 静态成员
            // 静态成员会在程序启动时被初始化，有单独的内存空间
            // 静态字段
            public static float PI = 3.1415926f;

            // 静态方法
            public static float CalCircle(float f)
            {
                return PI * f * f;
            }

            #endregion
        }
        static void Main(string[] args)
        {
            // 可以不实例化对象，来直接访问静态成员
            Console.WriteLine(Test.PI);
            Console.WriteLine(Test.CalCircle(5f));
        }
    }
}
