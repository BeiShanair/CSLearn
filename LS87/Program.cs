#define Unity
namespace LS87
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 编译器
            // 编译器将源语言翻译成目标语言
            // 如将C#、Java等高级语言翻译成机器语言
            #endregion

            #region 预处理指令
            // 预处理指令是编译器在编译程序之前会先执行的一段指令
            // 都以#开头
            // 它不是语句，所以不以;结束
            #endregion

            #region 常见的预处理指令
            // #define 定义一个符号
            // #undef 取消一个符号，这两个都是写在最前面的，一般配合#if或特性使用

            // #if 判断一个符号是否被定义
            // #else 如果#if的条件不满足，则执行#else后面的代码
            // #elif 如果#if的条件不满足，则执行#elif后面的代码
            // #endif 结束#if的条件判断
            #if Unity
            Console.WriteLine("Unity");
            #endif

            // #warnning 输出一个警告信息
            // #error 输出一个错误信息
            #endregion
        }
    }
}
