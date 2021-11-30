using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DecoratorPattern
{
    /// <summary>
    /// 人类  具体组件角色
    /// </summary>
    public class Person : AbstractPerson
    {
        public string Name { get; set; }
        //待添加功能的Show方法，具体组件中的Show方法只有原始功能
        public override void Show()
        {
            Console.Write($"打扮的人是{this.Name}：");
        }
    }
}
