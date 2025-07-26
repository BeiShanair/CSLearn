#define Fun
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace LS89
{
    #region 特性
    // 特性是一种允许我们向程序集添加元数据的语言结构
    // 用于保持程序结构信息的某种特殊类型的类
    // 可以利用特性类为元数据添加额外的信息
    // 之后可以通过反射来获取这些额外信息
    #endregion

    #region 自定义特性
    class TestAttribute : Attribute
    {
        public string info;
        public TestAttribute(string info)
        {
            this.info = info;
        }
    }
    #endregion

    #region 特性的使用
    // 基本语法
    // [特性名(参数列表)]

    [Test("这是一个测试特性")]
     class TestClass
    {
        [Test("给变量添加信息")]
        public int i;

        [Test("给方法添加信息")]
        public void TestMethod([Test("给参数添加信息")] int a)
        {

        }
    }
    #endregion

    #region 限制自定义特性的使用范围
    // 使用AttributeUsage特性来限制自定义特性的使用范围

    // 第一个参数，特性能用在哪些地方； 第二个参数，是否运行多个特性实例用在同一个目标上； 第三个参数，是否能被子类或重写方法继承
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true, Inherited = true)]
    class TestSecondAttribute : Attribute
    {
        public string info;
        public TestSecondAttribute(string info)
        {
            this.info = info;
        }
    }
    #endregion

    #region 系统自带特性
    // 过时特性
    class TestClass2
    {
        // 第二个参数，true，直接报错； false，编译器发出警告
        [Obsolete("该方法已过时，请使用NewSpeak", false)]
        public void OldSpeak(string s)
        {

        }
        public void NewSpeak(string s)
        {

        }
        public void SpeakCaller(string name, [CallerFilePath]string filename = "",
            [CallerLineNumber]int line = 0, [CallerMemberName]string member = "")
        {

        }
    }

    // 调用者信息
    // CallerMemberName，调用成员的名称； CallerFilePath，调用成员的文件路径； CallerLineNumber，调用成员的行号
    // 需要引用using System.Runtime.CompilerServices;

    // 条件编译
    // Conditional 特性，用于控制是否编译某个代码块，与预处理指令配合使用
    // 需要引用using System.Diagnostics;
    
    // 外部Dll包函数特性
    // DllImport 特性，用于调用外部Dll包中的函数
    // 需要引用using System.Runtime.InteropServices;
    // 一般用来调用C 或者C++写的函数
    #endregion
    internal class Program
    {
        [Conditional("Fun")]
        static void Fun()
        {
            Console.WriteLine("Fun");
        }
        static void Main(string[] args)
        {
            #region 特性的使用
            TestClass t = new TestClass();
            Type type = t.GetType();
            if (type.IsDefined(typeof(TestAttribute), false)) // 第一个参数是特性的类型，第二个参数是是否搜索继承链
            {
                Console.WriteLine("TestClass类有TestAttribute特性");
            }
            object[] array = type.GetCustomAttributes(true);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] is TestAttribute)
                {
                    Console.WriteLine((array[i] as TestAttribute).info);
                }
            }
            Fun();
            #endregion
        }
    }
}
