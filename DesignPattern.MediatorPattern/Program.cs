namespace DesignPattern.MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Show();
        }

        public static void Show()
        {
            AbstractCardPlayer a = new PlayerA() { MoneyCount = 20 };
            AbstractCardPlayer b = new PlayerB() { MoneyCount = 20 };
            AbstractMediator mediator = new ConcreteMediator(a, b);

            //玩家a赢了玩家b 5 元
            Console.WriteLine("a赢了b5元");
            a.ChangeCount(5, mediator);
            Console.WriteLine($"玩家a现在有{a.MoneyCount}元");
            Console.WriteLine($"玩家b现在有{b.MoneyCount}元");

            //玩家b赢了玩家a 10 元
            Console.WriteLine("b赢了a10元");
            b.ChangeCount(10, mediator);
            Console.WriteLine($"玩家a现在有{a.MoneyCount}元");
            Console.WriteLine($"玩家b现在有{b.MoneyCount}元");
        }
    }
}

// https://www.cnblogs.com/wyy1234/p/10099216.htmls