namespace LS77
{
    #region 简单实现
    // 链表节点
    class LinkedNode<T> 
    {
        public T value;
        public LinkedNode<T> next;

        public LinkedNode(T value)
        {
            this.value = value;
        }
    }

    class LinkedList<T>
    {
        public LinkedNode<T> head;
        public LinkedNode<T> tail;

        public void Add(T value)
        {
            LinkedNode<T> node = new LinkedNode<T>(value);
            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.next = node;
                tail = node;
            }
        }

        public void Remove(T value)
        {
            if (head == null) return;
            if (head.value.Equals(value))
            {
                head = head.next;
                if (head == null) tail = null;
                return;
            }

            LinkedNode<T> prev = head;
            while (prev.next != null)
            {
                if (prev.next.value.Equals(value))
                {
                    prev.next = prev.next.next;
                    break;
                }
            }
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 数据结构
            // 常用的数据结构：数组、栈、队列、链表、树、图、堆、散列表...
            #endregion

            #region 线性表
            // 线性表是具有相同数据类型的n个数据元素的有限序列
            #endregion

            #region 顺序存储
            // 顺序存储：用一组地址连续的存储单元依次存储线性表中的数据元素
            // 数组、栈、队列、列表都是顺序存储
            #endregion

            #region 链式存储
            // 链式存储：用一组任意的存储单元存储线性表中的数据元素
            // 单向链表、双向链表、循环链表都是链式存储
            #endregion

            LinkedNode<int> node = new LinkedNode<int>(1);
            LinkedNode<int> node2 = new LinkedNode<int>(2);
            node.next = node2;
            Console.WriteLine(node.value);

            LinkedList<int> list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            LinkedNode<int> node3 = list.head;
            while (node3 != null)
            {
                Console.WriteLine(node3.value);
                node3 = node3.next;
            }
            list.Remove(2);
            node3 = list.head;
            while (node3 != null)
            {
                Console.WriteLine(node3.value);
                node3 = node3.next;
            }
        }
    }
}
