namespace DesignPattern.IteratorPattern
{
    // 客户端
    class Program
    {
        static void Main(string[] args)
        {
            Iterator iterator;
            IListCollection list = new ConcreteListCollection(new int[] { 2, 4, 6, 8 });
            iterator = list.GetIterator();

            while (iterator.MoveNext())
            {
                int i = (int)iterator.GetCurrent();
                Console.WriteLine(i.ToString());
                iterator.Next();
            }
        }
    }
}


// https://www.cnblogs.com/zhili/p/IteratorPattern.html