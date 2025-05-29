namespace LS33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 值类型/引用类型
            // string 数组 类 是引用类型
            // int bool char 结构体 枚举 枚举是值类型

            #region 区别
            int[] arr = { 1, 2, 3 };
            int a = 10;

            int b = a;
            int[] arr2 = arr;
            Console.WriteLine("a={0}, b={1}", a, b);
            Console.WriteLine("arr[0]={0}, arr2[0]={1}", arr[0], arr2[0]);

            b = 20;
            arr2[0] = 5;
            Console.WriteLine("a={0}, b={1}", a, b);
            Console.WriteLine("arr[0]={0}, arr2[0]={1}", arr[0], arr2[0]);

            // 值类型在赋值时，原来的变量会创建一个副本，修改副本不会影响原来的变量
            // 引用类型在赋值时，都指向同一个对象

            // 值类型存储在栈上
            // 引用类型存储在堆上
            #endregion

            #region 特殊的引用类型string
            string str1 = "123";
            string str2 = str1;
            str2 = "321";
            Console.WriteLine(str2);
            // string频繁改变会影响性能，会造成内存垃圾
            #endregion
            #endregion
        }
    }
}
