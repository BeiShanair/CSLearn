namespace LS48
{
    internal class Program
    {
        class Person
        {
            #region 索引器
            // 索引器是可以让对象可以像数组这样访问其中元素

            private string name;
            private int age;
            private Person[] friends;

            public Person this[int index]
            {
                get
                {
                    if (friends == null)
                    {
                        return null;
                    }
                    else
                    {
                        return friends[index];
                    }
                }
                set
                {
                    if (friends == null)
                    {
                        friends = new Person[] { value };
                    }
                    else if (index > friends.Length)
                    {
                        friends[friends.Length - 1] = value;
                    }
                    
                    friends[index] = value;
                }
            }
            #endregion
        }
        static void Main(string[] args)
        {
            Person person = new Person();
            person[0] = new Person();
            Console.WriteLine(person[0]);
        }
    }
}
