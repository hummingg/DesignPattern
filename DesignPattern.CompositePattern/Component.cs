namespace DesignPattern.CompositePattern
{
    /// <summary>
    /// 抽象部件 定义了树枝和树叶的公共属性和接口
    /// </summary>
    public abstract class Component
    {
        public string name;
        public Component(string name)
        {
            this.name = name;
        }
        //添加子节点
        public abstract void Add(Component c);
        //删除子节点
        public abstract void Remove(Component c);
        //展示方法，dept为节点深度
        public abstract void Display(int dept);
    }
}
