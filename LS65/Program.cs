namespace LS65
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region string
            // 指定位置获取
            string str = "Hello World";
            Console.WriteLine(str[0]);

            // 拼接
            Console.WriteLine(str + " C#");
            Console.WriteLine(string.Format("{0}123", " C#"));

            // 正向查找
            Console.WriteLine(str.IndexOf("World"));
            // 没找到会返回 -1

            // 反向查找
            Console.WriteLine(str.LastIndexOf("l"));

            // 移除指定位置的字符
            Console.WriteLine(str.Remove(5, 1)); // 第二个参数为删除的字符个数
            // 到末尾则不用填第二个参数
            Console.WriteLine(str.Remove(5));

            // 替换
            Console.WriteLine(str.Replace("World", "C#"));

            // 大小写转换
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());

            // 截取
            Console.WriteLine(str.Substring(6, 5)); // 起始位置，长度（注意不能越界）
            Console.WriteLine(str.Substring(3)); // 起始位置，到末尾

            // 分割
            str = "1 2 3 4 5 6 7";
            string[] str1 = str.Split(' '); // 按空格分割
            for (int i = 0; i < str1.Length; i++)
            {
                Console.WriteLine(str1[i]);
            }
            #endregion
        }
    }
}
