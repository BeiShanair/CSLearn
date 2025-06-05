namespace LS57
{
    class Father
    {

    }
    class Son : Father
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 万物之父
            // object是所有类型的基类
            // object类型可以存储任何类型的值，但存储的值需要装箱和拆箱
            Father f = new Son();
            if (f is Son)
            {
                Console.WriteLine("f is Son");
            }

            object o = new Son();
            object o2 = new Father();
            #endregion

            #region 装箱 拆箱
            // 装箱：将值类型转换为引用类型
            object o3 = 1;
            // 拆箱：将引用类型转换为值类型
            int i = (int)o3; // object转为其他类型要强转
            #endregion
        }
    }
}
