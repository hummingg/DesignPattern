namespace DesignPattern.AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AndroidLine androidLine = new HuaweiLine();    // HuaweiLine...
            //获取一个target的实例
            IAppleCharge applyAdapter = new Android2AppleAdapter(androidLine);
            applyAdapter.AppleCharge();//表面上用的苹果充电方法AppleCharge，本质上还是用的安卓充电方法AndroidCharge。
        }
    }
}

// https://www.cnblogs.com/wyy1234/p/10012506.html