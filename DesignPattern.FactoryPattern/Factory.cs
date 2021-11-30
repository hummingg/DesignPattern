namespace DesignPattern.FactoryPattern
{
    /// <summary>
    /// 鼠标工厂抽象类
    /// </summary>
    public abstract class MouseFactory
    {
        public abstract Mouse CreateMouse();
    }

    //戴尔鼠标工厂
    public class DellMouseFactroy : MouseFactory
    {
        public override Mouse CreateMouse()
        {
            return new DellMouse();//在具体的工厂中实例化产品
        }
    }

    //惠普鼠标工厂
    public class HpMouseFactory : MouseFactory
    {
        public override Mouse CreateMouse()
        {
            return new HpMouse();//在具体的工厂中实例化产品
        }
    }
}
