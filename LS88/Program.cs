using System.Reflection;

namespace LS88
{
    class Test
    {
        private int i = 1;
        public int j = 0;
        public string str = "123";

        public Test()
        {

        }

        public Test(int i)
        {
            this.i = i;
        }

        public Test(int i, string str): this(i)
        {
            this.str = str;
        }

        public void Speak()
        {
            Console.WriteLine("Speak");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 程序集
            // 程序集是由编译器编译得到的，供进一步编译执行的中间产物
            // 在Windows系统中，程序集的扩展名是.exe或.dll
            #endregion

            #region 元数据
            // 元数据是用描述数据的数据，类、函数、变量等都是程序的元数据
            #endregion

            #region 反射的概念
            // 反射是程序运行时，动态获取程序集、类型、成员的信息，并动态创建对象、调用方法、访问成员的一种机制
            #endregion

            #region 反射作用
            // 反射可以在程序编译后获得信息，提高了程序的拓展性和灵活性
            // 1. 程序运行时得到所有元数据，包括元数据的特性
            // 2. 程序运行时，实例化对象，操作对象
            // 3. 程序运行时创建新的对象，用这些对象执行任务
            #endregion

            #region 语法

            #region Type
            // Type是类的信息类，是反射的基础
            // 它是访问元数据的主要方式，使用Type类可以获取类的所有信息

            // 获取Type对象
            int a = 42;
            Type type = a.GetType();
            Console.WriteLine(type);

            Type type2 = typeof(int);
            Console.WriteLine(type2);

            Type type3 = Type.GetType("System.Int32");
            Console.WriteLine(type3);

            // 获得类的程序集
            Console.WriteLine(type.Assembly);

            // 获取类中的所有的公共成员
            Type type4 = typeof(Test);
            MemberInfo[] memberInfos = type4.GetMembers();
            for (int i = 0; i < memberInfos.Length; i++)
            {
                MemberInfo mi = memberInfos[i];
                Console.WriteLine(mi);
            }

            Console.WriteLine("====================================");

            // 获取类中的公共构造函数并调用
            ConstructorInfo[] ctor = type4.GetConstructors();
            for (int i = 0; i < ctor.Length; i++)
            {
                Console.WriteLine(ctor[i]);
            }
            // 获取一个构造函数执行
            ConstructorInfo info = type4.GetConstructor(new Type[0]);// 无参构造函数
            Test t = info.Invoke(null) as Test;
            Console.WriteLine(t.j);
            ConstructorInfo info2 = type4.GetConstructor(new Type[] { typeof(int) });// 有参构造函数
            Test t2 = info2.Invoke(new object[] { 123 }) as Test;
            Console.WriteLine(t2.str);
            ConstructorInfo info3 = type4.GetConstructor(new Type[] { typeof(int), typeof(string) });// 有参构造函数
            Test t3 = info3.Invoke(new object[] { 123, "abc" }) as Test;
            Console.WriteLine(t3.str);

            Console.WriteLine("====================================");

            // 获取类的公共成员变量
            FieldInfo[] fieldInfos = type4.GetFields();
            for (int i = 0; i < fieldInfos.Length; i++)
            {
                Console.WriteLine(fieldInfos[i]);
            }
            // 得到指定名称的成员变量
            FieldInfo fi = type4.GetField("j");
            Console.WriteLine(fi);
            // 通过反射获取和设置对象的值
            Test t4 = new Test();
            t4.j = 123;
            t4.str = "abc";
            FieldInfo fi2 = type4.GetField("j");
            Console.WriteLine(fi2.GetValue(t4));
            fi2.SetValue(t4, 456);
            Console.WriteLine(t4.j);

            Console.WriteLine("====================================");
            // 获得类中的公共成员方法
            Type strT = typeof(string);
            MethodInfo[] methodInfos = strT.GetMethods();
            //for (int i = 0; i < methodInfos.Length; i++)
            //{
            //    Console.WriteLine(methodInfos[i]);
            //}
            // 获取一个方法
            MethodInfo sub = strT.GetMethod("Substring",
                new Type[] { typeof(int), typeof(int) });
            string str = "Hello  World!";
            object result = sub.Invoke(str, new object[] { 7, 5 });
            Console.WriteLine(result);

            // 其他
            // 获取枚举
            // GetEnumNames
            // GetEnumName

            // 获取事件
            // GetEvents
            // GetEvent

            // 获取接口
            // GetInterfaces
            // GetInterface

            // 获取属性
            // GetProperty
            // GetProperties

            #endregion

            Console.WriteLine("====================================");
            #region Assembly
            // 这是程序集类
            // 主要用来加载其他程序集，加载后获取程序集信息
            // 如果不是自己程序集中的内容，需要先加载程序集，比如dll文件
            // 可以将其视为一种代码仓库，供开发者使用

            // 语法
            // 1. 加载同一个文件下的其他程序集
            // Assembly assembly = Assembly.Load("程序集名称");

            // 2. 加载指定路径下的程序集
            // Assembly assembly = Assembly.LoadFrom("路径");
            // Assembly assembly = Assembly.LoadFile("路径");

            Assembly assembly = Assembly.LoadFrom("D:\\cs\\Learn\\LS86\\bin\\Debug\\net8.0\\LS86");
            Type[] type5 = assembly.GetTypes();
            for (int i = 0; i < type5.Length; i++)
            {
                Console.WriteLine(type5[i]);
            }

            Console.WriteLine("====================================");

            Type program = assembly.GetType("LS86.Program");
            MethodInfo[] methodInfos2 = program.GetMethods();
            for (int i = 0; i < methodInfos2.Length; i++)
            {
                Console.WriteLine(methodInfos2[i]);
            }

            #endregion

            Console.WriteLine("====================================");

            #region Activator
            // Activator是反射中创建对象的主要方式
            // 可以快速实例化Type对象

            // 无参构造
            Type type21 = typeof(Test);
            Test testobj = Activator.CreateInstance(type21) as Test;
            Console.WriteLine(testobj.str);

            // 有参构造
            testobj = Activator.CreateInstance(type21, 123) as Test;
            Console.WriteLine(testobj.j);
            testobj = Activator.CreateInstance(type21, 123, "abc") as Test;
            Console.WriteLine(testobj.str);
            #endregion

            #endregion
        }
    }
}
