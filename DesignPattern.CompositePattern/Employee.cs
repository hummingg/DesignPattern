using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.CompositePattern
{
    //具体员工，树形结构的Leaf
    public class Employee : Component
    {
        public Employee(string name) : base(name)
        {
            this.name = name;
        }
        //Leaf不能添加/删除子节点所以空实现
        public override void Add(Component c)
        {
        }
        public override void Remove(Component c)
        {

        }
        public override void Display(int dept)
        {
            Console.WriteLine(new string('-', dept) + name);
        }
    }
}
