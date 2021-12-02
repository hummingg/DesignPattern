using System;
using System.Collections.Generic;

namespace DesignPattern.CompositePattern
{
    /// <summary>
    /// 部门类，相当于树枝
    /// </summary>
    public class Depart : Component
    {
        public List<Component> children = new List<Component>();
        public Depart(string name) : base(name)
        {
        }
        //添加子节点
        public override void Add(Component c)
        {
            children.Add(c);
        }
        //删除子节点
        public override void Remove(Component c)
        {
            children.Remove(c);
        }
        //展示自己和和内部的所有子节点，这里是组合模式的核心
        public override void Display(int dept)
        {
            Console.WriteLine(new string('-', dept) + name);
            foreach (var item in children)
            {
                //这里用到了递归的思想
                item.Display(dept + 4);
            }
        }
    }
}
