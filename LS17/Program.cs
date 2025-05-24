namespace LS17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region switch

            #region 基本语法
            //switch (表达式)
            //{
            //    case 值1:
            //        语句1;
            //        break;
            //    case 值2:
            //        语句2;
            //        break;
            //    default:
            //        语句3;
            //        break;
            //}
            #endregion

            #region 使用
            // default可以省略
            int num = 2;
            switch (num)
            {
                case 1:
                    Console.WriteLine("星期一");
                    break;
                case 2:
                    Console.WriteLine("星期二");
                    break;
                default:
                    Console.WriteLine("其他");
                    break;
            }

            #endregion

            #region 自定义常量
            const char c = 'a';
            char c2 = 'b';
            switch (c2)
            {
                case c:
                    Console.WriteLine("字符a");
                    break;
                default:
                    break;
            }
            #endregion

            #region 贯穿
            int i2 = 1;
            switch (i2)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("数字");
                    break;

                default:
                    break;
            }
            #endregion

            #endregion
        }
    }
}
