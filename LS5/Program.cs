namespace LS5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 常量
            // 语法：
            // const 数据类型 常量名 = 常量值;
            const float PI = 3.14f;
            Console.WriteLine(PI);
            #endregion

            #region 常量的特点
            // 1. 常量在定义的时候必须赋值
            // 2. 常量一旦赋值就不能修改
            // const float PI2; // 错误
            // PI = 3.1415926f; // 错误
            #endregion
        }
    }
}
