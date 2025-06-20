using System.Collections;

namespace LS72
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region HashTable
            // HashTable是散列表，是它使用键值对来存储数据，键是唯一的，值可以是重复的。
            // 主要作用是提高数据查找效率
            // 使用键来访问元素

            #region 声明
            Hashtable ht = new Hashtable();

            #endregion

            #region 增删查改
            // 添加元素
            ht.Add("1", "张三");
            ht.Add("123", "李四");
            ht.Add(1, "王五");
            ht.Add(123, "赵六");
            // 不能出现相同的键
            // ht.Add("1", "张三"); // 报错

            // 删除元素
            ht.Remove("1"); // 通过键去删除
            // 删除不存在的键也不会出错
            // ht.Remove("2"); // 不会报错
            //ht.Clear(); // 清空所有元素

            // 查找元素
            // 找不到会返回空
            Console.WriteLine(ht[123]);
            Console.WriteLine(ht[4]); // 返回空
            Console.WriteLine(ht[1]); 

            // 是否存在
            Console.WriteLine(ht.Contains("123")); // true
            Console.WriteLine(ht.ContainsKey(123)); // true
            Console.WriteLine(ht.ContainsValue("赵六")); // true

            // 改
            ht[123] = "赵六六";// 只能改键对应的内容，但不能改变键本身
            #endregion

            #region 遍历
            // 遍历键
            Console.WriteLine(ht.Count); // 获取键的数量
            foreach (var item in ht.Keys)
            {
                Console.Write(item);
                Console.WriteLine(ht[item]); // 通过键获取值
            }

            // 遍历值
            foreach (var item in ht.Values)
            {
                Console.WriteLine(item);
            }

            // 遍历键值对
            // DictionaryEntry是一个结构体，包含两个属性，Key和Value
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }

            // 迭代器遍历
            IDictionaryEnumerator ie = ht.GetEnumerator();
            bool hasNext = ie.MoveNext();
            while (hasNext)
            {
                Console.WriteLine(ie.Key + " " + ie.Value);
                hasNext = ie.MoveNext();
            }
            #endregion

            #region 装箱拆箱
            // 因为Hashtable只能存储object类型的数据，所以需要装箱拆箱
            #endregion
            #endregion
        }
    }
}
