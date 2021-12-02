namespace DesignPattern.CommandPattern
{
    //服务员类
    //不用管用户想要什么，反正是命令，只管记录订单，然后通知烤肉者执行即可。
    public class Waiter
    {
        Queue<Command> queue = new Queue<Command>();

        public void AddCommand(Command command, int count = 1)
        {
            for(int i = 0; i < count; i++)
            {
                queue.Enqueue(command);
            }
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
}
