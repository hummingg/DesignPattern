namespace DesignPattern.CommandPattern.Invoker
{
    // 教官，负责调用命令对象执行请求
    public class Invoker
    {
        public Command _command;

        public Invoker(Command command)
        {
            this._command = command;
        }

        public void ExecuteCommand()
        {
            _command.Action();
        }
    }

    // 命令抽象类
    public abstract class Command
    {
        // 命令应该知道接收者是谁，所以有Receiver这个成员变量
        protected Receiver _receiver;

        public Command(Receiver receiver)
        {
            this._receiver = receiver;
        }

        // 命令执行方法
        public abstract void Action();
    }

    //
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver)
            : base(receiver)
        {
        }

        public override void Action()
        {
            // 调用接收的方法，因为执行命令的是学生
            _receiver.Run1000Meters();
        }
    }

    // 命令接收者——学生
    public class Receiver
    {
        public void Run1000Meters()
        {
            Console.WriteLine("跑1000米");
        }
    }

    // 院领导
    class Program
    {
        static void Show(string[] args)
        {
            // 初始化Receiver、Invoke和Command
            Receiver r = new Receiver();
            Command c = new ConcreteCommand(r);
            Invoker i = new Invoker(c);

            // 院领导发出命令,教官让学生跑
            i.ExecuteCommand();
        }
    }
}

// https://www.cnblogs.com/zhili/p/CommandPattern.html