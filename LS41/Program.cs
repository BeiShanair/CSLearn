namespace LS41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 选择排序
            int[] nums = { 1, 5, 3, 7, 9, 2, 4, 6, 8 };
            
            
            for (int i = 0; i < nums.Length; i++)
            {
                int index = 0;

                for (int j = 1; j < nums.Length - i; j++)
                {
                    if (nums[j] > nums[index])
                    {
                        index = j;
                  
                    }
                }

                if (index != nums.Length - 1 - i)
                {
                    int temp = nums[index];
                    nums[index] = nums[nums.Length - 1 - i];
                    nums[nums.Length - 1 - i] = temp;
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
