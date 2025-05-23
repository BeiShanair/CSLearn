namespace LS11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 字符串拼接

            #region 使用+

            string str1 = "Hello";
            string str2 = str1 + "World";
            Console.WriteLine(str2);

            #endregion

            #region string.Format
            string str3 = string.Format("{0} {1}", "Hello", "World"); // {0} {1}占位符，数字从0开始
            Console.WriteLine(str3);

            #endregion

            #region 控制台打印拼接
            Console.WriteLine("{0} {1}", "Hello", "World"); // {0} {1}占位符，数字从0开始
            #endregion

            #endregion
        }
    }
}
