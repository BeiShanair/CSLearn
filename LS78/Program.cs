namespace LS78
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LinkedList
            // LinkedList是一个封装好的类
            // 本质是一个可变类型的泛型双向链表
            #endregion

            #region 声明
            LinkedList<int> list = new LinkedList<int>();
            LinkedList<String> list2 = new LinkedList<string>();
            #endregion

            #region 增删查改
            // 添加元素
            list.AddFirst(1); // 往链表头部添加元素
            list.AddLast(2); // 往链表尾部添加元素
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);
            list.AddLast(6);
            list.AddLast(7);

            // 删除元素
            list.Remove(2); // 删除指定元素，但不能通过位置去删除
            list.RemoveFirst(); // 删除第一个元素
            list.RemoveLast(); // 删除最后一个元素
            // list.Clear(); // 清空链表

            // 查找元素
            // 头节点
            LinkedListNode<int> head = list.First;
            Console.WriteLine(head.Value);
            // 尾节点
            LinkedListNode<int> tail = list.Last;
            Console.WriteLine(tail.Value);

            // 找指定位置的节点
            LinkedListNode<int> node = list.Find(4); // 找不到则返回空
            Console.WriteLine(node.Value);
            // 是否存在
            if (list.Contains(4))
            {
                Console.WriteLine("存在");
            }

            // 改
            // 通过节点去修改
            node.Value = 100;
            Console.WriteLine(node.Value);
            #endregion

            #region 遍历
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            // 从头到尾
            LinkedListNode<int> current = list.First;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }

            // 从尾到头
            current = list.Last;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Previous;
            }
            #endregion
        }
    }
}
