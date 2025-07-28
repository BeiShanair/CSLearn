namespace LS97
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 堆排序
            // 基本原理：构建二叉树，大堆顶调整，堆顶往后放，不停变堆顶
            // 最大非叶子节点： n/2-1
            // 父节点下标：i
            // 左子节点下标：2i+1
            // 右子节点下标：2i+2
            int[] arr = { 3, 5, 2, 4, 1, 6, 8, 7, 9 };

            HeapSort(arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
        #region 算法实现
        // 实现父节点和左右节点节点比较
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arr">需要排序的数组</param>
        /// <param name="parent">当前根节点的索引</param>
        /// <param name="length">哪些位置没有确定</param>
        public static void HeapAdjust(int[] arr, int parent, int length)
        {
            // 通过传入的索引 得到它对应的左右叶子节点的索引
            int left = 2 * parent + 1;
            int right = 2 * parent + 2;
            // 用于记录最大数的索引
            int maxIndex = parent;
            if (left < length && arr[left] > arr[maxIndex])
            {
                maxIndex = left;
            }
            if (right < length && arr[right] > arr[maxIndex])
            {
                maxIndex = right;
            }

            if (maxIndex != parent)
            {
                // 交换
                int temp = arr[parent];
                arr[parent] = arr[maxIndex];
                arr[maxIndex] = temp;

                // 通过递归 看看是否影响了叶子节点他们的关系
                HeapAdjust(arr, maxIndex, length);
            }
        }

        // 构建大堆顶
        public static void BuildBigHeap (int[] arr)
        {
            // 从最后一个非叶子节点开始
            for (int i = arr.Length / 2 - 1; i >= 0; i--)
            {
                HeapAdjust(arr, i, arr.Length);
            }
        }

        public static void HeapSort(int[] arr)
        {
            BuildBigHeap(arr);

            for (int i = arr.Length - 1; i > 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                HeapAdjust(arr, 0, i);
            }
        }
        #endregion
    }
}
