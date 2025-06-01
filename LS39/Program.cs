namespace LS39
{
    #region 结构体
    // 自定义变量类型
    #endregion

    #region 定义结构体
    struct Stundent
    {
        public int age;
        public bool sex;
        public int number;
        public string name;

        // 结构体方法
        public void Speak()
        {
            Console.WriteLine("我叫{0}，今年{1}岁，学号{2}。", name, age, number);
        }
        // 构造函数
        public Stundent(int age, bool sex, int number, string name)
        {
            this.age = age;
            this.sex = sex;
            this.number = number;
            this.name = name;
        }
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Stundent stu = new Stundent();
            stu.age = 20;
            stu.name = "张三";
            stu.number = 1001;
            stu.Speak();

            Stundent stu2 = new Stundent(20, true, 1002, "李四");
            stu2.Speak();
        }
    }
}
