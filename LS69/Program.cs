using System.Collections;

namespace LS69
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList
            // ArrayList本质是object类型的数组
            // C#已经封装好了，有增删查改的方法

            // 声明
            // 要引用命名空间
            ArrayList list = new ArrayList();

            // 增
            list.Add(1);
            list.Add("hello");
            list.Add(1.1);
            list.Insert(0, "world"); // 在第一个位置插入

            ArrayList list2 = new ArrayList();
            list2.Add(2);
            list.AddRange(list2);

            // 删
            list.Remove(1); // 删除第一个1
            list.RemoveAt(0); // 删除第一个元素
            list2.Clear(); // 清空

            // 查
            Console.WriteLine(list[0]);

            if (list.Contains(1.1))
            {
                Console.WriteLine("包含");
            }

            // 正向查找，返回索引
            // 找不到返回-1
            int index = list.IndexOf("123");
            Console.WriteLine(index);

            // 反向查找
            index = list.LastIndexOf("123");
            Console.WriteLine(index);

            // 改
            list[0] = "123";
            Console.WriteLine(list[0]);

            // 遍历
            Console.WriteLine(list.Count); // 数组长度
            Console.WriteLine(list.Capacity); // 容量

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }


            // 装箱拆箱
            // 因为AL是object类型的数组，它在进行数据存储和读取中肯定存在装箱拆箱
            #endregion
        }
    }
}
