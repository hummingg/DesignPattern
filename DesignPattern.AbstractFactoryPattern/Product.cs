namespace DesignPattern.AbstractFactoryPattern
{
    //鼠标抽象类
    public abstract class Mouse
    {
        public abstract void Print();
    }

    //戴尔鼠标
    public class DellMouse : Mouse
    {
        public override void Print()
        {
            Console.WriteLine("生产了一个Dell鼠标！");
        }
    }

    //惠普鼠标
    public class HpMouse : Mouse
    {
        public override void Print()
        {
            Console.WriteLine("生产了一个惠普鼠标！");
        }
    }


    //键盘抽象类
    public abstract class Keyboard
    {
        public abstract void Print();
    }

    //戴尔键盘类
    public class DellKeyboard : Keyboard
    {
        public override void Print()
        {
            Console.WriteLine("生产了一个戴尔键盘！");
        }
    }

    //惠普键盘
    public class HpKeyboard : Keyboard
    {
        public override void Print()
        {
            Console.WriteLine("生产了一个惠普键盘！");
        }
    }
}
