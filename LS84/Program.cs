namespace LS84
{
    // 让自定义的类可以比较，需要实现IComparable接口，并重写CompareTo方法
    class Item : IComparable<Item>
    {
        public int money;
        public Item(int money)
        {
            this.money = money;
        }

        // 重写比较方法
        public int CompareTo(Item? other)
        {
            // 返回值含义：如果小于0，则放在传入对象的前面；如果等于0，则保持顺序不变；如果大于0，则放在传入对象的后面
            if (this.money < other.money)
            {
                return -1;
            }
            else
            {
                return 1;
            }

        }
    }

    class Weapon
    {
        public int id;
        public Weapon(int id)
        {
            this.id = id;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List排序
            #region 自带排序方法
            List<int> list = new List<int>();
            list.Add(2);
            list.Add(1);
            list.Add(7);
            list.Add(5);
            list.Add(4);

            list.Sort();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            #endregion


            #region 自定义排序方法
            List<Item> list2 = new List<Item>();
            list2.Add(new Item(23));
            list2.Add(new Item(12));
            list2.Add(new Item(74));
            list2.Add(new Item(55));
            list2.Add(new Item(47));

            list2.Sort();
            foreach (var item in list2)
            {
                Console.WriteLine(item.money);
            }
            #endregion

            #region 通过委托排序
            List<Weapon> list3 = new List<Weapon>();
            list3.Add(new Weapon(2));
            list3.Add(new Weapon(1));
            list3.Add(new Weapon(7));
            list3.Add(new Weapon(5));
            list3.Add(new Weapon(4));
            list3.Add(new Weapon(3));

            list3.Sort(delegate (Weapon a, Weapon b)
            {
                if (a.id > b.id)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            });
            foreach (var item in list3)
            {
                Console.WriteLine(item.id);
            }
            #endregion
            #endregion
        }
    }
}
