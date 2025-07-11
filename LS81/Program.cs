namespace LS81
{
    #region 事件
    // 事件是一种特殊的委托，基于委托存在
    // 事件是委托的安全包裹，让委托更具有安全性

    // 区别在于：
    // 不能在类外部赋值，也不能在类外调用
    #endregion

    #region 声明
    // 事件声明
    // 访问修饰符 event 委托类型 事件名称

    class Test
    {
        // 委托
        public Action fun;
        // 事件
        public event Action fun2;

        public Test()
        {
            fun = TestFun;
            fun();
            fun2 = TestFun;
            fun2();
        }

        private void TestFun()
        {
            Console.WriteLine("1");
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Test t = new Test();

            t.fun(); // 可以调用
            // t.fun2(); // 报错，事件不能在外部调用

            t.fun = null; // 委托可以在外部赋值
            // t.fun2 = null; // 报错，事件不能在外部赋值，但可以加减
        }
    }
}
