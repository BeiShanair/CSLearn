namespace LS37
{
    internal class Program
    {
        #region 函数重载
        // 函数名字相同，但参数不同
        static int Add(int a, int b)
        {
            return a + b;
        }
        
        static int Add(params int[] nums)
        {
            int sum = 0;
            foreach (var num in nums)
            {
                sum += num;
            }
            return sum;
        }
        #endregion
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Console.WriteLine(Add(a, b));
            Console.WriteLine(Add(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));
        }
    }
}
