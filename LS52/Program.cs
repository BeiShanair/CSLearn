namespace LS52
{
    #region 运算符重载
    // 重新定义一些运算符的处理逻辑
    // 条件运算符重载需要成对出现，如重载<，那么必须重载>
    // 不可重载的运算符：|| && [] () . ?: =
    class Tools
    {
        public int x;
        public int y;

        // 运算符重载
        public static Tools operator +(Tools t1, Tools t2)
        {
            Tools t = new Tools();
            t.x = t1.x + t2.x;
            t.y = t1.y + t2.y;
            return t;
        }
        // 同一个运算符可以多次重载
        public static Tools operator +(Tools t1, int v)
        {
            Tools t = new Tools();
            t.x = t1.x + v;
            t.y = t1.y + v;
            return t;
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Tools tool = new Tools();
            tool.x = 10;
            tool.y = 20;
            Tools tool2 = new Tools();
            tool2.x = 30;
            tool2.y = 40;
            Tools tool3 = tool + tool2;
            Console.WriteLine(tool3.x);
            Console.WriteLine(tool3.y);

            Tools tool4 = tool + 100;
            Console.WriteLine(tool4.x);
            Console.WriteLine(tool4.y);
        }
    }
}
