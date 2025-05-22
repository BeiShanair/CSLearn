namespace LS8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 显式转换

            #region 括号强转
            // 语法
            // 变量类型 变量名 = (目标类型)变量名;
            sbyte s1 = 1;
            int i1 = s1;
            s1 = (sbyte)i1; // 显式转换
            Console.WriteLine(s1);

            // 显式转换可能会造成溢出，要注意范围
            int i2 = 123456789;
            byte b1 = (byte)i2;
            Console.WriteLine(b1);

            float f1 = 1.1f;
            double d1 = 1.123456789;

            f1 = (float)d1;
            Console.WriteLine(f1); // 范围外的数字四舍五入了

            uint u1 = 1;
            int i3 = -1;
            u1 = (uint)i3; // 负数转换成无符号整数会溢出
            Console.WriteLine(u1);

            i3 = (int)1.123456f;
            Console.WriteLine(i3); // 浮点数转换成整数会舍去小数部分，不会四舍五入

            char c1 = 'a';
            c1 = (char)65;
            Console.WriteLine(c1); // 字符转换成整数，会转换成对应的ASCII码值

            // bool和string类型不能进行显式转换
            #endregion

            Console.WriteLine("----------------------------");

            #region Parse法
            // 专门将字符串转换为某一个类型
            string s2 = "123";
            int i4 = int.Parse(s2);
            Console.WriteLine(i4);

            // int i5 = int.Parse("123.456"); // 会报错，因为字符串中包含小数点
            
            float f2 = float.Parse("123.456");
            Console.WriteLine(f2);

            // sbyte b2 = sbyte.Parse("129"); // 会报错，因为字符串中包含超出sbyte范围的数字
            
            bool b2 = bool.Parse("true");
            Console.WriteLine(b2);

            char c2 = char.Parse("a");
            Console.WriteLine(c2);

            #endregion

            Console.WriteLine("----------------------------");

            #region Convert法
            // 专门将某一个类型转换为另一个类型
            int i6 = Convert.ToInt32("123"); // 注意Int32对应int，Int64对应long以此类推
            Console.WriteLine(i6);

            int i7 = Convert.ToInt32(1.523456f);
            Console.WriteLine(i7); // 会四舍五入

            int i8 = Convert.ToInt32(true);
            Console.WriteLine(i8); // true会转换成1，false会转换成0

            int i9 = Convert.ToInt32('a');
            Console.WriteLine(i9);
            #endregion

            Console.WriteLine("----------------------------");

            #region ToString法
            // 其他类型转string
            int i10 = 123;
            string s3 = i10.ToString();
            Console.WriteLine(s3);

            float f3 = 1.123456f;
            string s4 = f3.ToString();
            Console.WriteLine(s4);

            bool b3 = true;
            string s5 = b3.ToString();
            Console.WriteLine(s5);

            char c3 = 'a';
            string s6 = c3.ToString();
            Console.WriteLine(s6);
            #endregion

            #endregion
        }
    }
}
