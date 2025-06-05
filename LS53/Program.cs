namespace LS53
{
    #region 内部类
    // 内部类：在一个类的内部再声明一个类
    class Person
    {
        public int age;
        public string name;
        public Body body;
        public class Body
        {
            public Arm leftArm;
            public Arm rightArm;
            public class Arm
            {

            }
        }
    }
    #endregion

    #region 分布类
    partial class Student
    {
        public string name;
        public int num;
        #region 分布方法
        // 分布方法要写在分布类中
        partial void SpeakValue()
        {
            Console.WriteLine("我是分布方法");
        }
        #endregion
    }
    partial class Student
    {
        public string sex;
        // 分布方法
        partial void SpeakValue();
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.body = new Person.Body();
            p.body.leftArm = new Person.Body.Arm();

            Student s = new Student();
            s.name = "张三";
            s.num = 10001;
            s.sex = "男";
        }
    }
}
