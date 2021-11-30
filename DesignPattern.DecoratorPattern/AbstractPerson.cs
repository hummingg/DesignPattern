using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DecoratorPattern
{
    /// <summary>
    /// 抽象人类  
    /// </summary>
    public abstract class AbstractPerson
    {
        //展示装饰方法,我们使用装饰器模式的目的就是为了扩展这个接口的功能
        public abstract void Show();
    }
}
