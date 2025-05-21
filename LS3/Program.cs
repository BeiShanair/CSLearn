namespace LS3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 存储空间
            int sbyteSize = sizeof(sbyte);
            Console.WriteLine($"sbyte占用{sbyteSize}个字节");

            int shortSize = sizeof(short);
            Console.WriteLine($"short占用{shortSize}个字节");

            int intSize = sizeof(int);
            Console.WriteLine($"int占用{intSize}个字节");

            int longSize = sizeof(long);
            Console.WriteLine($"long占用{longSize}个字节");

            Console.WriteLine("------------------------");

            int byteSize = sizeof(byte);
            Console.WriteLine($"byte占用{byteSize}个字节");

            int ushortSize = sizeof(ushort);
            Console.WriteLine($"ushort占用{ushortSize}个字节");

            int uintSize = sizeof(uint);
            Console.WriteLine($"uint占用{uintSize}个字节");

            int ulongSize = sizeof(ulong);
            Console.WriteLine($"ulong占用{ulongSize}个字节");

            Console.WriteLine("------------------------");

            int floatSize = sizeof(float);
            Console.WriteLine($"float占用{floatSize}个字节");

            int doubleSize = sizeof(double);
            Console.WriteLine($"double占用{doubleSize}个字节");

            int decimalSize = sizeof(decimal);
            Console.WriteLine($"decimal占用{decimalSize}个字节");

            Console.WriteLine("------------------------");
            
            int charSize = sizeof(char);
            Console.WriteLine($"char占用{charSize}个字节");

            int boolSize = sizeof(bool);
            Console.WriteLine($"bool占用{boolSize}个字节");

            // string没有固定的存储空间

            #endregion

            #region 变量的本质
            // 二进制
            // 1字节 = 8位（byte）


            #endregion
        }
    }
}
