using System;


// https://www.cnblogs.com/wyy1234/p/10111152.html
namespace DesignPattern.ObserverPattern
{
    /// <summary>
    /// 环境：VS2019+.NetCore3.0
    /// 如果还没有这套环境，打不开代码，
    /// 请加一下小助教获取配套环境
    /// 
    /// 
    /// 场景出发--解决问题--总结沉淀--推广应用
    /// 
    /// 
    /// 适配器和代理  装饰器 很像
    /// </summary>
    public class Program
    {
        public static void Show()
        {
            Mishu mishu = new Mishu();
            //观察者订阅了主题mishu
            StockObserver tongshi1 = new StockObserver("巴菲特", mishu);
            NBAObserver tongshi2 = new NBAObserver("麦迪", mishu);
            //*******************3.将遍历观察者并调用观察者的Update()，改成了事件委托形式
            mishu.Update += tongshi1.CloseStockMarket;
            mishu.Update += tongshi2.CloseNBA;
            //主题状态更改，并通知
            mishu.SubjectState = "老板回来了！";
            mishu.Notify();
        }

        static void Main(string[] args)
        {
            Show();
        }
    }
}
