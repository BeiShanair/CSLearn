namespace LS86
{
    internal class Program
    {
        static bool isRunning = true;
        static Object obj = new object();
        static void Main(string[] args)
        {
            #region 进程
            // 进程是进程是操作系统进行资源分配和调度的基本单位，是能独立运行的最小单位
            // 每个进程都有自己的地址空间，包括代码段、数据数据段和堆栈段。进程之间是相互独立的，它们之间可以通过进程间通信（IPC）机制进行通信。
            #endregion

            #region 线程
            // 线程是进程内的执行单元，是CPU调度的基本单位。
            // 一个进程可以包含多个线程，它们共享进程的地址每个线程都有自己的执行栈和寄存器状态，但它们共享进程的地址空间和资源。
            #endregion

            #region 多线程
            // 多线程是指在一个进程中同时运行多个线程，每个线程可以执行不同的任务。
            #endregion

            #region 语法
            // C#的线程类 Thread
            // 声明一个新线程，注意线程执行的代码需要封装到一个函数中
            Thread t = new Thread(DoWork);

            // 启动线程
            t.Start();

            // 设置为后台线程
            // 后台线程在主线程结束时自动终止，而前台线程需要等待所有前台线程结束后才终止
            // 如果后台线程是死循环，那么主线程会一直等待，导致程序无法正常退出
            t.IsBackground = true;

            // 关闭释放线程
            //Thread t2 = new Thread(DoSomething);
            //t2.Start();
            //t2.IsBackground = true;
            //isRunning = false;

            // 终止线程
            // t.Abort(); // 在控制台中并不能使用
            // t = null;

            // 休眠，单位为毫秒
            // Thread.Sleep(1000); // 休眠1秒
            #endregion

            #region 线程之间共享数据
            // 多线程使用的内存是共享的，因此需要小心处理线程之间的数据共享问题，以避免数据竞争和死锁等问题。
            // 可以使用锁（Lock）来保护共享数据，确保同一时间只有一个线程可以访问共享数据。

            // 关键字 lock
            // lock (obj)括号中填引用类型的对象
            while (true)
            {
                lock (obj)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("W");
                }
            }
            #endregion

            #region 多线程的意义
            // 多线程可以提高程序的并发性能，使得程序可以同时处理多个任务，从而提高程序的响应速度和吞吐量。
            // 可以使用多线程处理一些复杂的计算任务，以避免阻塞主线程，提高程序的响应速度。
            #endregion
        }
        static void DoWork()
        {
            // 线程执行的代码
            while (true)
            {
                lock (obj)
                {
                    Console.SetCursorPosition(10, 5);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("H");
                    Thread.Sleep(1000);
                }
            }
        }
        static void DoSomething()
        {
            while (isRunning)
            {
                Console.WriteLine("执行！");
            }
        }
    }
}
