namespace DesignPattern.DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Show();
        }

        public static void Show()
        {
            //首先要有打扮的人
            AbstractPerson xc = new Person() { Name = "小菜" };

            Console.WriteLine("第一种装饰-------------------");
            Finery personWithsuit = new Suit();
            Finery personWithtie = new Tie();
            Finery personWithleather = new Leather();
            //装饰过程
            personWithsuit.SetPerson(xc);//给小菜穿上西服
            personWithtie.SetPerson(personWithsuit);//给穿上西服的小菜带上领带
            personWithleather.SetPerson(personWithtie);//给穿上西服带上领带的小菜穿上皮鞋
            personWithleather.Show();

            Console.WriteLine();
            Console.WriteLine("第二种装饰-------------------");
            Finery personWithTshirt = new TShirt();
            Finery personWithSneaker = new Sneaker();
            //装饰过程
            personWithTshirt.SetPerson(xc);//给小菜穿上t恤
            personWithSneaker.SetPerson(personWithTshirt);//给穿上t恤的小菜穿上网球鞋
            personWithSneaker.Show();
            // xc.Add(Tshirt).Add(Sneaker).Show();    // 链式调用
        }
    }
}

// https://www.cnblogs.com/wyy1234/p/10017106.html