using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public class Mediator : AbstractMediator
    {
        public Mediator(AbstractCardPlayer a, AbstractCardPlayer b) : base(a, b) { }
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
