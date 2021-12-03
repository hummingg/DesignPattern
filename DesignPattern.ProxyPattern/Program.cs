namespace DesignPattern.ProxyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //因为不能直接访问到真实对象，所以我们不能直接new ShyBoy()去送礼物。

            //代码中使用的是代理对象
            Friend friend = new Friend();
            friend.GiveGift();
        }
    }
}

// https://www.cnblogs.com/wyy1234/p/10013436.html