namespace DesignPattern.MediatorPattern
{
    //抽象中介者
    public abstract class AbstractMediator
    {
        //中介者必须知道所有同事
        public AbstractCardPlayer A;

        public AbstractCardPlayer B;

        public AbstractMediator(AbstractCardPlayer a, AbstractCardPlayer b)
        {
            A = a;
            B = b;
        }
        public abstract void AWin(int count);

        public abstract void BWin(int count);
    }

    //具体中介者
    public class ConcreteMediator : AbstractMediator
    {
        public ConcreteMediator(AbstractCardPlayer a, AbstractCardPlayer b) : base(a, b) { }

        public override void AWin(int count)
        {
            A.MoneyCount += count;
            B.MoneyCount -= count;
        }

        public override void BWin(int count)
        {
            A.MoneyCount -= count;
            B.MoneyCount += count;
        }
    }
}
