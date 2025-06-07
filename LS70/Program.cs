using System.Collections;

namespace LS70
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Stack
            // Stack是一个object类型的数组，但封装了特殊的存储规则
            // 是栈存储容器，先进后出

            // 声明
            Stack stack = new Stack();

            // 增（压栈）
            stack.Push(1);
            stack.Push("123");
            stack.Push(1.1);
            stack.Push(true);
            stack.Push('a');

            // 取
            object v = stack.Pop();
            Console.WriteLine(v);

            v = stack.Pop();
            Console.WriteLine(v);

            // 查
            // 栈无法查看指定位置的内容，只能查看栈顶的内容
            Console.WriteLine(stack.Peek()); // Peek不弹出，只查看
            // 查看元素是否存在
            if (stack.Contains(1))
            {
                Console.WriteLine("存在");
            }

            // 栈没有办法改变其中元素，要么清空再次压栈、弹出

            // 遍历
            Console.WriteLine(stack.Count); // 长度
            // 栈不能用for遍历，只能用foreach
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            // 可以将栈转为object数组，再用for遍历
            object[] arr = stack.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }


            // 循环弹栈
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
            #endregion
        }
    }
}
