﻿namespace LS67
{
    #region 结构体与类的区别
    // 1. 结构体是值类型，类是引用类型
    // 2. 结构体不能继承，类可以继承
    // 3. 结构体存在栈上，类存在堆上
    // 4. 结构体不能初始化成员变量，类可以
    // 5. 结构体不能使用protected修饰符，类可以
    // 6. 结构体不能声明无参构造函数，类可以
    // 7. 结构体不能声明析构函数，类可以
    // 8. 结构体声明有参构造函数时，无参构造函数不会丢失
    // 9. 结构体需要在构造函数中初始化所有成员变量，类随意
    // 10. 结构体不能被static修饰，类可以
    // 11. 结构体不能在内部声明与它同名的结构体变量，类可以

    // 结构体可以实现接口

    // 多态、继承，考虑类
    // 数据集合，考虑结构体
    #endregion

    #region 抽象类与接口的区别
    // 1. 抽象类可以包含字段、属性、方法、事件、构造函数、析构函数等，接口只能包含方法、属性、事件、索引器
    // 2. 抽象类可以包含实现的方法，接口只能包含抽象方法（不能实现）
    // 3. 抽象类可以有构造函数，接口没有
    // 4. 抽象类单一继承，而接口可以实现多个
    
    // 表示对象用抽象类，行为拓展用接口
    // 比如不同对象有相同的行为，可以用接口实现
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
