namespace DesignPattern.VisitorPattern
{

    // 抽象元素角色
    public abstract class Element
    {
        public abstract void Accept(IVistor vistor);
        public abstract void Print();
    }

    // 具体元素A
    public class ElementA : Element
    {
        public override void Accept(IVistor vistor)
        {
            // 调用访问者visit方法
            vistor.Visit(this);
        }
        public override void Print()
        {
            Console.WriteLine("我是元素A");
        }
    }

    // 具体元素B
    public class ElementB : Element
    {
        public override void Accept(IVistor vistor)
        {
            vistor.Visit(this);
        }
        public override void Print()
        {
            Console.WriteLine("我是元素B");
        }
    }

}
