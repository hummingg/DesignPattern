namespace DesignPattern.ObserverPattern
{
    //抽象观察者角色
    public abstract class Observer
    {
        //protected ISubject sub;
        protected string name;
        protected Observer(string name) // , ISubject sub
        {
            this.name = name;
            //this.sub = sub;
        }
        public abstract void Act();
    }

    //具体观察者角色 看股票的同事
    public class StockObserver : Observer
    {
        public string name;
        //public ISubject sub;
        public StockObserver(string name) : base(name)   // , ISubject sub
        {
            //this.name = name;
            //this.sub = sub;
        }
        public override void Act()
        {
            //Console.WriteLine($"通知内容：{sub.SubjectState},反应：{name}关闭股票行情，继续工作！");
            Console.WriteLine($"不管通知内容,反应：{name}关闭股票行情，继续工作！");
        }
    }

    //具体观察者角色 看NBA的同事
    public class NBAObserver : Observer
    {
        public string name;
        //public ISubject sub;
        public NBAObserver(string name) : base(name) // , ISubject sub
        {
            //this.name = name;
            //this.sub = sub;
        }
        public override void Act()
        {
            //Console.WriteLine($"通知内容：{sub.SubjectState},反应：{name}关闭NBA直播，继续工作！");
            Console.WriteLine($"不管通知内容,反应：{name}关闭NBA直播，继续工作！");
        }
    }
}
