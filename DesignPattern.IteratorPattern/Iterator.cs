namespace DesignPattern.IteratorPattern
{
    // 迭代器抽象类
    public interface Iterator
    {
        bool IsNotEnd();
        Object GetCurrent();
        void MoveToNext();
        void Reset();
    }
}
