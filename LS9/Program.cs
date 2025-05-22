namespace LS9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 异常捕获

            #region 作用
            // 捕获异常，防止程序崩溃
            string str = Console.ReadLine();

            //int num = int.Parse(str);

            #endregion

            #region 基本语法
            try
            {
                // 可能出现异常的代码
                int num = int.Parse(str);
            }
            catch(Exception e)
            {
                // 出现异常后执行的代码
                Console.WriteLine(e.Message);
            }
            finally
            {
                // 无论是否出现异常，都会执行的代码
                Console.WriteLine("执行完毕！");
            }

            #endregion

            #endregion
        }
    }
}
