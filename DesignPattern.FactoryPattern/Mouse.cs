using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryPattern
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
}
