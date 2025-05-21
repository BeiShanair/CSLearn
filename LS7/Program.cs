namespace LS7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 类型转化-相同大类型之间的转换
            #region 有符号整型
            long a = 1;
            int b = 1;
            short c = 1;
            sbyte d = 1;

            a = b; // int -> long，小类型到大类型，隐式转换

            // c = b; // 报错，大类型不能隐式转换为小类型
            // sbyte -> short -> int -> long，隐式转换
            #endregion

            #region 无符号整型
            // byte -> ushort -> uint -> ulong
            ulong e = 1;
            uint f = 1;
            ushort g = 1;
            byte h = 1;

            e = f; // uint -> ulong，隐式转换
                   // g = f; // 报错，大类型不能隐式转换为小类型
            #endregion

            #region 浮点型
            // float -> double
            decimal i = 1.0m;
            double j = 1.0;
            float k = 1.0f;
            // double或者float不能隐式转换为decimal
            // i = j; // 报错
            #endregion

            #region 特殊类型
            // bool char string不存在隐式转换
            #endregion

            #endregion

            #region 不同大类型之间的转换
            #region 无符号与有符号之间
            byte b2 = 1;
            ushort us2 = 1;
            uint ui2 = 1;
            ulong ul2 = 1;

            sbyte sb2 = 1;
            short s2 = 1;
            int i2 = 1;
            long l2 = 1;
            // 有符号的不能隐式转换为无符号的
            // us2 = sb2; // 报错

            // 无符号的可以隐式转换为有符号的，但要注意范围，无符号的变量必须在有符号的范围内
            l2 = b2;
            #endregion

            #region 浮点型与整型
            float f2 = 1.0f;
            double d2 = 1.0;
            decimal m2 = 1.0m;

            f2 = l2; // 浮点数可以装任何整型，double同理

            m2 = l2; // decimal可以装任何整型

            // 整型 -> float -> double
            // 整型 -> decimal

            // 浮点数不能隐式转换为整型
            #endregion

            #region 特殊类型
            // string bool无法隐式转换为其他类型，其他类型也无法隐式转换为bool string

            // 其他类型无法隐式转换为char
            // 但char可以隐式转换为整型或者浮点型
            char c2 = 'a';
            int i3 = c2;
            Console.WriteLine(i3); // 打印的是ASCII码值

            float f3 = c2;
            Console.WriteLine(f3); // 打印的是ASCII码值

            #endregion
            #endregion
        }
    }
}
