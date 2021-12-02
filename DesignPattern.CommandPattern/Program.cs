namespace DesignPattern.CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //生成维护的类
            Waiter waiter = new Waiter();
            //真正实现代码的类
            Barbecuer barecuer = new Barbecuer();
            //传入到执行类里面去 
            Command cmdChicken = new BakeChickenCommand(barecuer);
            Command cmdMutton = new BakeMuttonCommand(barecuer);

            //传入执行的子类 让子类执行代码
            waiter.AddCommand(cmdChicken, 3);
            waiter.Notify();

            waiter.AddCommand(cmdMutton, 2);
            waiter.Notify();

        }
    }
}

// https://blog.csdn.net/Carrie_Q/article/details/80577264