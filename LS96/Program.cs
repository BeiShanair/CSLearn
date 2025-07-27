namespace LS96
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 快速排序
            // 基本原理：选取基准，产生左右标识，将比基准小的放在左边，比基准大的放在右边，然后递归
            int[] arr = { 3, 5, 1, 2, 4, 6, 8, 7, 9 };
            QuickSort(arr, 0, arr.Length - 1);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
        #region 算法实现
        public static void QuickSort(int[] arr, int left, int right)
        {
            // 递归结束条件
            if (left >= right)
            {
                return;
            }
            // 记录基准值
            // 左右游标
            int tempLeft, tempRight, temp;
            temp = arr[left];
            tempLeft = left;
            tempRight = right;

            // 交换逻辑
            while (tempLeft != tempRight)
            {
                // 从右边开始比较
                while (tempLeft < tempRight && arr[tempRight] > temp)
                {
                    tempRight--;
                }
                arr[tempLeft] = arr[tempRight];
            
                while (tempLeft < tempRight && arr[tempLeft] < temp)
                {
                    tempLeft++;
                }
                arr[tempRight] = arr[tempLeft];
            }
            arr[tempLeft] = temp;

            // 递归
            QuickSort(arr, left, tempRight - 1);
            QuickSort(arr, tempLeft + 1, right);
        }
        #endregion
    }
}
