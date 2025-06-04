namespace LS51
{
    #region 拓展方法
    // 拓展方法可以扩展已有的类（非静态），使其拥有新的方法
    static class Tools
    {
        public static void SpeakValue(this int value)
        {
            Console.WriteLine(value);
        }
    }
    #endregion
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int a = 10;
            a.SpeakValue();
        }
    }
}
