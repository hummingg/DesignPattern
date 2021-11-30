// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


namespace DesignPattern.FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Mouse mouse;
            MouseFactory mouseFactory;

            //生产一个戴尔鼠标
            mouseFactory = new DellMouseFactroy();
            mouse = mouseFactory.CreateMouse();
            mouse.Print();

            //生产一个惠普鼠标
            mouseFactory = new HpMouseFactory();    // 只需要改变工厂，就能产生新的鼠标
            mouse = mouseFactory.CreateMouse();
            mouse.Print();
        }
    }
}