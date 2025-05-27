namespace LS31
{
    #region 声明枚举
    // 可以声明在namespace下或者class下声明
    enum E_Color
    {
        /// <summary>
        /// 红色
        /// </summary>
        Red, // 第一个值默认从0开始
        Yellow,
        Blue = 10,
        Green // 11
    }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 复杂数据类型-枚举
            //枚举类型
            //枚举类型是一种值类型，它包含一组命名的常量

            #region 枚举变量声明
            E_Color color = E_Color.Red;
            Console.WriteLine(color);
            #endregion
            // 与switch搭配使用
            switch (color)
            {
                case E_Color.Red:
                    break;
                case E_Color.Yellow:
                    break;
                case E_Color.Blue:
                    break;
                case E_Color.Green:
                    break;
                default:
                    break;
            }
            #endregion

            #region 类型转换
            int i = (int)color;
            Console.WriteLine(i);

            string str = color.ToString();
            Console.WriteLine(str);

            #endregion
        }
    }
}
