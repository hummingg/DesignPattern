namespace DesignPattern.AdapterPattern
{
    /// <summary>
    /// 苹果适配器 适配器角色
    /// </summary>
    public class Android2AppleAdapter : IAppleCharge
    {
        AndroidLine androidLine;
        public Android2AppleAdapter(AndroidLine line)
        {
            androidLine = line;//适配器内部包含一个Adaptee对象
        }
        
        public void AppleCharge()
        {
            androidLine.AndroidCharge();//客户端调用时，表面上是用的是AppleCharge方法,本质还是用的AndroidCharge方法
        }
    }
}
