namespace LS64
{
    class Test
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region object类中的方法
            // Equals
            // 判断两个类型是否相等（比引用）
            Console.WriteLine("Equals: " + Object.Equals(1, 1));

            Test t = new Test();
            Test t2 = new Test();
            Console.WriteLine("Equals: " + Object.Equals(t, t2));

            // GetType
            // 获取当前对象的类型
            Console.WriteLine("GetType: " + t.GetType());

            // MemberwiseClone
            // 浅拷贝，克隆对象，新对象的引用类型变量还是指向同一个，值类型变量是独立的

            // 虚方法的Equals，相当于ReferenceEquals方法
            // MS重写了这个方法，可以进行值比较
            // 我们也可以重写这个方法来实现自己的比较规则

            // getHashCode
            // 获取对象的哈希值，对象有唯一的编码，极少情况下，不同对象的哈希码可能相同

            // ToString
            // 获取对象的字符串表示
            #endregion
        }
    }
}
