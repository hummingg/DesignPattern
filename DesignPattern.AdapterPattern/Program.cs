// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// https://www.cnblogs.com/wyy1234/p/10012506.html
namespace DesignPattern.AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //获取一个target的实例
            IAppleCharge applyAdapter = new AppleAdapter();
            applyAdapter.AppleCharge();//表面上用的苹果充电方法ApplyChange，本质上还是用的安卓充电方法AndriodChange。
        }
    }
}