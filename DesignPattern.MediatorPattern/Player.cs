namespace DesignPattern.MediatorPattern
{
    //抽象玩家类
    public abstract class AbstractCardPlayer
    {
        public int MoneyCount { get; set; }
        public AbstractCardPlayer()
        {
            this.MoneyCount = 0;
        }
        public abstract void ChangeCount(int count, AbstractMediator mediator);
    }

    //玩家A类
    public class PlayerA : AbstractCardPlayer
    {
        //通过中介者来算账，不用直接找输家了
        public override void ChangeCount(int count, AbstractMediator mediator)
        {
            mediator.AWin(count);
        }
    }

    //玩家B类
    public class PlayerB : AbstractCardPlayer
    {
        public override void ChangeCount(int count, AbstractMediator mediator)
        {
            mediator.BWin(count);
        }
    }
}
