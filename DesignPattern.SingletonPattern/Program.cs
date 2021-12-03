namespace DesignPattern.SingletonPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int hashCode = 0;
            bool isSingle = true;
            for (int i = 0; i < 999_999; i++)
            {
                Singleton s = Singleton.GetInstance();  // 还需尝试多线程创建单例对象
                if (i == 0)
                {
                    hashCode = s.GetHashCode();
                }
                else
                {
                    if(hashCode != s.GetHashCode())
                    {
                        isSingle = false;
                    }
                }
            }
            Console.WriteLine($"单例对象{ (isSingle ? "没变": "变了") }");
        }
    }
}
