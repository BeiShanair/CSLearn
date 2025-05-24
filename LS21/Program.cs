namespace LS21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 控制台相关
            // 清空
            Console.Clear();

            // 设置窗口大小、缓冲区大小
            Console.SetWindowSize(100, 50);
            Console.SetBufferSize(100, 50);

            // 设置光标位置
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("123");

            // 颜色
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("123");

            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();

            Console.CursorVisible = false;

            Environment.Exit(0);
            #endregion
        }
    }
}
