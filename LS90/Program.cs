using System.Collections;

namespace LS90
{
    #region 迭代器
    // 迭代器有时又称为光标，是程序的软件设计模式
    // 迭代器模式提供了一个方法顺序访问一个聚合对象中的各个元素，而又不暴露其内部标识

    // 从表现效果上看
    // 是可以在容器对象上遍历访问的接口
    // 而设计人员无需关心容器对象的内存分配的实现细节，可以用foreach遍历的类，都是实现了迭代器的

    #endregion

    #region 标准迭代器的实现
    // 要实现一个标准迭代器，需要实现以下接口
    // IEnumerable 和 IEnumerator

    // foreach的本质
    // 先获取对象的IEnumerator
    // 调用其中的GetEnumerator()方法获取
    // 然后调用MoveNext()方法进行迭代
    // 只要MoveNext()方法返回true，就调用Current属性获取当前元素
    // 然后继续调用MoveNext()方法，直到MoveNext()方法返回false
    class TestList : IEnumerable, IEnumerator
    {
        private int[] list;
        private int position = -1; // 用来记录当前迭代的位置
        public TestList()
        {
            list = new int[] { 1, 2, 3, 4, 5 };
        }

        public IEnumerator GetEnumerator()
        {
            Reset();
            return this;
        }

        public object Current
        {
            get
            {
                return list[position];
            }
        }

        public bool MoveNext()
        {
            position++;
            return (position < list.Length);
        }

        public void Reset()
        {
            position = -1;
        }
    }
    #endregion

    #region yield return语法糖实现迭代器
    // 关键接口IEnumerable
    class TestList2 : IEnumerable
    {
        private int[] list;
        public TestList2()
        {
            list = new int[] { 1,2,3,4,5 };
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < list.Length; i++)
            {
                yield return list[i];
            }
        }
    }
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            TestList testList = new TestList();
            foreach (var item in testList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
