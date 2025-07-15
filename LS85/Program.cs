namespace LS85
{
    #region 协变、逆变
    // 协变：允许隐式转换，里氏替换
    // 逆变：父类可以装子类，但子类不能装父类

    // 协变和逆变用于修饰泛型，只有泛型接口和泛型委托可以使用
    // 协变：out
    // 逆变：in
    #endregion

    #region 作用
    // 返回值和参数
    // 用out修饰的泛型，只能作为返回值，不能作为参数
    delegate T Test<out T>();

    // 用in修饰的泛型，只能作为参数，不能作为返回值
    delegate void Test2<in T>(T t);

    // 结合里氏替换原则
    class Father
    {

    }
    class Son : Father
    {

    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            // 协变
            Test<Son> test = () =>
            {
                return new Son();
            };
            Test<Father> test2 = test;

            // 逆变
            Test2<Father> test3 = (f) =>
            {

            };
            Test2<Son> test4 = test3;
        }
    }
}
