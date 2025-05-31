namespace LS35
{
    internal class Program
    {
        #region REF OUT
        // ref和out可以改变从外部传入函数的参数，里面改了，外面也改了
        static void ChangeValue(int a)
        {
            a = 3;
        }

        #region 使用ref
        static void ChangeValueRef(ref int a)
        {
            a = 3;
        }
        static void ChangeArrayRef(ref int[] a)
        {
            a = new int[] { 1, 2, 3 };
        }
        #endregion

        #region 使用out
        // out传入的未初始化参数必须在函数内赋值
        static void ChangeValueOut(out int a)
        {
            a = 3;
        }
        static void ChangeArrayOut(out int[] a)
        {
            a = new int[] { 1, 2, 3 };
        }
        #endregion

        #endregion
        static void Main(string[] args)
        {
            int i = 1;
            ChangeValue(i);
            Console.WriteLine(i);
            ChangeValueRef(ref i);
            Console.WriteLine(i);
            int[] a = { 1, 2 };
            ChangeArrayRef(ref a);
            for (int j = 0; j < a.Length; j++)
            {
                Console.WriteLine(a[j]);
            }

            // ref传入的参数必须初始化，但out不用
            int i2;
            // ChangeArrayRef(ref i2); // 报错
            ChangeValueOut(out i2);
            Console.WriteLine(i2);
        }
    }
}
