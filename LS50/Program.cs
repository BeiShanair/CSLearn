namespace LS50
{
    internal class Program
    {
        #region 静态类
        // 静态类只能包含静态成员，不能被实例化
        static class Math
        {
            public static float PI = 3.14f;
            public static float Sqrt(float x)
            {
                return x * x;
            }
        }
        #endregion

        #region 静态构造函数
        // 静态构造函数在类被第一次使用时调用，且只调用一次
        class Person
        {
            public string str = "123";

            static Person()
            {
                Console.WriteLine("静态构造函数被调用");
            }
        }
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.Sqrt(3));
            Person p = new Person();
            Console.WriteLine(p.str);
            Console.WriteLine(p.str);
            Console.WriteLine(p.str);
        }
    }
}
