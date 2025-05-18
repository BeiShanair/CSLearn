// 注释

/*
 * 多行注释
 */
namespace Learn
{
    /// <summary>
    /// 类注释
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// 方法注释
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // 控制台输出
            Console.WriteLine("Hello, World!"); // WriteLine 输出并换行
            Console.Write("Hello, World!"); // Write 输出不换行
            Console.WriteLine("Hello, World!");

            // 控制台输入
            Console.WriteLine("请输入您的名字：");
            Console.ReadLine(); // 读取一行输入
            Console.WriteLine("输入完毕！");

            Console.Write("请输入任意字符：");
            Console.ReadKey(); // 按下任意键后就继续执行
        }
    }
}
