namespace LS10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 算数运算符

            #region 赋值符号
            // =
            int a = 1;
            Console.WriteLine(a);

            #endregion

            #region 算数运算符
            // 加 +
            int b = 1;
            int c = 2;
            int d = b + c;
            Console.WriteLine(d);

            // 连续运算
            int n = 1 + 2 + 3 + 4 + 5;
            Console.WriteLine(n);

            // 减 -
            int e = 1;
            int f = 2;
            int g = e - f;
            Console.WriteLine(g);

            // 乘 *
            int h = 1;
            int i = 2;
            int j = h * i;
            Console.WriteLine(j);

            // 除 /
            int k = 1;
            int l = 2;
            int m = k / l;
            Console.WriteLine(m);

            // int类型的做除法会丢失小数点后的数
            int n1 = 1;
            int n2 = 2;
            n1 = n1 / n2;
            Console.WriteLine(n1);
            // 如果要保留小数，需要将其中一个数改为浮点数
            int n3 = 1;
            float f3 = n3 / 2f;
            Console.WriteLine(f3);

            // 取余 % 
            int o = 1;
            int p = 2;
            int q = o % p;
            Console.WriteLine(q);

            #endregion

            #region 运算符优先级
            // 乘、除、取余的优先级高于加减
            int r = 1 + 2 * 3;
            Console.WriteLine(r);

            // 加括号可以改变优先级
            int s = (1 + 2) * 3;
            Console.WriteLine(s);
            #endregion

            #region 复合运算符
            // +=
            int t = 1;
            t += 2;
            Console.WriteLine(t);

            // -=
            int u = 1;
            u -= 2;
            Console.WriteLine(u);

            // *=
            int v = 1;
            v *= 2;
            Console.WriteLine(v);

            // /=
            int w = 1;
            w /= 2;
            Console.WriteLine(w);

            // %=
            int x = 1;
            x %= 2;
            Console.WriteLine(x);

            #endregion

            #region 自增自减
            // ++
            int y = 1;
            int y1 = 1;
            Console.WriteLine(y++); // 先用再加，1
            Console.WriteLine(++y1); // 先加再用，2

            // --
            int z = 1;
            int z1 = 1;
            Console.WriteLine(z--); // 先用再减，1
            Console.WriteLine(--z1); // 先减再用，0

            #endregion

            #endregion
        }
    }
}
