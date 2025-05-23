namespace LS14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 位运算符
            //按位与运算符（&）
            int a = 5;
            int b = 3;
            Console.WriteLine(a & b);

            //按位或运算符（|）
            Console.WriteLine(a | b);

            //按位异或运算符（^）
            Console.WriteLine(a ^ b);

            //按位取反运算符（~）
            Console.WriteLine(~a);

            //左移运算符（<<）
            Console.WriteLine(a << 1);

            //右移运算符（>>）
            Console.WriteLine(a >> 1);
            #endregion
        }
    }
}
