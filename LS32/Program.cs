namespace LS32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 数组

            #region 一维数组
            #region 声明
            int[] arr1;
            int[] arr2 = new int[5];
            int[] arr3 = new int[5] { 1, 2, 3, 4, 5 };
            int[] arr4 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr5 = { 1, 2, 3, 4, 5 };
            #endregion

            #region 使用
            int[] array = { 1, 2, 3, 4, 5 };
            // 长度
            Console.WriteLine(array.Length);

            // 元素访问
            Console.WriteLine(array[0]);

            // 修改元素
            array[0] = 10;
            Console.WriteLine(array[0]);

            // 遍历
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            // 增加元素
            // 数组初始化以后，是不能修改的，可以通过搬家的方法
            int[] array2 = new int[6];
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }
            array2[5] = 6;
            array = array2;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            // 删除，同理
            int[] array3 = new int[4];
            for (int i = 0; i < array3.Length - 1; i++)
            {
                array3[i] = array[i];
            }
            array = array3;
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            // 查找
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 3)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion
            #endregion

            #region 二维数组
            #region 声明
            int[,] arr6;
            int[,] arr7 = new int[3, 4];
            int[,] arr8 = new int[3, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            int[,] arr9 = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            int[,] arr10 = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            #endregion

            #region 使用
            // 长度
            Console.WriteLine(arr10.GetLength(0));// 行
            Console.WriteLine(arr10.GetLength(1));// 列

            // 获取元素
            Console.WriteLine(arr10[1, 1]);

            // 修改元素
            arr10[1, 1] = 100;
            Console.WriteLine(arr10[1, 1]);

            // 遍历
            for (int i = 0; i < arr10.GetLength(0); i++)
            {
                for (int j = 0; j < arr10.GetLength(1); j++)
                {
                    Console.Write(arr10[i, j] + " ");
                }
            }
            Console.WriteLine();

            // 增加元素
            int[,] arr11 = new int[4, 4];
            for (int i = 0; i < arr10.GetLength(0); i++)
            {
                for (int j = 0; j < arr10.GetLength(1); j++)
                {
                    arr11[i, j] = arr10[i, j];
                }
            }
            arr11[3, 3] = 100;
            arr10 = arr11;
            for (int i = 0; i < arr10.GetLength(0); i++)
            {
                for (int j = 0; j < arr10.GetLength(1); j++)
                {
                    Console.Write(arr10[i, j] + " ");
                }
            }
            Console.WriteLine();

            // 删除
            int[,] arr12 = new int[2, 4];
            for (int i = 0; i < arr12.GetLength(0); i++)
            {
                for (int j = 0; j < arr12.GetLength(1); j++)
                {
                    arr12[i, j] = arr10[i, j];
                }
            }
            arr10 = arr12;
            for (int i = 0; i < arr10.GetLength(0); i++)
            {
                for (int j = 0; j < arr10.GetLength(1); j++)
                {
                    Console.Write(arr10[i, j] + " ");
                }
            }
            Console.WriteLine();
            #endregion
            #endregion

            #region 交错数组
            // 交错数组是数组的数组
            // 交错数组可以有不同的长度
            int[][] arr13;
            int[][] arr14 = new int[3][];// 第二个是不能填的
            int[][] arr15 = new int[3][] { new int[3], new int[4], new int[5] };
            int[][] arr16 = new int[][] { new int[3], new int[4], new int[5] };
            int[][] arr17 = { new int[3], new int[4], new int[5] };
            int[][] arr18 = { new int[] { 1},
                              new int[] { 2, 3, 4 },
                              new int[] { 5, 6, 7, 8, 9 } };

            #region 使用
            // 长度
            Console.WriteLine(arr18.GetLength(0));// 行
            Console.WriteLine(arr18[1].Length);// 某一行的列数

            // 访问元素
            Console.WriteLine(arr18[1][1]);

            // 修改元素
            arr18[1][1] = 100;
            Console.WriteLine(arr18[1][1]);

            // 遍历
            for (int i = 0; i < arr18.GetLength(0); i++)
            {
                for (int j = 0; j < arr18[i].Length; j++)
                {
                    Console.Write(arr18[i][j] + " ");
                }
            }
            Console.WriteLine();
            #endregion
            #endregion
            #endregion
        }
    }
}
