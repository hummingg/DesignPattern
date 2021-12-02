namespace DesignPattern.AbstractFactoryPattern
{
    /// <summary>
    /// Pc产品工厂抽象类
    /// </summary>
    public abstract class PcFactory
    {
        public abstract Mouse CreateMouse();
        public abstract Keyboard CreateKeyboard();
    }

    //戴尔pc工厂
    public class DellPcFactroy : PcFactory
    {
        public override Keyboard CreateKeyboard()
        {
            return new DellKeyboard();
        }

        public override Mouse CreateMouse()
        {
            return new DellMouse();
        }
    }

    //惠普pc工厂
    public class HpPcFactory : PcFactory
    {
        public override Mouse CreateMouse()
        {
            return new HpMouse();
        }
        public override Keyboard CreateKeyboard()
        {
            return new HpKeyboard();
        }
    }
}
