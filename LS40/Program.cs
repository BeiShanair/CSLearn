namespace LS40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 冒泡排序
            int[] nums = { 1, 3, 2, 5, 4 };
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;

                    }
                }
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
            #endregion
        }
    }
}
