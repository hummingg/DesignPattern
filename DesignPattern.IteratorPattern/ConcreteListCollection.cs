namespace DesignPattern.IteratorPattern
{
    // 具体聚合类
    public class ConcreteListCollection : IListCollection
    {
        int[] _collection;
        public ConcreteListCollection(int[] collection)
        {
            _collection = collection;
        }

        public Iterator GetIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Length
        {
            get { return _collection.Length; }
        }

        public int GetElement(int index)
        {
            return _collection[index];
        }
    }
}
