namespace LS16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 条件分支if

            #region if
            //if (条件)
            int a = 10;
            if (a > 5)
            {
                Console.WriteLine("a大于5");
            }
            #endregion

            #region if-else
            //if (条件)
            //else
            if (a > 5)
            {
                Console.WriteLine("a大于5");
            }
            else
            {
                Console.WriteLine("a小于等于5");
            }
            #endregion

            #region if-else if-else
            int b = 5;
            if (b < 5)
            {
                Console.WriteLine("b小于5");
            }
            else if (b == 5)
            {
                Console.WriteLine("b等于5");
            }
            else
            {
                Console.WriteLine("b大于5");
            }
            #endregion

            #endregion
        }
    }
}
