namespace DesignPattern.AdapterPattern
{
    /// <summary>
    /// 安卓数据线，adaptee角色
    /// </summary>
    public abstract class AndroidLine
    {
        public virtual void AndroidCharge()
        {
            Console.WriteLine("安卓数据线充电....");
        }
    }

    public class HuaweiLine : AndroidLine
    {
        public override void AndroidCharge()
        {
            Console.WriteLine("华为数据线充电....");
        }
    }
}
