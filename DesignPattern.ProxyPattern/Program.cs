// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// https://www.cnblogs.com/wyy1234/p/10013436.html
namespace DesignPattern.ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //因为不能直接访问到真实对象所以我们不能直接new ShyBoy()去送礼物。

            //代码中使用的是代理对象
            Friend friend = new Friend();
            friend.GiveGift();
            Console.ReadKey();
        }
    }
}