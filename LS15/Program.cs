namespace LS15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 三目运算符
            // 语法
            // 条件 ? 表达式1 : 表达式2 （两个表达式的类型一致）
            int a = 10;
            string result = a > 0 ? "正数" : "负数";
            Console.WriteLine(result);
            #endregion
        }
    }
}
