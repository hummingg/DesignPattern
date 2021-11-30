namespace DesignPattern.IteratorPattern
{

    // 抽象聚合类
    // 同 IEnumerable，实现次接口后可使用 foreach 遍历元素
    public interface IListCollection
    {
        Iterator GetIterator();
    }
}
