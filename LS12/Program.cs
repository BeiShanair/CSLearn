namespace LS12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 条件运算符
            // 用于比较两个变量或者表达式
            // >
            int a = 10;
            int b = 20;
            bool result = a > b;
            Console.WriteLine(result);

            // <
            bool result2 = a < b;
            Console.WriteLine(result2);

            // ==
            bool result3 = a == b;
            Console.WriteLine(result3);

            // >=
            bool result4 = a >= b;
            Console.WriteLine(result4);

            // <=
            bool result5 = a <= b;
            Console.WriteLine(result5);

            // !=
            bool result6 = a != b;
            Console.WriteLine(result6);

            #endregion

            #region 不能进行范围比较

            int c = 15;
            // bool result7 = 10 < c < 20; // 不能这样写
            bool result7 = 10 < c && c < 20; // 结合逻辑运算符
            Console.WriteLine(result7);

            #endregion

            #region 不同类型之间的比较
            // 数值都可以进行比较
            int i1 = 10;
            double d1 = 10.0;
            bool result8 = i1 == d1;
            Console.WriteLine(result8);

            // bool string 类型只能在同类型之间使用 == 或者 != 比较
            // 但char可以与数值类型进行比较
            char ch1 = 'a';
            char ch2 = 'b';
            bool result9 = ch1 == ch2;
            Console.WriteLine(result9);

            bool result10 = ch1 > 60;
            Console.WriteLine(result10);

            #endregion
        }
    }
}
