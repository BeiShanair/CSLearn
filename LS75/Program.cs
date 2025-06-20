namespace LS75
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List
            // List是可变类型的泛型数组
            // 也为我们提供了增删查改的方法

            #region 声明
            List<int> list = new List<int>();

            #endregion

            #region 增删查改
            // 增
            list.Add(1);
            list.Add(2);
            list.Add(346533);
            list.Add(4);
            list.Add(520);
            list.Insert(0, 65536);

            // 删
            list.Remove(1);
            list.RemoveAt(2);
            // list.Clear();

            // 查
            Console.WriteLine(list[0]);
            Console.WriteLine(list.Contains(2));
            // 正向查找
            Console.WriteLine(list.IndexOf(2));
            // 反向查找
            Console.WriteLine(list.LastIndexOf(520));

            // 改
            list[0] = 520;
            Console.WriteLine(list[0]);
            #endregion

            #region 遍历
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Console.WriteLine("******************************");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            #endregion
            #endregion
        }
    }
}
