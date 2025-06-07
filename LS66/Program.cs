using System.Text;

namespace LS66
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region StringBuilder
            // 利用StringBuilder，可以修改字符串而不创建新对象
            // 首先要引用命名空间
            StringBuilder sb = new StringBuilder("12312456664");

            // 容量
            // StringBuilder是有容量的，当字符串长度超过容量时，会自动扩容
            Console.WriteLine(sb.Capacity); // 16

            // 增加
            sb.Append("1234567890");
            Console.WriteLine(sb);
            Console.WriteLine(sb.Capacity); // 32
            sb.AppendFormat("{0}{1}", "abc", "def");
            Console.WriteLine(sb);

            // 插入
            sb.Insert(0, "abc");
            Console.WriteLine(sb);

            // 删
            sb.Remove(0, 3);
            Console.WriteLine(sb);

            // 查
            Console.WriteLine(sb[0]);

            // 改
            sb[0] = 'A';
            Console.WriteLine(sb);

            // 替换
            sb.Replace("a", "大");
            Console.WriteLine(sb);

            // 重新赋值
            sb.Clear();
            sb.Append("1234567890");
            Console.WriteLine(sb);

            #endregion
        }
    }
}
