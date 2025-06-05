namespace LS58
{
    #region 密封类
    // 让类无法再继承
    class Father
    {

    }
    // Son类无法再被继承
    sealed class Son : Father
    {

    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
