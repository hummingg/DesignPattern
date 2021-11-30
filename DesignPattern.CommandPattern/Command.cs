namespace DesignPattern.CommandPattern
{
    public abstract class Command
    {
        protected Barbecuer receiver;

        //抽象命令类，只需确定“烤肉串者”是谁即可
        public Command(Barbecuer receiver)
        {
            this.receiver = receiver;
        }

        //执行命令
        abstract public void ExcuteCommand();
    }

    //烤羊肉串类
    class BakeMuttonCommand : Command
    {
        public BakeMuttonCommand(Barbecuer receiver)
            : base(receiver)
        {
        }

        //重写方法，具体命令类，执行命令时，执行具体行为
        public override void ExcuteCommand()
        {
            receiver.BakeMutton();
        }
    }

    //烤鸡类
    class BakeChickenCommand : Command
    {
        public BakeChickenCommand(Barbecuer receiver)
            : base(receiver)
        {
        }

        public override void ExcuteCommand()
        {
            receiver.BakeChicken();
        }
    }
}
