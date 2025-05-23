namespace LS13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 逻辑运算符

            #region 与
            // &&
            bool a = true;
            bool b = false;
            bool c = a && b;
            Console.WriteLine(c);
            #endregion

            #region 或
            // ||
            bool d = a || b;
            Console.WriteLine(d);
            #endregion

            #region 非
            // !
            bool e = !a;
            Console.WriteLine(e);
            #endregion

            #region 优先级
            // 非的运算优先级最高，其次是与，最后是或，且都高于算数运算符
            bool f = a && !b;
            #endregion

            #region 短路规则
            // 与运算符，只要有一个为假，结果就为假，后面的不再计算
            // 或运算符，只要有一个为真，结果就为真，后面的不再计算
            #endregion
            #endregion
        }
    }
}
