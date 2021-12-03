namespace DesignPattern.ObserverPattern
{
    public class Program
    {
        public static void Show()
        {
            Mishu mishu = new Mishu();

            ////观察者订阅了主题mishu
            StockObserver tongshi1 = new StockObserver("巴菲特");  // , mishu
            NBAObserver tongshi2 = new NBAObserver("麦迪");   // , mishu

            // 遍历观察者并调用观察者的方法
            mishu.observers.Add(tongshi1);  // 观察者订阅主题mishu
            mishu.observers.Add(tongshi2);
            //*******************3.将遍历观察者并调用观察者的Update()，改成了事件委托形式，以指定方法名
            mishu.Update += tongshi1.Act;  // 观察者订阅主题mishu
            mishu.Update += tongshi2.Act;

            //主题状态更改，并通知
            mishu.SubjectState = "老板回来了！";
            mishu.Notify(); // 执行Update委托中的方法
        }

        static void Main(string[] args)
        {
            Show();
        }
    }
}

// https://www.cnblogs.com/wyy1234/p/10111152.html
