namespace LS18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region while
            int i = 1;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
            #endregion

            #region 嵌套使用
            int j = 1;
            while (j < 10)
            {
                if (j == 5)
                {
                    Console.WriteLine("j = 5");
                }
                j++;
            }
            #endregion

            #region break
            while (j < 20)
            {
                if (j == 15)
                {
                    break;
                }
                j++;
            }
            #endregion
        }
    }
}
