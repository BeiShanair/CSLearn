using System.Collections;

namespace LS71
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Queue
            // Queue 是队列
            // 本质也是object数组
            // 遵循先进先出

            // 声明
            Queue q = new Queue();

            // 增
            q.Enqueue("a");
            q.Enqueue("b");
            q.Enqueue(1);
            q.Enqueue(2.3f);

            // 遍历
            int l = q.Count; // 获取长度
            Console.WriteLine(l);
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            // 如果用for循环的话，可以将其转换为object数组
            object[] arr = q.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            // 循环出队
            //while (q.Count > 0)
            //{
            //    object o2 = q.Dequeue(); // 取出第一个元素，并删除
            //    Console.WriteLine(o2);
            //}
            // 取
            object o = q.Dequeue(); // 取出第一个元素，并删除
            Console.WriteLine(o);

            // 查
            Console.WriteLine(q.Peek()); // 取出第一个元素，但不删除
            if (q.Contains(1))
            {
                Console.WriteLine("包含1");
            }

            // 改
            // 只能清除，不能改变某一个元素
            q.Clear();
            #endregion
        }
    }
}
