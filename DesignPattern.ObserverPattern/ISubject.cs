using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.ObserverPattern
{
    //抽象主题角色
    public interface ISubject
    {
        //添加观察者
        void Add(Observer observer);
        //删除观察者
        void Remove(Observer observer);
        //主题状态
        string SubjectState { get; set; }
        //通知方法
        void Notify();
    }
    //***********************1.定义一个委托
    public delegate void EventHandler();
    //具体主题角色 秘书类
    public class Mishu : ISubject
    {
        public event EventHandler Update;
        //存储要通知的同事
        public IList<Observer> observers = new List<Observer>();
        public string SubjectState { get; set; }

        public void Add(Observer observer)
        {
            observers.Add(observer);
        }
        public void Remove(Observer observer)
        {
            observers.Remove(observer);
        }
        //**********2.通知方法中不能通过遍历来统一调用每个观察者的Update()方法了，改成执行一个委托
        public void Notify()
        {
            Update();
        }
    }
    //抽象观察者角色
    public abstract class Observer
    {
        protected ISubject sub;
        protected string name;
        protected Observer(string name, ISubject sub)
        {
            this.name = name;
            this.sub = sub;
        }

    }
    //具体观察者角色 看股票的同事
    public class StockObserver
    {
        public string name;
        public ISubject sub;
        public StockObserver(string name, ISubject sub)
        {
            this.name = name;
            this.sub = sub;
        }
        public void CloseStockMarket()
        {
            Console.WriteLine($"通知内容：{sub.SubjectState},反应：{name}关闭股票行情，继续工作！");
        }
    }
    //具体观察者角色 看NBA的同事
    public class NBAObserver
    {
        public string name;
        public ISubject sub;
        public NBAObserver(string name, ISubject sub)
        {
            this.name = name;
            this.sub = sub;
        }
        public void CloseNBA()
        {
            Console.WriteLine($"通知内容：{sub.SubjectState},反应：{name}关闭NBA直播，继续工作！");
        }
    }
}
