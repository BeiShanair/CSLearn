namespace LS79
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 泛型栈和队列
            Stack<int> stack = new Stack<int>();
            Queue<int> queue = new Queue<int>();

            stack.Push(1);
            queue.Enqueue(2);
            #endregion
        }
    }
}
