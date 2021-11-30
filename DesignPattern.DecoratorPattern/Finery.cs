using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DecoratorPattern
{
    //因为我们装饰后的person要直接替换装饰前的person，所以必须继承AbstractPerson
    public abstract class Finery : AbstractPerson
    {
        protected AbstractPerson person;
        //设置要打扮的人
        public void SetPerson(AbstractPerson p)
        {
            this.person = p;
        }
        public override void Show()
        {
            if (person != null)
            {
                person.Show();
            }
        }
    }
}
