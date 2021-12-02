namespace DesignPattern.FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Mouse mouse;
            MouseFactory mouseFactory;

            //生产一个戴尔鼠标
            mouseFactory = new DellMouseFactroy();  // 相比简单工厂，用具体工厂把方法的参数（"魔数"如"dell"）替换了。不用修改唯一的工厂的if。
            mouse = mouseFactory.CreateMouse();
            mouse.Print();

            //生产一个惠普鼠标
            mouseFactory = new HpMouseFactory();    // 只需要改变工厂，就能产生新的鼠标
            mouse = mouseFactory.CreateMouse();
            mouse.Print();
        }
    }
}

// https://www.cnblogs.com/wyy1234/p/9978966.html