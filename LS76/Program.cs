namespace LS76
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dictionary
            // Dictionary可以理解为泛型类型的HashTable
            // 同样也是键值对
            #region 声明
            Dictionary<string, int> dic = new Dictionary<string, int>();
            #endregion

            #region 增删查改
            // 增
            dic.Add("a", 1);
            dic.Add("b", 2);
            dic.Add("c", 3);
            dic.Add("d", 4);
            dic.Add("e", 5);

            // 删
            dic.Remove("a");
            // dic.Clear();

            // 查
            Console.WriteLine(dic["b"]); // 不存在会报错

            if (dic.ContainsKey("b"))
            {
                Console.WriteLine(dic["b"]);
            }

            if (dic.ContainsValue(2))
            {
                Console.WriteLine("存在值为2的键");
            }

            // 改
            dic["c"] = 6;
            #endregion

            #region 遍历
            foreach (var item in dic)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            Console.WriteLine("------------------------");
            foreach (var item in dic.Keys)
            {
                Console.Write(item + " ");
                Console.WriteLine(dic[item]);
            }
            Console.WriteLine("------------------------");
            foreach (var item in dic.Values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------");
            foreach (KeyValuePair<string, int> item in dic)
            {
                Console.WriteLine(item.Key + " " + item.Value);
            }
            #endregion
            #endregion
        }
    }
}
