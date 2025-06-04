namespace LS46
{
    internal class Program
    {
        class Person
        {
            public string name;
            public int age;
            #region 构造函数
            // 类在没有定义构造函数时，会默认有一个无参构造函数
            // 但写了有参构造函数之后，如果不定义无参构造函数，那么在实例化对象时，无参构造函数就不可用
            public Person()
            {
                this.name = "张三";
                this.age = 18;
            }
            public Person(string name,int age)
            {
                this.name = name;
                this.age = age;
            }

            // 特殊写法，用:this调用其他构造函数
            public Person(string name):this(name,18)
            {
                Console.WriteLine("调用其他构造函数");
            }
            #endregion

            #region 析构函数
            // 概念：当一个对象被销毁时，触发垃圾回收，会自动调用该对象的析构函数
            // 但C#有自动垃圾回收机制，一般不会在代码中写析构函数
            ~Person()
            {
                Console.WriteLine("调用析构函数");
            }
            #endregion
        }

        #region 垃圾回收机制
        // 垃圾回收，GC
        // 会遍历堆上的内容如果发现某个对象没有引用指向它，那么就会销毁这个对象，释放内存空间
        // 分为0代、1代和2代内存
        // 当0代内存满时，会触发垃圾回收，将0代内存中的对象销毁，如果被销毁的对象引用了其他对象，那么这些对象会被移动到1代内存
        // 1代满了也同理
        // 大对象（>85KB）会直接分配到2代内存中

        // 手动触发
        // GC.Collect();
        // 一般会在加载场景等情况下触发
        #endregion

        static void Main(string[] args)
        {
            Person person = new Person("张三", 18);
            Person person1 = new Person("李四");

            person = null;
        }
    }
}
