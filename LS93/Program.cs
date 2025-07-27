namespace LS93
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 插入排序
            // 基本原理：将无序序列分为两个区域，分为有序区和无序区，每次从无序区取出一个元素，在有序区中找到合适的位置插入，直到无序区为空。

            #region 语法实现
            int[] arr = { 5, 3, 8, 6, 2, 7, 1, 4 };
            // 排序开始前，先假设第一个元素是有序的，从第二个元素开始遍历
            for (int i = 1; i < arr.Length; i++)
            {
                // 记录当前要插入的元素
                int temp = arr[i];
                // 记录当前要插入元素的前一个元素的下标
                int j = i - 1;
                // 从后往前遍历有序区，如果当前元素大于要插入的元素，则将当前元素后移一位
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                // 将要插入的元素插入到合适的位置
                arr[j + 1] = temp;
            }

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
            #endregion
            #endregion
        }
    }
}
