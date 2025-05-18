namespace LS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. 折叠代码
            // 由#region 和 #endregion 指定
            #region 声明变量
            // 变量
            // 不同类型的变量可以存储不同类型的数据

            // 声明方法
            // 变量类型 变量名称 = 初始值;
            int num = 10;

            #endregion

            #region 变量类型
            // 1. 有符号整型
            // sbyte（-127~128）
            sbyte a = 10;
            Console.WriteLine(a);
            // short（-32768~32767）
            short b = 10;
            Console.WriteLine(b);
            // int（-21亿~21亿）
            int c = 10;
            Console.WriteLine(c);
            // long（-9百万兆~9百万兆）
            long d = 10;
            Console.WriteLine(d);

            // 2. 无符号整型
            // byte（0~255）
            byte e = 10;
            Console.WriteLine(e);
            // ushort（0~65535）
            ushort f = 10;
            Console.WriteLine(f);
            // uint（0~42亿）
            uint g = 10;
            Console.WriteLine(g);
            // ulong（0~18百万兆）
            ulong h = 10;
            Console.WriteLine(h);

            // 3. 浮点型
            // float（7~8位有效数字，有效数字从非零数字开始计算）
            float i = 10.01364654563165431f; // 要加上f（F）
            Console.WriteLine(i); // 输出10.013646
            // double（15~17位有效数字）
            double j = 10.01364654563165431; // 默认就是double类型
            Console.WriteLine(j); // 输出10.013646545631655
            // decimal（27~28位有效数字），不怎么使用
            decimal k = 10.01364654563165431m; // 要加上m（M）
            Console.WriteLine(k); // 输出10.01364654563165431

            // 4. 布尔
            // bool（true/false）
            bool l = true;
            Console.WriteLine(l);

            // 5. 字符
            // char（单个字符）
            char m = 'a'; // 单引号
            Console.WriteLine(m);

            // 6. 字符串
            // string（多个字符）
            string n = "hello";
            Console.WriteLine(n);
            #endregion

            #region 多个同类型变量声明
            // 逗号分隔
            int o = 10, p = 20, q = 30;
            #endregion

            #region 变量初始化
            // 直接赋值
            int r = 10;
            // 先声明再赋值
            int s;
            s = 10;
            #endregion
        }
    }
}
