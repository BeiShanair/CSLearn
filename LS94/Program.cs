namespace LS94
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 希尔排序
            // 基本原理：插入排序的升级版
            // 将整个待排序序列分割成若干子序列分别进行直接插入排序，待整个序列中的记录“基本有序”时，再对全体记录进行依次直接插入排序
            // 优点：在极限情况下，可以有效降低时间复杂度

            #region 算法实现
            int[] arr = { 5, 2, 6, 1, 8, 3, 7, 4 };

            // 确定步长
            for (int step = arr.Length / 2; step > 0; step /= 2)
            {
                //for (int i = 1; i < arr.Length; i++)
                for (int i = step; i < arr.Length; i++)
                {
                    int temp = arr[i];
                    int j = i - step;
                    while (j >= 0 && arr[j] > temp)
                    {
                        arr[j + step] = arr[j];
                        j -= step;
                    }
                    arr[j + step] = temp;
                }
            }

            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            #endregion
            #endregion
        }
    }
}
