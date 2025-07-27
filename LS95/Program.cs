namespace LS95
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 归并排序
            // 基本原理：递归 + 合并，数组分为左右，左右分别排序，然后合并

            
            int[] arr = new int[] { 1, 3, 5, 7, 9, 2, 4, 6, 8, 10 };

            int[] result = Merge(arr);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
        #region 代码实现
        public static int[] Sort(int[] left, int[] right)
        {
            // 准备一个新数组
            int[] arr = new int[left.Length + right.Length];
            int leftIndex = 0;
            int rightIndex = 0;

            // 填数据
            for (int i = 0; i < arr.Length; i++)
            {
                // 左侧放完了，直接放对面
                if (leftIndex >= left.Length)
                {
                    arr[i] = right[rightIndex];
                    rightIndex++;
                }
                else if (rightIndex >= right.Length)
                {
                    arr[i] = left[leftIndex];
                    leftIndex++;
                }
                else if (left[leftIndex] < right[rightIndex])
                {
                    arr[i] = left[leftIndex];
                    leftIndex++;
                }
                else
                {
                    arr[i] = right[rightIndex];
                    rightIndex++;
                }
            }
            return arr;
        }

        public static int[] Merge(int[] arr)
        {
            // 数组分两段
            int mid = arr.Length / 2;

            // 递归结束条件
            if (arr.Length < 2)
            {
                return arr;
            }
            // 左数组
            int[] left = new int[mid];
            int[] right = new int[arr.Length - mid];
            // 左右数组初始化内容
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < mid)
                {
                    left[i] = arr[i];
                }
                else
                {
                    right[i - mid] = arr[i];
                }
            }
            // 递归
            return Sort(Merge(left), Merge(right));
        }
        #endregion
    }
}
