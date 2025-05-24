namespace LS20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region for
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // 嵌套
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.WriteLine($"{i},{j}");
                }
            }
            #endregion
        }
    }
}
