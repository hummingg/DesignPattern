namespace DesignPattern.IteratorPattern
{
    // 具体迭代器类
    public class ConcreteIterator : Iterator
    {
        // 迭代器要集合对象进行遍历操作，自然就需要引用集合对象
        private ConcreteListCollection _list;
        private int _index;

        public ConcreteIterator(ConcreteListCollection list)
        {
            _list = list;
            _index = 0;
        }


        public bool MoveNext()
        {
            if (_index < _list.Length)
            {
                return true;
            }
            return false;
        }

        public Object GetCurrent()
        {
            return _list.GetElement(_index);
        }

        public void Reset()
        {
            _index = 0;
        }

        public void Next()
        {
            if (_index < _list.Length)
            {
                _index++;
            }

        }
    }
}
