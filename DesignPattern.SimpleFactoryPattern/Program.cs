namespace DesignPattern.SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //实例化一个工厂类
            MouseFactory mouseFactory = new MouseFactory();
            //通过工厂类创建鼠标
            Mouse mouse1 = mouseFactory.CreateMouse();
            Mouse mouse2 = mouseFactory.CreateMouse();
            Mouse mouse3 = mouseFactory.CreateMouse();
            Mouse mouse4 = mouseFactory.CreateMouse();
            Mouse mouse5 = mouseFactory.CreateMouse();
            Mouse mouse6 = mouseFactory.CreateMouse("hp");
            mouse1.Print();
            mouse3.Print();
            mouse5.Print();
            mouse6.Print();
        }
    }
}

// https://www.cnblogs.com/wyy1234/p/9978389.html