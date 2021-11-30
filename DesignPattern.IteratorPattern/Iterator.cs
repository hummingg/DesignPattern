namespace DesignPattern.IteratorPattern
{
    // 迭代器抽象类
    public interface Iterator
    {
        bool MoveNext();
        Object GetCurrent();
        void Next();
        void Reset();
    }
}
