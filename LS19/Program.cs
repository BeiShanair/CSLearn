namespace LS19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region do-while
            // 先执行一次do，再循环
            int i = 1;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 10);
            #endregion
        }
    }
}
