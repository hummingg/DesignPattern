using System;

namespace DesignPattern.CompositePattern
{
    //具体员工，树形结构的Leaf
    public class Employee : Component
    {
        public Employee(string name) : base(name)
        {
        }
        //Leaf不能添加/删除子节点，所以 空实现
        public override void Add(Component c)
        {
            throw new NotImplementedException();
        }
        public override void Remove(Component c)
        {
            throw new NotImplementedException();
        }
        public override void Display(int dept)
        {
            Console.WriteLine(new string('-', dept) + name);
        }
    }
}
