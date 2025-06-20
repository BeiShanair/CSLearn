namespace LS73
{
    #region 泛型
    // 泛型实现了类型参数化，达到代码重用
    // 泛型类、泛型方法、泛型接口等等

    #region 泛型类
    class GenericClass<T>
    {
        public T value;
    }

    #endregion

    #region 泛型接口
    interface IGenericInterface<T>
    {
        T Value { get; set; }
    }

    class TestClass : IGenericInterface<int>
    {
        public int Value { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
    }
    #endregion

    #region 泛型方法
    class GenericMethod
    {
        public void Show<T>(T value)
        {
            Console.WriteLine(value);
        }
    }

    #endregion

    #region 泛型类的泛型方法
    class GenericClassTest<T>
    {
        public T value;
        public void Show<V>(V value)
        {
            Console.WriteLine(value);
        }
    }
    #endregion
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericClass<int> gc = new GenericClass<int>();
            gc.value = 10;
            Console.WriteLine(gc.value);

            GenericClass<string> gc1 = new GenericClass<string>();
            gc1.value = "hello";
            Console.WriteLine(gc1.value);

            GenericMethod gm = new GenericMethod();
            gm.Show<int>(10); // 尖括号里的东西可以省略，编译器会自动判断
            gm.Show<string>("hello");

            GenericClassTest<int> gct = new GenericClassTest<int>();
            gct.Show<string>("hello");
            gct.value = 10;
            Console.WriteLine(gct.value);
        }
    }
}
