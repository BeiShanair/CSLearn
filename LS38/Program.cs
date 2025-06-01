namespace LS38
{
    internal class Program
    {
        #region 递归函数
        // 函数自己调用自己
        // 但必须要有结束条件，否则会陷入死循环
        static int Fun(int num)
        {
            if (num == 1 || num == 2)
            {
                return 1;
            }
            else
            {
                return Fun(num - 1) + Fun(num - 2);
            }
        }
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine(Fun(3));
        }
    }
}
