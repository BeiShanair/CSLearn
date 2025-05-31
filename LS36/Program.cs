namespace LS36
{
    internal class Program
    {
        #region 可变参数
        static int Add(params int[] nums)
        {
            int sum = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
        #endregion

        #region 参数默认值
        static int Add(int a, int b, int c = 0)
        {
            return a + b + c;
        }
        #endregion
        static void Main(string[] args)
        {
            int sum = Add(1, 2, 3, 4, 5);
            Console.WriteLine(sum);
            sum = Add(1, 2);
            Console.WriteLine(sum);
        }
    }
}
