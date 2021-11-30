namespace DesignPattern.VisitorPattern
{
    // 抽象访问者
    public interface IVistor
    {
        void Visit(ElementA a);
        void Visit(ElementB b);
    }

    // 具体访问者
    public class ConcreteVistor : IVistor
    {
        // visit方法而是再去调用元素的Accept方法
        public void Visit(ElementA a)
        {
            a.Print();
        }
        public void Visit(ElementB b)
        {
            b.Print();
        }
    }
}
