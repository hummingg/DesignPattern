namespace DesignPattern.IteratorPattern
{
    // 具体迭代器类
    public class ConcreteIterator : Iterator
    {
        // 迭代器要遍历集合中对象，自然就需要引用对象集合
        // private：隐藏内部
        private ConcreteListCollection _list;
        private int _index;

        public ConcreteIterator(ConcreteListCollection list)
        {
            _list = list;
            _index = 0;
        }

        public bool IsNotEnd()
        {
            return _index < _list.Length;
        }

        public Object GetCurrent()
        {
            return _list.GetElement(_index);
        }

        public void Reset()
        {
            _index = 0;
        }

        public void MoveToNext()
        {
            if (_index < _list.Length)
            {
                _index++;
            }
        }
    }
}
