namespace LS74
{
    #region 泛型约束
    // 泛型约束让泛型的类型有一定的约束
    // where T : class 引用类型
    // where T : struct 值类型
    // where T : new() 公共无参构造函数
    // where T : <基类> 类本身或者某个类
    // where T : <接口> 接口的派生类型
    // where T : U 其他泛型或者派生类型

    #region struct
    class Test1<T> where T : struct
    {
        public T value;
        public void TestFun<K>() where K : struct
        {
            K k = default(K);
        }
    }

    #endregion

    #region class
    class Test2<T> where T : class
    {
        public T value;
        public void TestFun<K>() where K : class
        {
            K k = null;
        }
    }
    #endregion

    #region new()
    class Test1
    {
        
    }
    class Test3<T> where T : new()
    {
        public T value;
        public void TestFun<K>() where K : new()
        {
            K k = new K();
        }
    }

    #endregion

    #region 类约束
    class Test2 : Test1
    {

    }
    class Test4<T> where T : Test1
    {
        public T value;
        public void TestFun<K>() where K : Test1
        {
            K k = default(K);
        }
    }
    #endregion

    #region 接口约束
    interface ITest
    {

    }
    class Test3 : ITest
    {

    }
    class Test5<T> where T : ITest
    {
        public T value;
        public void TestFun<K>() where K : ITest
        {
            K k = default(K);
        }
    }
    #endregion

    #region 其他泛型约束

    class Test6<T, K> where T : K
    {
        public T value;
        public void TestFun<T, K>() where T : K
        {
            
        }
    }

    #endregion
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Test1<int> test1 = new Test1<int>();
            test1.value = 1;
            test1.TestFun<double>();
            
            Test2<string> test2 = new Test2<string>();
            test2.value = "1";
            test2.TestFun<string>();

            Test3<Test1> test3 = new Test3<Test1>();
            test3.value = new Test1();

            Test4<Test2> test4 = new Test4<Test2>();
            test4.value = new Test2();

            Test5<Test3> test5 = new Test5<Test3>();
            test5.value = new Test3();

            Test6<Test3, ITest> test6 = new Test6<Test3, ITest>();
            test6.value = new Test3();
        }
    }
}
