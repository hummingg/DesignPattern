namespace DesignPattern.AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PcFactory pcFactory;
            Mouse mouse;
            Keyboard keyboard;

            //生产一个戴尔鼠标/键盘，组成一套戴尔电脑
            pcFactory = new DellPcFactroy();
            mouse = pcFactory.CreateMouse();
            keyboard = pcFactory.CreateKeyboard();
            mouse.Print();
            keyboard.Print();

            //生产一个惠普鼠标/键盘，组成一套惠普电脑
            pcFactory = new HpPcFactory();
            mouse = pcFactory.CreateMouse();
            keyboard = pcFactory.CreateKeyboard();
            mouse.Print();
            keyboard.Print();
        }
    }
}

// https://www.cnblogs.com/wyy1234/p/9986575.html