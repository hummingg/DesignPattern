namespace DesignPattern.CommandPattern
{
    //服务员类
    //不用管用户想要什么，反正是命令，只管记录订单，然后通知烤肉者执行即可。
    public class Waiter
    {
        Queue<Command> queue = new Queue<Command>();

        public void SetCommand(Command command)
        {
            queue.Enqueue(command);
        }

        public void Notify()
        {
            while (queue.Count > 0)
            {
                Command command = queue.Dequeue();
                command.ExcuteCommand();
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //生成维护的类
            Waiter waiter = new Waiter();
            //真正实现代码的类
            Barbecuer barecuer = new Barbecuer();
            //传入到执行类里面去 
            Command commandwing = new BakeChickenCommand(barecuer);
            //传入执行的子类 让子类执行代码 
            waiter.SetCommand(commandwing);
            waiter.SetCommand(commandwing);
            waiter.SetCommand(commandwing);
            waiter.Notify();
            Command command = new BakeMuttonCommand(barecuer);
            waiter.SetCommand(command);
            waiter.SetCommand(command);
            waiter.Notify();
            Console.ReadKey();

        }
    }
}